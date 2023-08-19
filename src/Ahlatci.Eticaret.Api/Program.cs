using Ahlatci.Eticaret.Api.Filters;
using Ahlatci.Eticaret.Application.Automappings;
using Ahlatci.Eticaret.Application.Repositories;
using Ahlatci.Eticaret.Application.Services.Abstraction;
using Ahlatci.Eticaret.Application.Services.Implementation;
using Ahlatci.Eticaret.Application.Validators.Categories;
using Ahlatci.Eticaret.Domain.Services.Abstraction;
using Ahlatci.Eticaret.Domain.Services.Implementation;
using Ahlatci.Eticaret.Domain.UWork;
using Ahlatci.Eticaret.Persistence.Context;
using Ahlatci.Eticaret.Persistence.Repositories;
using Ahlatci.Eticaret.Persistence.UWork;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//Logging
var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(configuration)
        .CreateLogger();

//En düþük seviye.
Log.Logger.Information("Program Started..."); 

// Add services to the container.

//ActionFilter registiration
builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new ExceptionHandlerFilter());
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "JwtTokenWithIdentity", Version = "v1", Description = "JwtTokenWithIdentity test app" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}
                    }
                });
});

builder.Services.AddHttpContextAccessor();

//DbContext Registiration
builder.Services.AddDbContext<AhlatciContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("AhlatciShop"));
});

//Repository Registiraction //Generic.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//UnitOfWork Registiration 
builder.Services.AddScoped<IUnitWork, UnitWork>();

//Business Service Registiration //Generic olmayan interface sýnýflarý için.
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ILoggedUserService, LoggedUserService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductImageService, ProductImageService>();

//Automapper //Mapping sýnýflarýnýn type'larý eklendi.
builder.Services.AddAutoMapper(typeof(DomainToDto), typeof(ViewModelToDomain));

//FluentValidation Ýstekte gönderilen modele ait property'lerin istenen formatý destekleyip desteklemediðini anlamamýzý saðlar.
builder.Services.AddValidatorsFromAssemblyContaining(typeof(CreateCategoryValidator));


// JWT kimlik doðrulama servisini ekleme
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.IncludeErrorDetails = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"], // Tokený oluþturan tarafýn adresi
            ValidAudience = builder.Configuration["Jwt:Audiance"], // Tokenýn kullanýlacaðý hedef adres
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SigningKey"])) // Gizli anahtar
        };
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

//Kalýcý olarak saklanacak dosyalar için kayýt yeri ayarlanýyor.
app.UseStaticFiles();

app.Run();
