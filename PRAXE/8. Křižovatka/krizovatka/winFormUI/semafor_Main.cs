using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormUI
{
    public partial class semafor_Main : UserControl
    {
        private int _status;

        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                update();
            }
        }
        public semafor_Main()
        {
            InitializeComponent();
        }

        private void update()
        {
            switch(Status)
            {
                case 0:
                    red.Status = false;
                    yellow.Status = false;
                    green.Status = false;
                    break;
                case 1:
                    red.Status = true;
                    yellow.Status = false;
                    green.Status = false;
                    break;
                case 2:
                    red.Status = true;
                    yellow.Status = true;
                    green.Status = false;
                    break;
                case 3:
                    red.Status = false;
                    yellow.Status = false;
                    green.Status = true;
                    break;
                case 4:
                    red.Status = false;
                    yellow.Status = true;
                    green.Status = false;
                    break;
            }
        }
    }
}
