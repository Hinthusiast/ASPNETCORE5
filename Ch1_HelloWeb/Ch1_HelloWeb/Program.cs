
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => @"<h2>The time is now:</h2>" + DateTime.UtcNow.ToString());

app.Run();
