using AllForOneAPI.Controllers;
using AllForOneAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ReverseItAlphaServices>();
builder.Services.AddScoped<ReverseItNumbersServices>();
builder.Services.AddScoped<Add2NumsController>();
builder.Services.AddScoped<AnswerQuestionsServices>();
builder.Services.AddScoped<GreaterLessThanServices>();
builder.Services.AddScoped<MadlibServices>();
builder.Services.AddScoped<ReverseItNumbersServices>();
builder.Services.AddScoped<RestaurantPickerServices>();
builder.Services.AddScoped<MagicEightServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<SayHelloServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
