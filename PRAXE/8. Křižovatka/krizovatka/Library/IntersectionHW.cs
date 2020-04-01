using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Library
{
    public class IntersectionHW
    {
        private IntersectionConfiguration _configuration;

        public IntersectionConfiguration Configuration
        {
            get
            {
                return _configuration;
            }

            set
            {
                _configuration = value;
                update();
            }
        }

        private void update()
        {
            OpenDevice(0);
            switch (Configuration.TopRoad.ForwardRight)
            {
                case 0:
                    ClearDigitalChannel(0);
                    ClearDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
                case 1:
                    SetDigitalChannel(0);
                    ClearDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
                case 2:
                    SetDigitalChannel(0);
                    SetDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
                case 3:
                    ClearDigitalChannel(0);
                    ClearDigitalChannel(1);
                    SetDigitalChannel(2);
                    break;
                case 4:
                    ClearDigitalChannel(0);
                    SetDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
            }

            switch (Configuration.TopRoad.Left)
            {
                case 0:
                    ClearDigitalChannel(3);
                    ClearDigitalChannel(4);
                    ClearDigitalChannel(5);
                    break;
                case 1:
                    SetDigitalChannel(3);
                    ClearDigitalChannel(4);
                    ClearDigitalChannel(5);
                    break;
                case 2:
                    SetDigitalChannel(3);
                    SetDigitalChannel(4);
                    ClearDigitalChannel(5);
                    break;
                case 3:
                    ClearDigitalChannel(3);
                    ClearDigitalChannel(4);
                    SetDigitalChannel(5);
                    break;
                case 4:
                    ClearDigitalChannel(3);
                    SetDigitalChannel(4);
                    ClearDigitalChannel(5);
                    break;
            }

            switch (Configuration.TopRoad.CrossWalk)
            {
                case 0:
                    ClearDigitalChannel(6);
                    ClearDigitalChannel(7);
                    break;
                case 1:
                    SetDigitalChannel(6);
                    ClearDigitalChannel(7);
                    break;
                case 2:
                    ClearDigitalChannel(6);
                    SetDigitalChannel(7);
                    break;
            }

            OpenDevice(1);

            switch (Configuration.LeftRoad.Main)
            {
                case 0:
                    ClearDigitalChannel(0);
                    ClearDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
                case 1:
                    SetDigitalChannel(0);
                    ClearDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
                case 2:
                    SetDigitalChannel(0);
                    SetDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
                case 3:
                    ClearDigitalChannel(0);
                    ClearDigitalChannel(1);
                    SetDigitalChannel(2);
                    break;
                case 4:
                    ClearDigitalChannel(0);
                    SetDigitalChannel(1);
                    ClearDigitalChannel(2);
                    break;
            }

            WriteDigitalChannel(3, Configuration.LeftRoad.Right == 1);

            switch (Configuration.TopRoad.CrossWalk)
            {
                case 0:
                    ClearDigitalChannel(4);
                    ClearDigitalChannel(5);
                    break;
                case 1:
                    SetDigitalChannel(4);
                    ClearDigitalChannel(5);
                    break;
                case 2:
                    ClearDigitalChannel(4);
                    SetDigitalChannel(5);
                    break;
            }
        }

        public Boolean[] ButtonsPress()
        {
            OpenDevice(1);
            Boolean[] array = new Boolean[2];
            array[0] = ReadDigitalChannel(6);
            array[1] = ReadDigitalChannel(7);
            return array;
        }

        private void WriteDigitalChannel(int channel, Boolean value)
        {
            if(value)
            {
                SetDigitalChannel(channel);
            }
            else
            {
                ClearDigitalChannel(channel);
            }
        }

        public void CloseConnection()
        {
            CloseDevice();
        }

        [DllImport("k8055d.dll")]
        private static extern int OpenDevice(int CardAddress);
        [DllImport("k8055d.dll")]
        private static extern void CloseDevice();
        [DllImport("k8055d.dll")]
        private static extern int ReadAnalogChannel(int Channel);
        [DllImport("k8055d.dll")]
        private static extern void ReadAllAnalog(ref int Data1, ref int Data2);
        [DllImport("k8055d.dll")]
        private static extern void OutputAnalogChannel(int Channel, int Data);
        [DllImport("k8055d.dll")]
        private static extern void OutputAllAnalog(int Data1, int Data2);
        [DllImport("k8055d.dll")]
        private static extern void ClearAnalogChannel(int Channel);
        [DllImport("k8055d.dll")]
        private static extern void SetAllAnalog();
        [DllImport("k8055d.dll")]
        private static extern void ClearAllAnalog();
        [DllImport("k8055d.dll")]
        private static extern void SetAnalogChannel(int Channel);
        [DllImport("k8055d.dll")]
        private static extern void WriteAllDigital(int Data);
        [DllImport("k8055d.dll")]
        private static extern void ClearDigitalChannel(int Channel);
        [DllImport("k8055d.dll")]
        private static extern void ClearAllDigital();
        [DllImport("k8055d.dll")]
        private static extern void SetDigitalChannel(int Channel);
        [DllImport("k8055d.dll")]
        private static extern void SetAllDigital();
        [DllImport("k8055d.dll")]
        private static extern bool ReadDigitalChannel(int Channel);
        [DllImport("k8055d.dll")]
        private static extern int ReadAllDigital();
        [DllImport("k8055d.dll")]
        private static extern int ReadCounter(int CounterNr);
        [DllImport("k8055d.dll")]
        private static extern void ResetCounter(int CounterNr);
        [DllImport("k8055d.dll")]
        private static extern void SetCounterDebounceTime(int CounterNr, int DebounceTime);
        [DllImport("k8055d.dll")]
        private static extern int Version();
        [DllImport("k8055d.dll")]
        private static extern int SearchDevices();
        [DllImport("k8055d.dll")]
        private static extern int SetCurrentDevice(int lngCardAddress);
        [DllImport("k8055d.dll")]
        private static extern int ReadBackDigitalOut();
        [DllImport("k8055d.dll")]
        private static extern void ReadBackAnalogOut(int[] Buffer);
    }
}

