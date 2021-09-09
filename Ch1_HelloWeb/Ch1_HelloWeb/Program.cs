
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "<h4>The time is now:</h4>" + DateTime.UtcNow.ToString());

app.Run();
