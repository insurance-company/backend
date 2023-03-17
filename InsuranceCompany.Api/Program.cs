using InsuranceCompany.Api.Profiles;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Core.Repository;
using InsuranceCompany.Library.Core.Service;
using InsuranceCompany.Library.Core.Service.Core;
using InsuranceCompany.Library.Settings;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using InsuranceCompany.Library.Helpers.Interfaces;
using InsuranceCompany.Library.Helpers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAidPackageService, AidPackageService>();
builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<IAccidentService, AccidentService>();
builder.Services.AddScoped<IPolicyService, PolicyService>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IStatisticsService, StatisticsService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IPDFExporterService, PDFExporterService>();
builder.Services.AddScoped<ITowTruckService, TowTruckService>();

builder.Services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme).AddCertificate();

builder.Services.AddControllers();
builder.Services.AddDbContext<InsuranceCompanyDbContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("InsuranceCompanyDb")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(CarMapperProfile));
builder.Services.AddCors(o =>
{
    o.AddPolicy("Policy", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("veryverysecret.....")),
        ValidateAudience = false,
        ValidateIssuer = false
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
app.UseCors("Policy");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
