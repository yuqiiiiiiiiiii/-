using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace finalproject
{


    public partial class Form2 : Form
    {
        Computer C = new Computer();
        private Color _originalColor;
        private Timer ColorChangeTimer;
        
        public Form2()
        {
            InitializeComponent();

            _originalColor = label1.BackColor;
            ColorChangeTimer = new Timer();
            a1pause = new Timer();
            a1fall = new Timer();
            ColorChangeTimer.Interval = 100;    
            ColorChangeTimer.Tick += new EventHandler(timer1_Tick);
        }
        private Boolean hit(Label B, PictureBox T)
        {
            if (B.Right < T.Left )
            {
                return false;
            }
            if (B.Left > T.Right)
            {
                return false;
            }
            if (B.Bottom < T.Top)
            {
                return false;
            }
            if (B.Top > T.Bottom)
            {
                return false;
            }
            return true;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
            C.Audio.Play(Properties.Resources.未聞花名music, AudioPlayMode.Background);
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    label1.Visible = false;
                    ColorChangeTimer.Start();
                    break;
                case Keys.F:
                    label2.Visible = false;
                    ColorChangeTimer.Start();
                    break;
                case Keys.J:
                    label3.Visible = false;
                    ColorChangeTimer.Start();
                    break;
                case Keys.K:
                    label4.Visible = false;
                    ColorChangeTimer.Start();
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible =true;
            label4.Visible =true;
            ColorChangeTimer.Stop();
        }
        Random R = new Random();

        private void timer2_Tick(object sender, EventArgs e)
        {
            

            foreach (var i in this.Controls)
            {

                if (i is PictureBox)
                {
                    PictureBox ii = (PictureBox)i;
                    
                    if (ii.Tag.ToString() == "T")
                    {
                        ii.Top += 5;
                        if (ii.Top > this.ClientSize.Height)
                        {
                            ii.Top = R.Next(100);
                            ii.Visible = true;
                        }


                    }
                }



            }


        }

        int H;
        private void timer3_Tick(object sender, EventArgs e)
        {
            
            foreach (var i in this.Controls)
            {
                if (i is Label)
                {
                    Label ii = (Label)i;
                    
                        foreach (var j in this.Controls)
                        {
                            if (j is PictureBox)
                            {
                                PictureBox jj = (PictureBox)j;
                                if (jj.Tag.ToString() == "T" && jj.Visible == true)
                                {
                                    if (hit(ii, jj)&&ii.Visible==false)
                                    {
                                         H = H+1;
                                        jj.Visible = false;
                                        
                                        label5.Text = H.ToString();
                                        

                                    }
                                }
                            }
                        }
                       
                    
                }
            }
        }
    }
}

        

