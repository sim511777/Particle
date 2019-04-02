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
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<Star> stars = new List<Star>();

        private void AddStar(Point pt)
        {
            Star star = new Star(pt, rnd);
            stars.Add(star);
        }

        private void DrawStar(Graphics g, Brush brush, float x, float y, float size)
        {
            g.FillEllipse(brush, x - size / 2, y - size / 2, size, size);
        }

        private void UpdateFrame(DateTime now)
        {
            this.stars = stars.Where(star => 10 * Math.Pow(0.1, (now - star.birthTime).TotalSeconds) >= 1f).ToList();
        }

        private void RenderFrame(Graphics g, DateTime now)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var star in this.stars)
            {
                float dt = (float)(now - star.birthTime).TotalSeconds;
                float x = star.pos.X + dt * 200 * star.dxRatio;
                float y = star.pos.Y + dt * 200;
                float size = 10 * (float)Math.Pow(0.1, dt);
                this.DrawStar(g, star.brush, x, y, size);
            }
        }

        private void pbxDraw_MouseMove(object sender, MouseEventArgs e)
        {
            this.AddStar(e.Location);
        }

        private void pbxDraw_Paint(object sender, PaintEventArgs e)
        {
            DateTime now = DateTime.Now;
            this.RenderFrame(e.Graphics, now);
        }

        private void tmr17_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.UpdateFrame(now);
            this.pbxDraw.Refresh();
        }
    }

    public class Star {
        public PointF pos;
        public DateTime birthTime;
        public float dxRatio;
        public Brush brush;
        public Star(PointF pos, Random rnd)
        {
            this.pos = pos;
            this.birthTime = DateTime.Now;
            this.dxRatio = (float)(rnd.NextDouble() * 1 - 0.5);
            this.brush = new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
        }
        ~Star()
        {
            this.brush.Dispose();
        }
    }
}
