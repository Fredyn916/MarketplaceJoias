using API.Settings.DI;
using API.Settings.SupaBase;
using Config.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfile));
DependencyInjection.Inject(builder);
SupabaseClient.Inject(builder);
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
}); // Configura��o do CORS

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirTudo"); // Permite requisi��es de qualquer origem (CORS)

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
