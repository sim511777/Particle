using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<Star> stars = new List<Star>();

        private void AddStar(Point pt, float birthSize, float maxDxRatio) {
            Star star = new Star(pt, rnd, birthSize, maxDxRatio);
            stars.Add(star);
        }

        private void DrawStar(Graphics g, Brush brush, float x, float y, float size) {
            g.FillEllipse(brush, x - size / 2, y - size / 2, size, size);
        }

        private void UpdateFrame(DateTime now, float decreaseRatio, float downSpeed) {
            foreach (var star in this.stars) {
                float dt = (float)(now - star.birthTime).TotalSeconds;

                star.drawSize = star.birthSize * (float)Math.Pow(decreaseRatio, dt);

                float dy = dt * downSpeed;
                float dx = dy * star.dxRatio;
                star.drawPos.X = star.birthPos.X + dx;
                star.drawPos.Y = star.birthPos.Y + dy;
            }
            this.stars = stars.Where(star => star.drawSize >= 2f).ToList();
        }

        private void RenderFrame(Graphics g) {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var star in this.stars) {
                this.DrawStar(g, star.brush, star.drawPos.X, star.drawPos.Y, star.drawSize);
            }
        }

        private void pbxDraw_MouseMove(object sender, MouseEventArgs e) {
            float birthSize = (float)numBirthSize.Value;
            float maxDxRatio = (float)numMaxDxRatio.Value;
            this.AddStar(e.Location, birthSize, maxDxRatio);
        }

        private void pbxDraw_Paint(object sender, PaintEventArgs e) {
            this.RenderFrame(e.Graphics);
        }

        private void tmr17_Tick(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            float decreaseRatio = (float)numDecreaseRatio.Value;
            float downSpeed = (float)numDownSpeed.Value;
            this.UpdateFrame(now, decreaseRatio, downSpeed);
            this.pbxDraw.Refresh();
        }
    }

    public class Star {
        public DateTime birthTime;
        public PointF birthPos;
        public PointF drawPos;
        public float birthSize;
        public float drawSize;
        public float dxRatio;
        public Brush brush;
        public Star(PointF pos, Random rnd, float birthSize, float maxDxRatio) {
            this.birthTime = DateTime.Now;
            this.birthPos = pos;
            this.drawPos = pos;
            this.birthSize = birthSize;
            this.drawSize = birthSize;
            this.dxRatio = (float)(rnd.NextDouble() * maxDxRatio * 2 - maxDxRatio);
            this.brush = new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
        }
        ~Star() {
            this.brush.Dispose();
        }
    }
}
