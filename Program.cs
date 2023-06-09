var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello 🅱️orld");

app.MapGet("/html", () => {
    return Results.Content("<h1>Hello 🅱️orld</h1><p>lorem ipsum dolor sit amet adipiscing elit! 💀🕱</p>", "text/html");
});

app.MapGet("/random", () => {
    Random random = new Random();
    return random.Next(0, 100).ToString();
});

app.Run();