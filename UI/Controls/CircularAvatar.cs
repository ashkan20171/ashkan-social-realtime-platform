using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AshkanSocial.UI.Theme;

namespace AshkanSocial.UI.Controls
{
    public class CircularAvatar : PictureBox
    {
        public bool IsOnline { get; set; }
        public int BorderThickness { get; set; }
        public Color AvatarBorderColor { get; set; }
        // Compatibility aliases used by the premium UI layer.
        public Color BorderColor { get { return AvatarBorderColor; } set { AvatarBorderColor = value; Invalidate(); } }
        public int BorderSize { get { return BorderThickness; } set { BorderThickness = value; Invalidate(); } }

        public CircularAvatar()
        {
            IsOnline = true;
            BorderThickness = 2;
            AvatarBorderColor = ThemeColors.Primary;
            SizeMode = PictureBoxSizeMode.Zoom;
            Size = new Size(48, 48);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(BorderThickness, BorderThickness, Width - (BorderThickness * 2) - 1, Height - (BorderThickness * 2) - 1);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);

                base.OnPaint(pe);

                using (Pen pen = new Pen(AvatarBorderColor, BorderThickness))
                {
                    pe.Graphics.DrawEllipse(pen, rect);
                }

                if (IsOnline)
                {
                    int dotSize = 12;
                    Rectangle dotRect = new Rectangle(Width - dotSize - 3, Height - dotSize - 3, dotSize, dotSize);
                    using (SolidBrush dotBrush = new SolidBrush(ThemeColors.OnlineGreen))
                    using (Pen dotBorder = new Pen(ThemeColors.SurfaceDark, 2))
                    {
                        pe.Graphics.FillEllipse(dotBrush, dotRect);
                        pe.Graphics.DrawEllipse(dotBorder, dotRect);
                    }
                }
            }
        }
    }
}
