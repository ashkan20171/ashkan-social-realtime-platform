using System;
using System.Drawing;
using System.Windows.Forms;
using AshkanSocial.UI.Theme;

namespace AshkanSocial.UI.Controls
{
    public sealed class ToastPanel : Panel
    {
        private readonly Timer timer = new Timer();
        public ToastPanel()
        {
            Height=64; Width=340; BackColor=ThemeColors.Surface;
            Padding=new Padding(18); Visible=false; BorderStyle=BorderStyle.FixedSingle;
            timer.Interval=2600; timer.Tick+=(s,e)=>{timer.Stop();Visible=false;};
        }
        public void ShowMessage(Control host,string message)
        {
            Controls.Clear();
            Controls.Add(new Label{Dock=DockStyle.Fill,Text=message,ForeColor=ThemeColors.TextPrimary,
                TextAlign=ContentAlignment.MiddleLeft,Font=new Font("Segoe UI Semibold",9F)});
            if(Parent==null) host.Controls.Add(this);
            Left=Math.Max(12,host.ClientSize.Width-Width-24); Top=24; Anchor=AnchorStyles.Top|AnchorStyles.Right;
            BringToFront(); Visible=true; timer.Stop(); timer.Start();
        }
        protected override void Dispose(bool disposing){if(disposing)timer.Dispose();base.Dispose(disposing);}
    }
}
