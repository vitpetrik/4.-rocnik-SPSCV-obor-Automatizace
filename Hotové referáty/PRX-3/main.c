/* ---------------------------------------------------------------
		
			 Daniel Dobeš A4
	
		 Program - Robot Nisa 600
		 Hardware: Robot NISA 600
		 Version: 3.0

		 Connection
			OUT
			- Port 1
				bit 0 - motor base
				bit 1 - motor main arm
				bit 2 - motor minor arm
				bit 3 - motor gripper
				bit 5 - direction
			- Port 2
				bit 7 - clock pulse
			
			IN
			- Port 3
				bit 0-3 - IR sensors
			- Port 4

		Comment

-----------------------------------------------------------------*/	

	//Initialization
	#include <conio.h>
	#include <stdio.h>
	#include <dos.h>

	int mask1 = 0x01;
	int mask2 = 0x02;
	int mask3 = 0x04;
	int mask4 = 0x08;
	//	base	-	main	-	minor	-	gripper
	int position1, position2, position3, position4;
	int position1max, position2max = 800;
	int position3max, position4max = 400;
	int index = 0;		//used in switch
	int index2;		//uesd as a control variable - text
	int temp;
	int port1, port3 = 0x301;
	int port2, port4 = 0x300;
	int time = 50;	//used in delay 50ms
		
	int main(void)
	{
		//Set default position
		do //base position
		{
			temp = inportb(port3);	//load port
			temp = temp & mask1;	//mask
			outportb(port1, 0xDE);	//0b1101_1110
			delay(time);
			outportb(port2, 0X7F);	//0b0111_1111
			delay(time);
			outportb(port2, 0xFF);	//0b1111_1111
		} while (temp != 0)
		
		do //main arm position
		{
			temp = inportb(port3);
			temp = temp & mask2;
			outportb(port1, 0xDD);	//0b1101_1101
			delay(time);
			outportb(port2, 0X7F);	//0b0111_1111
			delay(time);
			outportb(port2, 0xFF);	//0b1111_1111
		} while (temp != 0)

		do //minor arm position
		{
			temp = inportb(port3);
			temp = temp & mask3;
			outportb(port1, 0xFB);	//0b1111_1011
			delay(time);
			outportb(port2, 0X7F);	//0b0111_1111
			delay(time);
			outportb(port2, 0xFF);	//0b1111_1111
		} while (temp != 0)

		do //gripper position
		{
			temp = inportb(port3);
			temp = temp & mask4;
			outportb(port1,0xD7);	//0b1101_0111
			delay(time);
			outportb(port2, 0X7F);	//0b0111_1111
			delay(time);
			outportb(port2, 0xFF);	//0b1111_1111
		} while (temp != 0)

		//Show - control method
		clrscr();	//clear()
		printf("\nOvladani: ");
		printf("\nZakladna a <-> d");
		printf("\nVetsi Rameno w - nahoru; d - dolu");
		printf("\nMensi Rameno r - nahoru; f - dolu");
		printf("\nChapadlo e - uchyceni; q - uvolneni");
		
		while(true);
		{
			if (kbhit())	//control pressed key
			{
				index = getch();
			}
			switch(index)
			{
				case 0:
				{
					outportb(port1,0xFF);	//all motor off
				}
					break;

				case 97:	//pressed "a" - base left
				{
					//checking the limit position
					temp = inportb(port3);
					temp = temp & mask1;
					if (temp == 0) printf("\nBylo dosazeno koncove polohy!");
					else
					{
						position1--;
						outportb(port1,0xDE);	//0b1101_1110
						//Show text only once
						if (index2 != 1) printf("\nZakladna se pohybuje vlevo!");
						index2 = 1; 
					}
					index = 0;
				}
					break;


				case 100:	//pressed "d" - base right
				{
					if (position1 == position1max) printf("\nBylo dosazeno koncove polohy!");
					else
					{
						position1++;
						outportb(port1,0xFE);	//0b1111_1110
						//Show text only once
						if (index2 != 2) printf("\nZakladna se pohybuje vpravo!");
						index2 = 2;
					}
					index = 0;
				}
					break;

				case 119:	//pressed "w" - main arm up
				{
					//checking the limit position
					temp = inportb(port3);
					temp = temp & mask2;
					if (temp == 0) printf("\nBylo dosazeno koncove polohy!");
					else
					{
						position2--;
						outportb(port1,0xDD);	//0b1101_1101
						//Show text only once
						if (index2 != 3) printf("\nVetsi rameno se zveda!");
						index2 = 3;
					}	
					index = 0;
				}
				break;
				
				case 115:	//pressed "s" - main arm down
				{
					if(position2 == position2max) printf("\nBylo dosazeno koncove polohy!");
					else
					{
						position2++;
						outportb(port1,0xFD);	//0b1111_1101
						//Show text only once
						if (index2 != 4) printf("\nVetsi rameno klesa!");
						index2 = 4;
					}
					index = 0;
				}					
					break;

				case 114:	//pressed "r" - minor arm up
				{
					//checking the limit position					
					temp = inportb(port3);
					temp = temp & mask3;
					if (temp == 0) printf("\nBylo dosazeno koncove polohy!");
					else
					{
						position3--;
						outportb(port1,0xFB);	//0b1111_1011
						//Show text only once
						if (index2 != 5) printf("\nMensi rameno se zveda!");
						index2 = 5;
					}
					index = 0;
				}
					break;

				case 102:	//pressed "f" - minor arm up
				{
					if (position3 == position3max) printf("\nBylo dosazeno koncove polohy!");
					else
					{
						position3++;
						outportb(port1,0xDB);	//0b1101_1011
						//Show text only once
						if(index2 != 6) printf("\nMensi rameno klesa!");
						index2 = 6
					}
					index = 0;
				}
					break;
				
				case 101:	//pressed "e" - gripping
				{
					if(position4 == position4max) printf("\nChapadlo sevreno!");
					else
					{
						position4++;
						outportb(port1, 0xF7);	//0b1111_0111
						//Show text only once
						if (index2 != 7) printf("\nChapaldo se svira"");
						index2 = 7;
					}					
					index = 0;
				}
					break;

				case 113:	//pressed "q" - release
				{
					//checking the limit position					
					temp = inportb(port3);
					temp = temp & mask4;
					if (temp == 0) printf("\nChapadlo rozevreno!");
					else
					{
						position4--;
						outportb(port1,0xD7);	//0b1101_0111
						//Show text only once
						if (index2 != 8) printf("\nChapadlo se rozevira!");
						index2 = 8;
					}
					index = 0;
				}					
					break;
			}	//end of switch
		
			//clock pulse
			delay(time);		
			outportb (port2, 0X7F); //0111_1111
			delay(time);
			outportb (port2, 0xFF); //1111_1111

		}	//end of while
	}


