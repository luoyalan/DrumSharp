using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrumSharp
{
    public partial class Form1 : Form
    {
        private List<Control> instruments = new List<Control>();
        private List<Stream> sounds = new List<Stream>();
        public Form1()
        {
            InitializeComponent();
            instruments.Add(panel1);
            instruments.Add(panel2);
            instruments.Add(panel3);
            instruments.Add(panel4);
            instruments.Add(panel5);
            instruments.Add(panel6);
            instruments.Add(panel7);
            instruments.Add(panel8);
            sounds.Add(Properties.Resources.HatCl);
            sounds.Add(Properties.Resources.HatOpn);
            sounds.Add(Properties.Resources.Kick);
            sounds.Add(Properties.Resources.Ride);
            sounds.Add(Properties.Resources.Snare);
            sounds.Add(Properties.Resources.TomHi);
            sounds.Add(Properties.Resources.TomLo);
            sounds.Add(Properties.Resources.TomMid);
            for (int i = 0; i < instruments.Count; i++)
            {
                instruments[i].Click += readPanelNum;
            }
            //Cursor cur = new Cursor(Properties.Resources.Schuh.GetHicon());
            //this.Cursor = cur;
        }
        
        private void readPanelNum(object sender, EventArgs e)
        {
            Control panelNum = (Control)sender;
            int index = instruments.IndexOf(panelNum);
            PlaySound(index);
        }

        private void PlaySound(int index)
        {
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(sounds[index]);
            snd.Play();
        }


    }
}
