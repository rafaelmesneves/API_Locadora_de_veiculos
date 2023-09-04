using Api.CrossCutting.DependencyInjection;

internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Locadora de Veículos", Version = "v1" });
        });

        ConfigureRepository.ConfigureDependenciesRepository(builder.Services);

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Locadora de Veículos v1"));
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
