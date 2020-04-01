using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace winFormUI
{
    public partial class Form1 : Form
    {
        //definice proměnných
        private static List<List<IntersectionConfiguration>> configurations;
        private static IntersectionHW IntersectionHW = new IntersectionHW();

        private static int Index  { get; set; }
        private static Boolean Run { get; set; }

        public Form1()
        {
            //inicializace
            InitializeComponent();
            initializeConfigurations();

            buttonCheckTimer.Stop();

            //nastavení listboxu
            rezimListBox.Items.Add("Denní režim");
            rezimListBox.Items.Add("Noční režim");
            rezimListBox.SelectedIndex = 0;

            //nastavení dalších komponent
            setButtonToStart();
            nextConfigurationTimer.Stop();
            Run = false;

            //výchozí konfigurace
            loadConfiguration(0, rezimListBox.SelectedIndex);
            Index = 1;
        }

        //inicializace konfigurací
        private static void initializeConfigurations()
        {
            configurations = new List<List<IntersectionConfiguration>>
            {
                new List<IntersectionConfiguration>
                {
                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 2, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 2, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 3, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 3, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 3
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 4, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 4, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 2, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 2, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 3, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 3, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 1, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 1, CrossWalk = 1 },
                        Duration = 3
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 4, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 4, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 2, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 2, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 3, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 3, Right = 0, CrossWalk = 1 },
                        Duration = 3
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 4, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 4, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 1 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 1 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 2 },
                        BottomRoad = new MainRoad { ForwardRight = 1, Left = 1, CrossWalk = 2 },
                        LeftRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 2 },
                        RightRoad = new MinorRoad { Main = 1, Right = 0, CrossWalk = 2 },
                        Duration = 3
                    },
                },

                new List<IntersectionConfiguration>
                {
                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 4, Left = 4, CrossWalk = 0 },
                        BottomRoad = new MainRoad { ForwardRight = 4, Left = 4, CrossWalk = 0 },
                        LeftRoad = new MinorRoad { Main = 4, Right = 0, CrossWalk = 0 },
                        RightRoad = new MinorRoad { Main = 4, Right = 0, CrossWalk = 0 },
                        Duration = 1
                    },

                    new IntersectionConfiguration
                    {
                        TopRoad = new MainRoad { ForwardRight = 0, Left = 0, CrossWalk = 0 },
                        BottomRoad = new MainRoad { ForwardRight = 0, Left = 0, CrossWalk = 0 },
                        LeftRoad = new MinorRoad { Main = 0, Right = 0, CrossWalk = 0 },
                        RightRoad = new MinorRoad { Main = 0, Right = 0, CrossWalk = 0 },
                        Duration = 1
                    }
                }
            };
        }

        //reakce na tiknutí timeru
        private void nextConfigurationTimer_Tick(object sender, EventArgs e)
        {
            loadConfiguration(Index, rezimListBox.SelectedIndex); //zisk konfigurace
            Index++;
            //vynulování indexu, pokud inex přetekl velikost listu
            if(Index >= configurations[rezimListBox.SelectedIndex].Count) {
                Index = 0;
            }
        }

        //změna denní/noční
        private void rezimListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadConfiguration(0, rezimListBox.SelectedIndex);
            Index = 1;
        }

        //nahrání aktuální konfigurace do křižovatky
        private void loadConfiguration(int i, int mode)
        {
            IntersectionConfiguration config = configurations[mode][i];
            nextConfigurationTimer.Interval = config.Duration*1000; //nastavení timeru

            intersectionSW.Configuration = config;
            IntersectionHW.Configuration = config;
        }

        //tlačítko START/STOP
        private void stopButton_Click(object sender, EventArgs e)
        {
            if(Run)
            {
                //zastavení běhu
                nextConfigurationTimer.Stop();
                Run = false;
                setButtonToStart();
            } else
            {
                //spuštění běhu
                nextConfigurationTimer.Start();
                Run = true;
                setButtonToStop();
            }
        }

        private void setButtonToStop()
        {
            stopButton.BackColor = Color.FromName("ControlDarkDark");
            stopButton.Text = "Stop";
        }

        private void setButtonToStart()
        {
            stopButton.BackColor = Color.FromName("Red");
            stopButton.Text = "Start";
        }

        //terminace komunikace s deskami při zavření programu
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IntersectionHW.CloseConnection();
        }

        //kontrola tlačítek na modelu křižovatky
        private void buttonCheckTimer_Tick(object sender, EventArgs e)
        {
            Boolean[] result = IntersectionHW.ButtonsPress();
            if(result[0] && !result[1])
            {
                rezimListBox.SelectedIndex = 0;
            } else if (!result[0] && result[1])
            {
                rezimListBox.SelectedIndex = 1;
            }
        }
    }
}
