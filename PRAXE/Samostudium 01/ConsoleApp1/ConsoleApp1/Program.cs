using System;

namespace ConsoleApp1
{
    class Program
    {
        static Citac citac;
        static void Main(string[] args)
        {
            //úvodní zprávy
            Console.WriteLine("Zadejte limit čítače: ");

            int cislo = Int32.Parse(Console.ReadLine());
            citac = new Citac(cislo);
            citac.limitDosazen += limitDosazen;

            Console.WriteLine("Stiskněte šipku nahoru pro inkrementaci čítače");
            Console.WriteLine("Stiskněte šipku dolu pro dekrementaci čítače");
            while (true)
            {
                //reakce na stisk kláves
                switch(Console.ReadKey().Key)
                {
                    //šipka nahoru
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Inkrementace, aktuální stav: " + citac.getState());
                        citac.scitani(1);
                        break;
                    //šipka dolu
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Dekrementace, aktuální stav: " + citac.getState());
                        citac.scitani(-1);
                        break;
                }
            }
        }

        //event listener
        static void limitDosazen(object sender, argumenty e)
        {
            //výpis na konzoli
            Console.WriteLine("Čítač by přeplněn v hodnotě " + e.hodnota + " v čase " + e.datum);
            Console.WriteLine("program ho vyresetuje");
            //reset citac
            citac.Reset();
        }
    }

    class Citac
    {
        private int limit;
        private int stav;

        //konstruktor třídy
        public Citac(int passedLimit)
        {
            limit = passedLimit;
        }

        private void test() {
            if (Math.Abs(stav) >= limit)
            {
                argumenty args = new argumenty();
                args.hodnota = stav;
                args.datum = DateTime.Now;
                //vyvolani eventu
                dosazeni(args);
            }
        }

        //scitani
        public void scitani(int x)
        {
            stav += x;
            this.test();
        }

        //reset
        public void Reset()
        {
            stav = 0;
        }

        //vrácení stavu
        public int getState() {
            return stav;
        }

        //vznik eventu
        protected virtual void dosazeni(argumenty e)
        {
            EventHandler<argumenty> handler = limitDosazen;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        //definice eventu
        public event EventHandler<argumenty> limitDosazen;
    }

    //třída argumentů
    public class argumenty : EventArgs
    {
        public int hodnota { get; set; }
        public DateTime datum { get; set; }
    }
}
