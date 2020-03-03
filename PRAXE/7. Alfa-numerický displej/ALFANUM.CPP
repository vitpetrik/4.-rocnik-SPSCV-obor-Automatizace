#include <time.h>
#include <conio.h>
#include <stdio.h>
#include <dos.h>
#include <stdlib.h>
#include <iostream.h>

#define P1 0x300
#define P2 0x301
#define P3 0x300
#define P4 0x301

#define TAB 9
#define BACKSPACE 8
#define ESC 27

#define NUMERIC_DISP 0
#define ALPHANUMERIC_DISP 1

char PORT[4];

typedef struct
{
	char port;
	char bit;
} pin;

//vrati pocet milisekund od startu programu
unsigned long millis()
{
	return (clock() * 1000) / CLOCKS_PER_SEC;
}

//trida citace, je vyuzit pro generovani taktu
class Counter
{
private:
	int count, resolution, prescaler, prescalerCount;

public:
	//nastaveni citace
	//resolution, prescaler
	void setup(int res, int pre)
	{
		resolution = res;
		prescaler = pre;
		count = 0;
		prescalerCount = 0;
	}

	//vrati hodnotu citace
	int getCount()
	{
		return count;
	}

	void reset()
	{
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
};

class SerialTransmit
{
private:
	pin Tx, Clk;
	Counter square;
	char *buffer;
	int bufferSize;
	int index;
	char completed;

public:
	SerialTransmit()
	{
		square.setup(4, 0);
		index = 0;
		bufferSize = 0;
		completed = 1;
	}

	void setup(pin Tx_pin, pin Clk_pin)
	{
		Tx = Tx_pin;
		Clk = Clk_pin;
	}

	char write(char *buff, int size)
	{
		if (!transmitCompleted())
			return 0;
		buffer = buff;
		bufferSize = size;
		index = 0;
		completed = 0;
		return 1;
	}

	char transmitCompleted()
	{
		return completed;
	}

	void run()
	{
		if (!completed)
		{
			PORT[Clk.port] ^= (-(square.getCount() / 2) ^ PORT[Clk.port]) & (1UL << Clk.bit);
			if (square.getCount() == 1)
			{
				PORT[Tx.port] ^= (-(!!(buffer[index] & (1 << 0))) ^ PORT[Tx.port]) & (1UL << Tx.bit);
				index++;
				bufferSize--;
			}
			square.run();
			if (!bufferSize && (square.getCount() == 0))
			{
				completed = 1;
				square.reset();
			}
		}
		else
		{
			PORT[Clk.port] ^= (-0 ^ PORT[Clk.port]) & (1UL << Clk.bit);
			PORT[Tx.port] ^= (-0 ^ PORT[Tx.port]) & (1UL << Tx.bit);
		}
	}
};

class M5451
{
private:
	static const unsigned char SevenSegmentASCII[96];
	static const unsigned int FourteenSegmentASCII[96];

	SerialTransmit serial;
	char *string;

	char displayType;
	char newString;
	char anodeSwitch;

	char outputBuffer[36];

	void addToBuffer7seg(char byte, char startBit, char numOfBits)
	{
		for (char i = 0; i < numOfBits; i++)
		{
			outputBuffer[startBit + i] = !!(byte & (1 << i));
		}
	}

	void addToBuffer14seg(int byte, char startBit, char numOfBits)
	{
		static char bitPosition[15] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
		for (char i = 0; i < numOfBits; i++)
		{
			outputBuffer[startBit + bitPosition[i]] = !!(byte & (1 << i));
		}
	}

public:
	M5451(pin Tx_pin, pin Clk_pin, char disp, char *s)
	{
		onChange();
		serial.setup(Tx_pin, Clk_pin);
		displayType = disp;
		string = s;
		anodeSwitch = 0;
	}

	//nastavení pointeru na stringu
	void setString(char *s)
	{
		onChange();
		string = s;
	}

	void setDisplayType(char disp)
	{
		onChange();
		displayType = disp;
	}

	char getDisplayType()
	{
		return displayType;
	}

	void onChange()
	{
		newString = 1;
		for (char i = 0; i < 36; i++)
		{
			outputBuffer[i] = 0;
		}
	}

	char transmitCompleted()
	{
		return serial.transmitCompleted();
	}

