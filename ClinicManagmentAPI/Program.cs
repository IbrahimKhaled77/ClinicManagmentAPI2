
using ClinicManagmentAPI.Interface;
using ClinicManagmentAPI_Repos.Implementations;
using ClinicManagmentAPI_Repos.Interface;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;
using ClinicManagmentAPI.Interface;
using ClinicManagementAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ClinicManagementDbContext>(con =>
con.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnectlocal")));
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Accounting Management",
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string loggerPath = configuration.GetSection("Logger").Value;
//use the above line to store file path in appsetings

Serilog.Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).
                WriteTo.File(loggerPath, rollingInterval: RollingInterval.Day).
                CreateLogger();

builder.Services.AddScoped<IApointmentService, ApointmentService>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();
builder.Services.AddScoped<IMedicalProcedureService, MedicalProcedureService>();
builder.Services.AddScoped<IMedicalReportAttachmentService , MedicalReportAttachmentService>();
builder.Services.AddScoped <IMedicalReportLaborityTestService, MedicalReportLaborityTestService>();
builder.Services.AddScoped<IMedicalReportService, MedicalReportService>();
builder.Services.AddScoped<IMedicienRecordService, MedicienRecordService>();
builder.Services.AddScoped<IMedicienService, MedicienService>();
builder.Services.AddScoped<IProudureTitleService, ProudureTitleService>();
builder.Services.AddScoped<ISickLeaveService, SickLeaveService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

try
{
    Log.Information("Clinic Management System API Has been Launched Successfully");
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
        // Set the default URL
        c.RoutePrefix = ""; // This makes Swagger UI the default route
    });
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();


}
catch (Exception ex)
{
    Log.Error("Something Went Wrong On Starting Application");
    Log.Error($"Error: {ex}");
}

