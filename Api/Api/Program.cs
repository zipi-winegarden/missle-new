using Api.Serivce;
using ApiSerivce;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddScoped<MissileService>();
//builder.Services.AddCors(opt => opt.AddPolicy("PolicyName", policy =>
//{
//    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
//}));

Data missileList  = new Data();
builder.Services.AddSingleton(missileList);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
object value = builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
//app.UseCors("PolicyName");
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.Run();
