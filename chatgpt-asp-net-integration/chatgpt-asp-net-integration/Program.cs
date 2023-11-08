using ChatGPT.ASP.NET.Integration.Extensions;

var appName = "ChatGPT ASP.NET 8 Integration";

var builder = WebApplication.CreateBuilder(args);
builder.AddSerilog(builder.Configuration, appName);
builder.AddChatGpt(/*builder.Configuration*/);

// Add services to the container.

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();

builder.Services.AddSwagger(builder.Configuration, appName);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerDoc(appName);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
