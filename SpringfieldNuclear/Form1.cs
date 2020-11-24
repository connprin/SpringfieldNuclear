using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Reactor2StateLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)


        {
            SoundPlayer Player = new SoundPlayer (Properties.Resources.alert);
            Player.Play();
            outputLabel.Text = "Meltdown";
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

          
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

        } 
        
         

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
