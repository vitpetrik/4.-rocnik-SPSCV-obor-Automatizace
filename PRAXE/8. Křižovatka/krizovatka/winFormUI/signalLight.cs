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
    public partial class signalLight : UserControl
    {
        private String _color;
        private Boolean _enabled;

        public String SignalColor
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                drawSignal(drawBox.CreateGraphics(), GetColor());
            }
        }

        public Boolean Status
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                drawSignal(drawBox.CreateGraphics(), GetColor());
            }
        }

        public signalLight()
        {
            InitializeComponent();
        }

        private void drawSignal(Graphics g, Color c)
        {
            SolidBrush brush = new SolidBrush(c);
            g.FillEllipse(brush, 0, 0, 20, 20);
        }

        private void drawBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            if(SignalColor != null)
            {
                drawSignal(g, GetColor());
            }
        }

        private Color GetColor()
        {
            if(Status)
            {
                switch(SignalColor)
                {
                    case "red":
                        return ColorTranslator.FromHtml("#ff0000");
                    case "yellow":
                        return ColorTranslator.FromHtml("#ffff00");
                    case "green":
                        return ColorTranslator.FromHtml("#00ff00");
                }
            }
            else
            {
                switch (SignalColor)
                {
                    case "red":
                        return ColorTranslator.FromHtml("#600000");
                    case "yellow":
                        return ColorTranslator.FromHtml("#606000");
                    case "green":
                        return ColorTranslator.FromHtml("#006000");
                }
            }
            return Color.Black;
        }
    }
}
