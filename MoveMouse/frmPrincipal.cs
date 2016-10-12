using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveMouse
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MoveCursor()
        {
            // Limitar área de uso
            //Cursor.Clip = new Rectangle(0, 0, 1920, 1080);

            /*int xPosition = Form.MousePosition.X;
            int yPosition = Form.MousePosition.Y;

            MessageBox.Show("Posição X " + xPosition + " Y " + yPosition);*/

            this.Cursor = new Cursor(Cursor.Current.Handle);
            int xPosition = Cursor.Position.X;
            int yPosition = Cursor.Position.Y;
            

            if(xPosition <= 0)
            {
                Cursor.Position = new Point(1920, Cursor.Position.Y);
            }
            else
            {
                Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y);
            }
            

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.MoveCursor();
        }

        private void btnMousePosition_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMouseMove_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
        }

        private void btnStopMouse_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
        }
    }
}
