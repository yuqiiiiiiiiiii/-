using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace finalproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Computer C =new Computer();
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            f.Show();
            this.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    C.Audio.Play(Properties.Resources.y799, AudioPlayMode.Background);
                    break;
                case Keys.F:
                    C.Audio.Play(Properties.Resources.y799, AudioPlayMode.Background);
                    break;
                case Keys.J:
                    C.Audio.Play(Properties.Resources.y799, AudioPlayMode.Background);
                    break;
                case Keys.K:
                    C.Audio.Play(Properties.Resources.y799, AudioPlayMode.Background);
                    break;



            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    C.Audio.Play(Properties.Resources.y799, AudioPlayMode.Background);
                    break;
                case Keys.F:
                    C.Audio.Play(Properties.Resources.y799, AudioPlayMode.Background);
                    break;
                case Keys.J:
                    C.Audio.Play(Properties.Resources.y799, AudioPlayMode.Background);
                    break;
                case Keys.Space:
                    C.Audio.Play(Properties.Resources.未聞花名music, AudioPlayMode.Background);
                    break;



            }
        }
    }
}
