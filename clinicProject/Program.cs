using clinicProject;
using clinicProject.core;
using clinicProject.core.Repositories;
using clinicProject.core.Servises;
using clinicProject.data.Repositories;
using clinicProject.service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IdoctorServise,DoctorServise>();
builder.Services.AddScoped<Idoctor,DoctorRepository>();
builder.Services.AddScoped<IpatientSrevise,PatientServise>();
builder.Services.AddScoped<Ipatient, PatientRepository>();
builder.Services.AddScoped<IroutesSrevise,RoutesServise>();
builder.Services.AddScoped<Iroutes, RouteRepository>();
//����� �� ����� ������
builder.Services.AddAutoMapper(typeof(MappingProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(policy);
app.MapControllers();

app.Run();
