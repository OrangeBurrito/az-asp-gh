var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

app.MapGet("/", (ILogger logger) => {
    logger.LogInformation("hello world has hit the endpoint!");
    return "Hello World";
});

app.MapGet("/html", () => {
    return Results.Content("<h1>Hello World</h1><p>lorem ipsum dolor sit amet adipiscing elit! 💀🕱</p>", "text/html");
});

app.MapGet("/random", () => {
    Random random = new Random();
    return random.Next(0, 100).ToString();
});

app.Run();