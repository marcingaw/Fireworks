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
            ////////////////////
            // The golden stars
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MaxColorB = 0.5f,
                MinFragmentV = 25.0f, MaxFragmentV = 30.0f,
                MinVx = -1.0f, MaxVx = 1.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MaxColorB = 0.5f,
                MinFragmentV = 25.0f, MaxFragmentV = 30.0f,
                MinVx = -1.0f, MaxVx = 1.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            ///////////////////////
            // The blue background
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -6.0f, MaxVx = -4.0f, MinVy = 119.0f, MaxVy = 121.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -16.0f, MaxVx = -14.0f, MinVy = 119.0f, MaxVy = 121.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -26.0f, MaxVx = -24.0f, MinVy = 119.0f, MaxVy = 121.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 4.0f, MaxVx = 6.0f, MinVy = 119.0f, MaxVy = 121.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 14.0f, MaxVx = 16.0f, MinVy = 119.0f, MaxVy = 121.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 24.0f, MaxVx = 26.0f, MinVy = 119.0f, MaxVy = 121.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -6.0f, MaxVx = -4.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -16.0f, MaxVx = -14.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -26.0f, MaxVx = -24.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 4.0f, MaxVx = 6.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 14.0f, MaxVx = 16.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 24.0f, MaxVx = 26.0f, MinVy = 109.0f, MaxVy = 111.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -6.0f, MaxVx = -4.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -16.0f, MaxVx = -14.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = -26.0f, MaxVx = -24.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 4.0f, MaxVx = 6.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 14.0f, MaxVx = 16.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 1.9f, MaxFuseTime = 2.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MaxColorR = 0.5f, MaxColorG = 0.5f, MinColorB = 1.0f,
                MinVx = 24.0f, MaxVx = 26.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            ////////////////////
            // The white stripe
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -21.0f, MaxVx = -19.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -11.0f, MaxVx = -9.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -1.0f, MaxVx = 1.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 9.0f, MaxVx = 11.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 19.0f, MaxVx = 21.0f, MinVy = 99.0f, MaxVy = 101.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -21.0f, MaxVx = -19.0f, MinVy = 89.0f, MaxVy = 91.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -11.0f, MaxVx = -9.0f, MinVy = 89.0f, MaxVy = 91.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = -1.0f, MaxVx = 1.0f, MinVy = 89.0f, MaxVy = 91.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 9.0f, MaxVx = 11.0f, MinVy = 89.0f, MaxVy = 91.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 1.0f, MinColorB = 1.0f,
                MinVx = 19.0f, MaxVx = 21.0f, MinVy = 89.0f, MaxVy = 91.0f
            }),
            //////////////////
            // The red stripe
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -21.0f, MaxVx = -19.0f, MinVy = 79.0f, MaxVy = 81.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -11.0f, MaxVx = -9.0f, MinVy = 79.0f, MaxVy = 81.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -1.0f, MaxVx = 1.0f, MinVy = 79.0f, MaxVy = 81.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 9.0f, MaxVx = 11.0f, MinVy = 79.0f, MaxVy = 81.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 19.0f, MaxVx = 21.0f, MinVy = 79.0f, MaxVy = 81.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -21.0f, MaxVx = -19.0f, MinVy = 69.0f, MaxVy = 71.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -11.0f, MaxVx = -9.0f, MinVy = 69.0f, MaxVy = 71.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = -1.0f, MaxVx = 1.0f, MinVy = 69.0f, MaxVy = 71.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 9.0f, MaxVx = 11.0f, MinVy = 69.0f, MaxVy = 71.0f
            }),
            new Firework(new Firework.Config() {
                MinFuseTime = 3.9f, MaxFuseTime = 4.1f, MinBrightness = 0.9f, MaxBrightness = 1.0f,
                MinColorR = 1.0f, MinColorG = 0.3f, MaxColorG = 0.3f, MinColorB = 0.3f, MaxColorB = 0.3f,
                MinVx = 19.0f, MaxVx = 21.0f, MinVy = 69.0f, MaxVy = 71.0f
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
