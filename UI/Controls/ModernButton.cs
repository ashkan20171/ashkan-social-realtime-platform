using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AshkanSocial.UI.Theme;

namespace AshkanSocial.UI.Controls
{
    public class ModernButton : Button
    {
        private int _borderRadius = 12;
        private bool _isHovered = false;
        private bool _isPressed = false;
        private Color _customHoverColor = ThemeColors.PrimaryHover;

        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; Invalidate(); }
        }

        public Color CustomHoverColor
        {
            get { return _customHoverColor; }
            set { _customHoverColor = value; Invalidate(); }
        }

        public ModernButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(130, 40);
            BackColor = ThemeColors.Primary;
            ForeColor = ThemeColors.TextPrimary;
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e); _isHovered = false; _isPressed = false; Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e); if(e.Button==MouseButtons.Left){_isPressed=true;Invalidate();}
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e); _isPressed=false; Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color currentBg = _isPressed ? ControlPaint.Dark(_customHoverColor,0.08f) : (_isHovered ? _customHoverColor : BackColor);

            using (GraphicsPath path = GetRoundedPath(ClientRectangle, _borderRadius))
            using (SolidBrush brush = new SolidBrush(currentBg))
            {
                this.Region = new Region(path);
                pevent.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(
                pevent.Graphics,
                Text,
                Font,
                ClientRectangle,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
