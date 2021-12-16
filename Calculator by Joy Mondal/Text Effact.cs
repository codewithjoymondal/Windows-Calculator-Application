using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_by_Joy_Mondal
{
    public partial class Text_Effact : Label
    {
        public Text_Effact()
        {
            InitializeComponent();
            UseCompatibleTextRendering = true;
            this.BackColor = Color.White;
            timer1.Start();
        }
        int position, speed;

        public int set_speed { get { return speed; } set { speed = value; Invalidate(); } }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform((float)position,0);
            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (position<-Width)
            {
                position = Width;
            }
            position -= speed;
            Invalidate();
        }
    }
}
