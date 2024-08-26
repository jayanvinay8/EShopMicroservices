var builder = WebApplication.CreateBuilder(args);

//Add Services to Container
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});
builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database"));
}).UseLightweightSessions();
var app = builder.Build();

//Configure the HTTP Requrest Pipeline
app.MapCarter();

app.Run();
