using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Random slump = new Random();
        int gissningar = 0;
        int random1;

        public Form1()
        {
          random1 = slump.Next(0, 101);
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = ("Gissa ett tal mellan 1-100");
            int gissning = int.Parse(textBox1.Text);
            gissningar++;

            if (gissning < random1)
            {
              label1.Text = ("För lågt, gissa högre!" + gissning);
                

            }
            else if (gissning > random1)
            {
                label1.Text = ("Du gissade för högt, gissa lägre!" + gissning);
         
            }
            else
            {
                label1.Text = ("Rätt! Du gissade:" + gissningar + "gånger");

            }

        }
    }
}
