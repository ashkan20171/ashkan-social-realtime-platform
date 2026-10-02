using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AshkanSocial.UI.Controls
{
    public class AshkanLogo : Control
    {
        public AshkanLogo()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(112, 92);
            BackColor = Color.Transparent;
            TabStop = false;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (BackColor == Color.Transparent && Parent != null)
            {
                using (var brush = new SolidBrush(Parent.BackColor))
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                return;
            }
            base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var r = ClientRectangle;
            if (r.Width < 10 || r.Height < 10) return;

            var cx = r.Width / 2f;
            var top = 8f;
            var bottom = r.Height - 10f;
            var left = 16f;
            var right = r.Width - 16f;

            using (var path = new GraphicsPath())
            {
                path.AddPolygon(new[] {
                    new PointF(cx, top),
                    new PointF(right, bottom),
                    new PointF(right-23, bottom),
                    new PointF(cx, top+35),
                    new PointF(left+23, bottom),
                    new PointF(left, bottom)
                });
                using (var brush = new LinearGradientBrush(
                    new RectangleF(left, top, right-left, bottom-top),
                    Color.FromArgb(70, 105, 255),
                    Color.FromArgb(139, 76, 255),
                    55f))
                    g.FillPath(brush, path);
            }

            // Negative-space style crossbar / social connection spark
            using (var pen = new Pen(Color.FromArgb(210, 224, 255), 5f))
            {
                pen.StartCap = LineCap.Round; pen.EndCap = LineCap.Round;
                g.DrawLine(pen, cx-14, bottom-25, cx+15, bottom-25);
            }
            using (var glow = new SolidBrush(Color.FromArgb(80, 215, 255)))
                g.FillEllipse(glow, right-13, 10, 8, 8);
        }
    }
}
