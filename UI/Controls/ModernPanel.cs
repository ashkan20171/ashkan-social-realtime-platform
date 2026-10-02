using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AshkanSocial.UI.Theme;

namespace AshkanSocial.UI.Controls
{
    public class ModernPanel : Panel
    {
        public int BorderRadius { get; set; }
        public Color BorderColor { get; set; }
        public int BorderSize { get; set; }
        public bool HoverEffect { get; set; }
        private bool hovered;

        public ModernPanel()
        {
            BorderRadius = 14;
            BorderColor = ThemeColors.BorderColor;
            BorderSize = 1;
            DoubleBuffered = true;
            BackColor = ThemeColors.SurfaceDark;
            Padding = new Padding(12); HoverEffect = false;
        }


        protected override void OnMouseEnter(System.EventArgs e){base.OnMouseEnter(e);if(HoverEffect){hovered=true;Invalidate();}}
        protected override void OnMouseLeave(System.EventArgs e){base.OnMouseLeave(e);if(HoverEffect){hovered=false;Invalidate();}}
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            using (SolidBrush bgBrush = new SolidBrush(BackColor))
            using (Pen borderPen = new Pen(hovered && HoverEffect ? ThemeColors.Primary : BorderColor, hovered && HoverEffect ? System.Math.Max(1,BorderSize+1) : BorderSize))
            {
                this.Region = new Region(path);
                e.Graphics.FillPath(bgBrush, path);
                if (BorderSize > 0)
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
