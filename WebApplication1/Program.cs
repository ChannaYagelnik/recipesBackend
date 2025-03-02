using BLLL.func_blll;
using BLLL.interfaces;
using DAL.func;
using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Recepis_chaniWContext>(y => y.UseSqlServer("Server=kitotSrv\\sql;Database=Recepis_chaniW;Trusted_Connection=True;TrustServerCertificate=True;"));


builder.Services.AddScoped<Iingredientc_bll,ingredientce_bll>();
builder.Services.AddScoped<Iingredientcrecepie_bll,ingredientcrecepiy_bll>();
builder.Services.AddScoped<Irecepie_bll,recepies_bll>();
builder.Services.AddScoped<Iuser_bll,user_bll>();


builder.Services.AddScoped<Iingriduentce,ingredients_dal>();
builder.Services.AddScoped<IRecpey,recpey_dal>();
builder.Services.AddScoped<IngrientRecepies,recpeyingredients_dal>();
builder.Services.AddScoped<IUser,usr_dal>();
 
builder.Services.AddCors(o => o.AddPolicy("All",
            y => y.AllowAnyOrigin()//כל מקור
            .AllowAnyMethod()//כל פונקציה
            .AllowAnyHeader()));//כל כותרת


var app = builder.Build();
app.UseCors("All");
app.UseStaticFiles();
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
