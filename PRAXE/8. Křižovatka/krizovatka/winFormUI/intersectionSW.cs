using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace winFormUI
{
    public partial class intersectionSW : UserControl
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

        public intersectionSW()
        {
            InitializeComponent();
        }

        private void update()
        {
            if(Configuration != null)
            {
                TopRoad_ForwardRight.Status = Configuration.TopRoad.ForwardRight;
                TopRoad_Left.Status = Configuration.TopRoad.Left;
                TopRoad_CrossWalk.Status = Configuration.TopRoad.CrossWalk;

                BottomRoad_ForwardRight.Status = Configuration.BottomRoad.ForwardRight;
                BottomRoad_Left.Status = Configuration.BottomRoad.Left;
                BottomRoad_CrossWalk.Status = Configuration.BottomRoad.CrossWalk;

                LeftRoad_Main.Status = Configuration.LeftRoad.Main;
                LeftRoad_Arrow.Status = Configuration.LeftRoad.Right;
                LeftRoad_CrossWalk.Status = Configuration.LeftRoad.CrossWalk;

                RightRoad_Main.Status = Configuration.RightRoad.Main;
                RightRoad_Arrow.Status = Configuration.RightRoad.Right;
                RightRoad_CrossWalk.Status = Configuration.RightRoad.CrossWalk;
            }
        }
    }
}
