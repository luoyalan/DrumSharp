using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrumSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Click += Panel1_Click;
            //Cursor cur = new Cursor(Properties.Resources.Schuh.GetHicon());
            //this.Cursor = cur;
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.HatCl;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }



    }
}
