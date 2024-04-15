
using Application.Mapper;
using Application.Services.PostService;
using Domain.Entity;
using Infrastructure.EF;
using Infrastructure.Repositories;
using Infrastructure.Repositories.PostRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MapperDTO));
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IGenericRepository<Post>, GenericRepository<Post>>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
// Đăng ký các repository khác

// Đăng ký UnitOfWork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnectString")));
builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod())
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
