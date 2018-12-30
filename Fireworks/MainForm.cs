using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireworks {

    public partial class MainForm : Form {

        private Firework[] Races = new Firework[40];

        public MainForm() {
            InitializeComponent();
        }

        private Firework GetNewRace() {
            return new Firework(
                /* initial X, Y        */ 0, 0,
                /* fuse time min, max  */ 2.0f, 6.0f,
                /* initial vel. range  */ -60.0f, 60.0f, 60.0f, 120.0f,
                /* fragment vel. range */ -30.0f, 30.0f, -30.0f, 30.0f,
                /* fragment br. range  */ 0.8f, 1.0f,
                /* fragments count     */ 20, 50,
                /* fragment burn rate  */ 0.2f, 0.4f);
        }

        private void MainForm_Load(object sender, EventArgs e) {

            for (int k = 0; k < Races.Length; k++) {
                Races[k] = GetNewRace();
            }

            MainTimer.Start();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e) {
            Graphics gr = e.Graphics;
            RectangleF vcb = gr.VisibleClipBounds;

            foreach (Firework race in Races) {

                if (race != null) {
                    race.Paint(gr, vcb.Width / 2, vcb.Height - 20, 0.1f);
                }

            }

        }

        private void MainTimer_Tick(object sender, EventArgs e) {

            for (int k = 0; k < Races.Length; k++) {

                if (!Races[k].Forward(0.001f * (float)MainTimer.Interval)) {
                    Races[k] = GetNewRace();
                }

            }

            Invalidate();
        }
    }

}
