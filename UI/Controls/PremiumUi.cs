using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AshkanSocial.UI.Theme;
namespace AshkanSocial.UI.Controls{
 public sealed class GradientHeroPanel:Panel{
  public int Radius{get;set;}=28;
  public GradientHeroPanel(){DoubleBuffered=true;Height=150;}
  protected override void OnPaintBackground(PaintEventArgs e){e.Graphics.SmoothingMode=SmoothingMode.AntiAlias;var r=ClientRectangle;if(r.Width<2||r.Height<2)return;using(var path=Round(r,Radius))using(var brush=new LinearGradientBrush(r,ThemeColors.Primary,ThemeColors.Accent,18F))e.Graphics.FillPath(brush,path);}
  GraphicsPath Round(Rectangle r,int rad){int d=rad*2;var p=new GraphicsPath();p.AddArc(r.X,r.Y,d,d,180,90);p.AddArc(r.Right-d,r.Y,d,d,270,90);p.AddArc(r.Right-d,r.Bottom-d,d,d,0,90);p.AddArc(r.X,r.Bottom-d,d,d,90,90);p.CloseFigure();return p;}
 }
 public sealed class AccentCard:ModernPanel{
  public AccentCard(){BackColor=ThemeColors.Surface;BorderRadius=24;BorderColor=ThemeColors.BorderColor;BorderSize=1;HoverEffect=true;Padding=new Padding(18);}
 }
}