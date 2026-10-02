using System;using System.Collections.Generic;using System.Drawing;using System.IO;using System.Windows.Forms;namespace AshkanSocial.Core.Services{
public static class BackgroundService{
 static readonly Dictionary<string,Image> Cache=new Dictionary<string,Image>(StringComparer.OrdinalIgnoreCase);
 public static string Resolve(string page){var p=(page??"").ToLowerInvariant();if(p.Contains("message")||p.Contains("group"))return "social-background.png";if(p.Contains("creator")||p.Contains("admin")||p.Contains("security")||p.Contains("settings")||p.Contains("insight"))return "social-background.png";return "social-background.png";}
 public static void Apply(Control target,string page){if(target==null)return;try{var file=Resolve(page);Image img;if(!Cache.TryGetValue(file,out img)){var path=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Assets",file);if(!File.Exists(path))return;using(var fs=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.ReadWrite))using(var temp=Image.FromStream(fs))img=new Bitmap(temp);Cache[file]=img;}target.BackgroundImage=img;target.BackgroundImageLayout=ImageLayout.Stretch;}catch(Exception ex){AppLogger.Error("Page background failed.",ex);}}
}}
