/*Zapojeni
Port P3 - input
0 bit		1 bit		2 bit			3 bit
zakladna	Hl.rameno	rameno chapadla	chapadlo
Port P2 - output
0 bit	1 bit			2 bit		3 bit		4 bit				5 bit
takt	smer otaceni	zakladna	Hl.rameno	rameno 	chapadla	chapadlo*/

#include <time.h>
#include <conio.h>
#include <stdio.h>
#include <dos.h>

//pohon, ktery nema koncak
#define NOLIMIT -1

//porty
#define P1 0x300
#define P2 0x301
#define P3 0x300
#define P4 0x301

#define CLOCK_BIT 0
#define DIRECTION_BIT 1

//sipky na klávesnici
#define UP 72
#define DOWN 80
#define LEFT 75
#define RIGHT 77

//trida citace, je vyuzit pro generovani taktu
class counter
{
private:
	int count, resolution, prescaler, prescalerCount;

public:
	//nastaveni citace
	//resolution, prescaler
	void begin(int a, int b)
	{
		resolution = a;
		prescaler = b;
		count = 0;
		prescalerCount = 0;
	}

	//cyklus citace
	void run()
	{
		if (prescalerCount >= prescaler)
		{
			count++;
			prescalerCount = 0;
		}
		if (count + 1 > resolution)
		{
			count = 0;
		}
		prescalerCount++;
	}

	//vrati hodnotu citace
	int getCount()
	{
		return count;
	}
};

//definice structu pro smery pohonu
typedef struct
{
	char name[50];
	char limit;
	char key;
} direction;


//definice structu pro jeden pohon
typedef struct
{
	char name[50];
	direction directions[2];
	char bit;
} actuator;

//nadefinovani vsech pohonu do jednoho pole structu "actuator"
actuator actuators[4] = {
	{"Otaceni zakladny", {{"Proti hodinovym rucickam", NOLIMIT, 'a'}, {"hodinovych rucicek", NOLIMIT, 'd'}}, 2},
	{"Hlavni rameno", {{"nahoru", 1, 's'}, {"dolu", NOLIMIT, 'w'}}, 3},
	{"Rameno chapadla", {{"dolu", NOLIMIT, UP}, {"nahoru", 2, DOWN}}, 4},
	{"Chapadlo", {{"Otevrit", 3, LEFT}, {"zavrit", NOLIMIT, RIGHT}}, 5}};

//vrati pocet milisekund od startu programu
unsigned long millis()
{
	return (clock() * 1000) / CLOCKS_PER_SEC;
}

int main(void)
{
	//inicializace proměnných
	char pressedKey;
	char state = 1;
	char in;
	char out;
	unsigned long keyMillis = 0;
	counter clock;
	char kbhitChange = 0;
	clock.begin(2, 150);	//nastaveni citace 2-pocet poloh; 150-preddelicka
	while (1)
	{
		//zjisteni stisknute klavesy
		if (kbhit())
		{
			pressedKey = getch();
			kbhitChange = 1;
		}
		else
		{
			kbhitChange = 0;
			if ((millis() - keyMillis) > 100)
				pressedKey = 0;
		}
		out = 0xFF;
		//precteni vstupniho portu
		in = inport(P3);
		char i;
		//stavovy diagram
		switch (state)
		{
			//stav poslani pohonu do vychozich poloh
		case 0:
			char enable = -1;
			//projeti vsech pohonu
			for (i = 0; i < sizeof(actuators) / sizeof(actuator); i++)
			{
				//ve vsech smerech
				for (char j = 0; j < 2; j++)
				{
					//pokud ma pohon a dany smer nadefinovany koncovy spinac a spinac je zaclonen
					if (actuators[i].directions[j].limit != NOLIMIT && (in & (1 << actuators[i].directions[j].limit)))
					{
						//pokud neni zadny jiny pohon aktivovan
						if (enable == -1)
						{
							out &= ~(!j << DIRECTION_BIT);
							out &= ~(1 << actuators[i].bit);
							enable = j;
						}
						//pokud je smer uz aktivovaneho pohon stejny
						//jako smer aktualniho pohonu muzeme ho zapnout
						else if (enable == j)
						{
							out &= ~(1 << actuators[i].bit);
						}
					}
				}
			}
			//pokud jsme nespustili zadny pohon, znamena to, ze jsme vychozich polohach
			//a muzeme stav 0 opustit a prejit do ovladani ramena klavesnici
			if (enable == -1)
				state = 1;
			break;
		case 1:
			//klavesou 'r' muzeme spustit stav presunu do vychozich poloh
			if (pressedKey == 'r')
			{
				state = 0;
			}
			//projeti vsech pohonu
			for (i = 0; i < sizeof(actuators) / sizeof(actuator); i++)
			{
				//ve vsech smerech
				for (char j = 0; j < 2; j++)
				{
					//pokud je zmacknuta klavesa, ktera je prirazena pohonu
					if (actuators[i].directions[j].key == pressedKey)
					{
						//zobrazeni informace na displeji
						if (kbhitChange)
						{
							if ((millis() - keyMillis) > 500)
							{
								printf("Kapitane mame dotek na pohonu: %s\n\r", actuators[i].name);
								printf("ve smeru: %s\n\r", actuators[i].directions[j].name);
							}
							keyMillis = millis();
						}
						//zjistime zda jsme na koncovem spinaci
						if (actuators[i].directions[j].limit != NOLIMIT && !(in & (1 << actuators[i].directions[j].limit)))
						{
							printf("Jsme na limetu\n\r");
						}
						//pokud ne, pohon zapneme
						else
						{
							out &= ~(!j << DIRECTION_BIT);
							out &= ~(1 << actuators[i].bit);
						}
						//Hihi, goto :-) 
						goto breakOutOfLoops;
					}
				}
			}
		breakOutOfLoops:
			break;
		}
		//pridame do vystupniho bytu takt
		out &= ~(clock.getCount() << CLOCK_BIT);
		//hodime byte na port a aktualizujeme clock
		outportb(P2, out);
		clock.run();
		if (pressedKey == 27)
		{
			break;
		}
	}
	//konec programu a navrat do Borlanda
	while (!kbhit())
		;
	return 0;
}