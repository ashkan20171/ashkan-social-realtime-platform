using System.Drawing;
namespace AshkanSocial.UI.Theme
{
    public static class ThemeColors
    {
        public static bool LightMode { get; set; } = false;
        public static Color Background { get { return LightMode ? ColorTranslator.FromHtml("#F3F7FB") : ColorTranslator.FromHtml("#101820"); } }
        public static Color Surface { get { return LightMode ? Color.White : ColorTranslator.FromHtml("#13243B"); } }
        public static Color BackgroundDark { get { return Background; } }
        public static Color SurfaceDark { get { return Surface; } }
        public static Color SurfaceHover { get { return LightMode ? ColorTranslator.FromHtml("#EDF5FC") : ColorTranslator.FromHtml("#1D3150"); } }
        public static Color BorderColor { get { return LightMode ? ColorTranslator.FromHtml("#DCE7F0") : ColorTranslator.FromHtml("#35506F"); } }
        public static readonly Color Primary=ColorTranslator.FromHtml("#3390EC"); public static readonly Color PrimaryHover=ColorTranslator.FromHtml("#2783D9");
        public static readonly Color Accent=ColorTranslator.FromHtml("#22D3EE"); public static readonly Color Warm=ColorTranslator.FromHtml("#F59E0B");
        public static readonly Color Secondary=ColorTranslator.FromHtml("#25D366"); public static readonly Color OnlineGreen=ColorTranslator.FromHtml("#10B981"); public static readonly Color AlertRed=ColorTranslator.FromHtml("#EF4444");
        public static Color TextPrimary { get { return LightMode ? ColorTranslator.FromHtml("#101820") : ColorTranslator.FromHtml("#F3F7FB"); } }
        public static Color TextSecondary { get { return LightMode ? ColorTranslator.FromHtml("#475569") : ColorTranslator.FromHtml("#94A3B8"); } }
        public static Color TextMuted { get { return LightMode ? ColorTranslator.FromHtml("#64748B") : ColorTranslator.FromHtml("#AFC4DA"); } }
    }
}