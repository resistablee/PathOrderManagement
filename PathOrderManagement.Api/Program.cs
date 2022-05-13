using Autofac;
using Autofac.Extensions.DependencyInjection;
using PathOrderManagement.Api.Configurations.Startup;
using PathOrderManagement.Container.Modules;
using PathOrderManagement.Contract.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//ServiceModule ve RepositoryModule class'ları içerisindeki tüm servis ve repositoryleri lifetime boyunca scope ediyor.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).
    ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new ServiceModule());
        builder.RegisterModule(new RepositoryModule());
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Custom Service Configurations
builder.Services.AddDatabaseContext(builder.Configuration);
builder.Services.AddIdentityConfigurations(builder.Configuration);
builder.Services.AddCorsConfigurations();
builder.Services.AddApiVersioningConfigurations();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddAutoMapper(typeof(UserMapping));
#endregion

var app = builder.Build();

#region Custom Application Configurations
app.UseCorsConfiguration();
app.UseApiVersioningConfiguration();
#endregion

app.UseRouting();

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

app.Run();
