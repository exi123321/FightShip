using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightShip
{
    public partial class FightShip : Form
    {
        int dx = -1;
        int speedball = 5;
        bool isball = true;
        public FightShip()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Restart();
        }
        void Restart()
        {
            balls.Visible = false;
            boom.Visible = false;
            PirateShip.Visible = true;
            BallTimer.Enabled = false;
            TimerPirateShip.Enabled = true;
            isball = true;
        }
        private void TimerShip_Tick(object sender, EventArgs e)
        {
            PirateShip.Location = new Point(PirateShip.Location.X + dx, PirateShip.Location.Y);
            if (PirateShip.Location.X < 0 || PirateShip.Location.X > Width - PirateShip.Width - 10) { dx = -dx; }
        }

        private void TimerBall_Tick(object sender, EventArgs e)
        {
            balls.Location = new Point(balls.Location.X, balls.Location.Y - speedball);
            if (balls.Bounds.IntersectsWith(PirateShip.Bounds))
            {
                boom.Location = PirateShip.Location;
                PirateShip.Visible = false;
                balls.Visible = false;
                boom.Visible = true;
                BallTimer.Enabled=false;
                TimerPirateShip.Enabled=false;

                if (MessageBox.Show("Хотите сыграть еще раз?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Restart();
                }
                else
                {
                    this.Close();
                }
            }
            if (balls.Location.Y < 0)
            {
                isball = true;
            }

        }

        private void ShipsGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && isball == true)
            {
                balls.Location = new Point(Ship.Location.X + Ship.Width/2 - balls.Width / 2, Ship.Location.Y + Ship.Height / 2 - Ship.Height / 2);
                balls.Visible = true;
                BallTimer.Enabled = true;
                isball = false;
            }
        }
    }
}
