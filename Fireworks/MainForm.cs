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

        private Firework[] Races = new Firework[40] {
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MaxColorB = 0.5f,
                MinVx = 0.0f, MaxVx = 0.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MaxColorB = 0.5f,
                MinVx = 0.0f, MaxVx = 0.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -5.0f, MaxVx = -5.0f, MinVy = 120.0f, MaxVy = 120.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -15.0f, MaxVx = -15.0f, MinVy = 120.0f, MaxVy = 120.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -25.0f, MaxVx = -25.0f, MinVy = 120.0f, MaxVy = 120.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 5.0f, MaxVx = 5.0f, MinVy = 120.0f, MaxVy = 120.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 15.0f, MaxVx = 15.0f, MinVy = 120.0f, MaxVy = 120.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 25.0f, MaxVx = 25.0f, MinVy = 120.0f, MaxVy = 120.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -5.0f, MaxVx = -5.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -15.0f, MaxVx = -15.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -25.0f, MaxVx = -25.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 5.0f, MaxVx = 5.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 15.0f, MaxVx = 15.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 25.0f, MaxVx = 25.0f, MinVy = 110.0f, MaxVy = 110.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -5.0f, MaxVx = -5.0f, MinVy = 100.0f, MaxVy = 100.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -15.0f, MaxVx = -15.0f, MinVy = 100.0f, MaxVy = 100.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -25.0f, MaxVx = -25.0f, MinVy = 100.0f, MaxVy = 100.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 5.0f, MaxVx = 5.0f, MinVy = 100.0f, MaxVy = 100.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 15.0f, MaxVx = 15.0f, MinVy = 100.0f, MaxVy = 100.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 2.0f, MaxFuseTime = 2.0f, MinBrightness = 0.5f, MaxBrightness = 0.5f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 25.0f, MaxVx = 25.0f, MinVy = 100.0f, MaxVy = 100.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -20.0f, MaxVx = -20.0f, MinVy = 90.0f, MaxVy = 90.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -10.0f, MaxVx = -10.0f, MinVy = 90.0f, MaxVy = 90.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 0.0f, MaxVx = 0.0f, MinVy = 90.0f, MaxVy = 90.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 10.0f, MaxVx = 10.0f, MinVy = 90.0f, MaxVy = 90.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 20.0f, MaxVx = 20.0f, MinVy = 90.0f, MaxVy = 90.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -20.0f, MaxVx = -20.0f, MinVy = 80.0f, MaxVy = 80.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -10.0f, MaxVx = -10.0f, MinVy = 80.0f, MaxVy = 80.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 0.0f, MaxVx = 0.0f, MinVy = 80.0f, MaxVy = 80.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 10.0f, MaxVx = 10.0f, MinVy = 80.0f, MaxVy = 80.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 20.0f, MaxVx = 20.0f, MinVy = 80.0f, MaxVy = 80.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -20.0f, MaxVx = -20.0f, MinVy = 70.0f, MaxVy = 70.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -10.0f, MaxVx = -10.0f, MinVy = 70.0f, MaxVy = 70.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 0.0f, MaxVx = 0.0f, MinVy = 70.0f, MaxVy = 70.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 10.0f, MaxVx = 10.0f, MinVy = 70.0f, MaxVy = 70.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 20.0f, MaxVx = 20.0f, MinVy = 70.0f, MaxVy = 70.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -20.0f, MaxVx = -20.0f, MinVy = 60.0f, MaxVy = 60.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -10.0f, MaxVx = -10.0f, MinVy = 60.0f, MaxVy = 60.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 0.0f, MaxVx = 0.0f, MinVy = 60.0f, MaxVy = 60.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 10.0f, MaxVx = 10.0f, MinVy = 60.0f, MaxVy = 60.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 5.0f, MaxFuseTime = 5.0f, MinBrightness = 1.0f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 20.0f, MaxVx = 20.0f, MinVy = 60.0f, MaxVy = 60.0f
            })
        };

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            MainTimer.Start();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e) {
            Graphics gr = e.Graphics;
            RectangleF vcb = gr.VisibleClipBounds;

            foreach (Firework race in Races) {

                if (race != null) {
                    race.Paint(gr, vcb.Width / 2, vcb.Height - 20,
                               0.001f * (float)MainTimer.Interval);
                }

            }

        }

        private void MainTimer_Tick(object sender, EventArgs e) {

            for (int k = 0; k < Races.Length; k++) {

                if (!Races[k].Forward(0.001f * (float)MainTimer.Interval)) {
                    Races[k] = new Firework(new Firework.Config());
                }

            }

            Invalidate();
        }
    }

}
