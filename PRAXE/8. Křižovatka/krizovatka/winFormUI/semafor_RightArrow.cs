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
    public partial class semafor_RightArrow : UserControl
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
        public semafor_RightArrow()
        {
            InitializeComponent();
        }

        private void update()
        {
            green.Status = Status != 0;
        }
    }
}