	void run()
	{
		switch (displayType)
		{
		case NUMERIC_DISP:
			if (newString && transmitCompleted())
			{
				char stringElement = 0;
				outputBuffer[0] = 1;
				for (char i = 0; i < 5; i++)
				{
					stringElement = string[i] >= ' ' ? SevenSegmentASCII[string[i] - ' '] : 0;
					addToBuffer7seg(stringElement, (i * 7) + 1, 7);
				}
				serial.write(outputBuffer, sizeof(outputBuffer) / sizeof(*outputBuffer));
				newString = 0;
			}
			break;
		case ALPHANUMERIC_DISP:
			if (transmitCompleted())
			{
				int stringElement = 0;
				outputBuffer[0] = 1;
				char help = 0;
				if (!anodeSwitch)
				{
					stringElement = string[0] >= ' ' ? FourteenSegmentASCII[string[0] - ' '] : 0;
					addToBuffer14seg(stringElement, 1, 15);

					stringElement = string[2] >= ' ' ? FourteenSegmentASCII[string[2] - ' '] : 0;
					addToBuffer14seg(stringElement, (1 * 15) + 1, 15);
				}
				else
				{
					stringElement = string[1] >= ' ' ? FourteenSegmentASCII[string[1] - ' '] : 0;
					addToBuffer14seg(stringElement, (1 * 15) + 1, 15);

					stringElement = string[3] >= ' ' ? FourteenSegmentASCII[string[3] - ' '] : 0;
					addToBuffer14seg(stringElement, (1 * 15) + 1, 15);
				}
				outputBuffer[31] = !anodeSwitch;
				outputBuffer[32] = anodeSwitch;

				serial.write(outputBuffer, sizeof(outputBuffer) / sizeof(*outputBuffer));
				anodeSwitch = !anodeSwitch;
			}
			break;
		}
		serial.run();
	}
};

const unsigned char M5451::SevenSegmentASCII[96] = {
	0x00, /* (space) */
	0x86, /* ! */
	0x22, /* " */
	0x7E, /* # */
	0x6D, /* $ */
	0xD2, /* % */
	0x46, /* & */
	0x20, /* ' */
	0x29, /* ( */
	0x0B, /* ) */
	0x21, /* * */
	0x70, /* + */
	0x10, /* , */
	0x40, /* - */
	0x80, /* . */
	0x52, /* / */
	0x3F, /* 0 */
	0x06, /* 1 */
	0x5B, /* 2 */
	0x4F, /* 3 */
	0x66, /* 4 */
	0x6D, /* 5 */
	0x7D, /* 6 */
	0x07, /* 7 */
	0x7F, /* 8 */
	0x6F, /* 9 */
	0x09, /* : */
	0x0D, /* ; */
	0x61, /* < */
	0x48, /* = */
	0x43, /* > */
	0xD3, /* ? */
	0x5F, /* @ */
	0x77, /* A */
	0x7C, /* B */
	0x39, /* C */
	0x5E, /* D */
	0x79, /* E */
	0x71, /* F */
	0x3D, /* G */
	0x76, /* H */
	0x30, /* I */
	0x1E, /* J */
	0x75, /* K */
	0x38, /* L */
	0x15, /* M */
	0x37, /* N */
	0x3F, /* O */
	0x73, /* P */
	0x6B, /* Q */
	0x33, /* R */
	0x6D, /* S */
	0x78, /* T */
	0x3E, /* U */
	0x3E, /* V */
	0x2A, /* W */
	0x76, /* X */
	0x6E, /* Y */
	0x5B, /* Z */
	0x39, /* [ */
	0x64, /* \ */
	0x0F, /* ] */
	0x23, /* ^ */
	0x08, /* _ */
	0x02, /* ` */
	0x5F, /* a */
	0x7C, /* b */
	0x58, /* c */
	0x5E, /* d */
	0x7B, /* e */
	0x71, /* f */
	0x6F, /* g */
	0x74, /* h */
	0x10, /* i */
	0x0C, /* j */
	0x75, /* k */
	0x30, /* l */
	0x14, /* m */
	0x54, /* n */
	0x5C, /* o */
	0x73, /* p */
	0x67, /* q */
	0x50, /* r */
	0x6D, /* s */
	0x78, /* t */
	0x1C, /* u */
	0x1C, /* v */
	0x14, /* w */
	0x76, /* x */
	0x6E, /* y */
	0x5B, /* z */
	0x46, /* { */
	0x30, /* | */
	0x70, /* } */
	0x01, /* ~ */
	0x00, /* (del) */
};
const unsigned int M5451::FourteenSegmentASCII[96] = {
	0x0000, /* (space) */
	0x4006, /* ! */
	0x0202, /* " */
	0x12CE, /* # */
	0x12ED, /* $ */
	0x3FE4, /* % */
	0x2359, /* & */
	0x0200, /* ' */
	0x2400, /* ( */
	0x0900, /* ) */
	0x3FC0, /* * */
	0x12C0, /* + */
	0x0800, /* , */
	0x00C0, /* - */
	0x4000, /* . */
	0x0C00, /* / */
	0x0C3F, /* 0 */
	0x0406, /* 1 */
	0x00DB, /* 2 */
	0x008F, /* 3 */
	0x00E6, /* 4 */
	0x2069, /* 5 */
	0x00FD, /* 6 */
	0x0007, /* 7 */
	0x00FF, /* 8 */
	0x00EF, /* 9 */
	0x1200, /* : */
	0x0A00, /* ; */
	0x2440, /* < */
	0x00C8, /* = */
	0x0980, /* > */
	0x5083, /* ? */
	0x02BB, /* @ */
	0x00F7, /* A */
	0x128F, /* B */
	0x0039, /* C */
	0x120F, /* D */
	0x0079, /* E */
	0x0071, /* F */
	0x00BD, /* G */
	0x00F6, /* H */
	0x1209, /* I */
	0x001E, /* J */
	0x2470, /* K */
	0x0038, /* L */
	0x0536, /* M */
	0x2136, /* N */
	0x003F, /* O */
	0x00F3, /* P */
	0x203F, /* Q */
	0x20F3, /* R */
	0x00ED, /* S */
	0x1201, /* T */
	0x003E, /* U */
	0x0C30, /* V */
	0x2836, /* W */
	0x2D00, /* X */
	0x00EE, /* Y */
	0x0C09, /* Z */
	0x0039, /* [ */
	0x2100, /* \ */
	0x000F, /* ] */
	0x2800, /* ^ */
	0x0008, /* _ */
	0x0100, /* ` */
	0x1058, /* a */
	0x2078, /* b */
	0x00D8, /* c */
	0x088E, /* d */
	0x0858, /* e */
	0x14C0, /* f */
	0x048E, /* g */
	0x1070, /* h */
	0x1000, /* i */
	0x0A10, /* j */
	0x3600, /* k */
	0x0030, /* l */
	0x10D4, /* m */
	0x1050, /* n */
	0x00DC, /* o */
	0x0170, /* p */
	0x0486, /* q */
	0x0050, /* r */
	0x2088, /* s */
	0x0078, /* t */
	0x001C, /* u */
	0x0810, /* v */
	0x2814, /* w */
	0x2D00, /* x */
	0x028E, /* y */
	0x0848, /* z */
	0x0949, /* { */
	0x1200, /* | */
	0x2489, /* } */
	0x0CC0, /* ~ */
	0x0000, /* (del) */
};

int main(void)
{
	//inicializace promennych a tridy displeje
	system("cls");
	char inputStr[] = "12345";
	cout << "Zobrazeny text muzete zmenit pomoci klavesy backspace\n\r";
	cout << "Typ displeje pomoci klavesy TAB\n\r";
	pin Tx = {0, 0};
	pin Clk = {0, 1};
	M5451 display(Tx, Clk, NUMERIC_DISP, inputStr);
	char exitLoop = 0;
	while (1)
	{
		//vezme stisknutou klavesu (pokud nejake je)
		if (kbhit())
		{
			switch (getch())
			{
			case BACKSPACE:
				cout << "\n\rZadejte text k zobrazeni: ";
				gets(inputStr);
				display.onChange();
				break;
			case TAB:
				display.setDisplayType(!display.getDisplayType());
				break;
			case ESC:
				exitLoop = 1;
				break;
			}
		}

		display.run();

		outportb(P1, PORT[0]);

		//pokud zmackneme ESC a je dokonceno vysilani opustime smycku
		if (exitLoop && display.transmitCompleted())
		{
			break;
		}
	}
	//konec programu a navrat do Borlanda
	while (!kbhit())
		;
	return 0;
}