using AshkanSocial.RealtimeServer.Hubs;
var builder=WebApplication.CreateBuilder(args);
builder.Services.AddSignalR(o=>{o.EnableDetailedErrors=builder.Environment.IsDevelopment();o.MaximumReceiveMessageSize=1024*1024;});
builder.Services.AddCors(o=>o.AddDefaultPolicy(p=>p.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(_=>true).AllowCredentials()));
var app=builder.Build();app.UseCors();
app.MapGet("/",()=>Results.Ok(new {service="Ashkan Social Realtime",status="online",utc=DateTime.UtcNow}));
app.MapGet("/health",()=>Results.Ok(new {status="healthy",service="signalr",utc=DateTime.UtcNow}));
app.MapHub<SocialHub>("/hubs/social");app.Run();
