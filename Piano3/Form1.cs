using Midi;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Piano3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        //Point mPoint;
        int keyX = 0, blackKeyX=45;
        float mouseX, mouseY;
        OutputDevice opd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            opd = OutputDevice.InstalledDevices[0];
            opd.Open();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //mPoint = this.PointToClient(Cursor.Position); // Can get with MouseEventArgs
            stripStatusMouse.Text = "Mouse Position - X : " + e.X + " Y : " + e.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            pen = new Pen(Color.LightGray,2);

            for (int i = 0; i < 10; i++)
            {
                g.DrawRectangle(pen, new Rectangle(keyX, 0, 70, 280));
                g.FillRectangle(Brushes.White, new Rectangle(keyX, 0, 70, 280));
                keyX += 70;
            }

            for (int i = 0; i < 9; i++)
            {
                if (i == 2 || i == 6)
                {
                    g.FillRectangle(Brushes.Transparent, new Rectangle(blackKeyX, 0, 50, 180));
                }
                else
                {
                    g.FillRectangle(Brushes.Black, new Rectangle(blackKeyX, 0, 50, 180));
                }
                blackKeyX += 70;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //mPoint = this.PointToClient(Cursor.Position);
            mouseX = e.X;
            mouseY = e.Y;

            if ((45 < mouseX && 0 < mouseY) && (95 > mouseX && 180 > mouseY)) //C#4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.CSharp4, 127);
            }
            else if ((115 < mouseX && 0 < mouseY) && (165 > mouseX && 180 > mouseY)) //D#4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.DSharp4, 127);
            }
            else if ((255 < mouseX && 0 < mouseY) && (300 > mouseX && 180 > mouseY)) //F#4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.FSharp4, 127);
            }
            else if ((325 < mouseX && 0 < mouseY) && (375 > mouseX && 180 > mouseY)) //G#4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.GSharp4, 127);
            }
            else if ((395 < mouseX && 0 < mouseY) && (445 > mouseX && 180 > mouseY)) //A#4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.ASharp4, 127);
            }
            else if ((535 < mouseX && 0 < mouseY) && (585 > mouseX && 180 > mouseY)) //C#5
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.CSharp5, 127);
            }
            else if ((605 < mouseX && 0 < mouseY) && (655 > mouseX && 180 > mouseY)) //D#5
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.DSharp5, 127);
            }
            else if ((0 < mouseX && 0 < mouseY) && (70 > mouseX && 280 > mouseY)) //C4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.C4, 127);
            }
            else if ((70 < mouseX && 0 < mouseY) && (140 > mouseX && 280 > mouseY)) //D4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.D4, 127);
            }
            else if ((140 < mouseX && 0 < mouseY) && (210 > mouseX && 280 > mouseY)) //E4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.E4, 127);
            }
            else if ((210 < mouseX && 0 < mouseY) && (280 > mouseX && 280 > mouseY)) //F4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.F4, 127);
            }
            else if ((280 < mouseX && 0 < mouseY) && (350 > mouseX && 280 > mouseY)) //G4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.G4, 127);
            }
            else if ((350 < mouseX && 0 < mouseY) && (420 > mouseX && 280 > mouseY)) //A4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.A4, 127);
            }
            else if ((420 < mouseX && 0 < mouseY) && (490 > mouseX && 280 > mouseY)) //B4
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.B4, 127);
            }
            else if ((490 < mouseX && 0 < mouseY) && (560 > mouseX && 280 > mouseY)) //C5
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.C5, 127);
            }
            else if ((560 < mouseX && 0 < mouseY) && (630 > mouseX && 280 > mouseY)) //D5
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.D5, 127);
            }
            else if ((630 < mouseX && 0 < mouseY) && (700 > mouseX && 280 > mouseY)) //E5
            {
                opd.SendNoteOn(Channel.Channel1, Pitch.E5, 127);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            opd.Close();
            Application.Exit();
        }
    }
}
