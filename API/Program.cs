using API.Settings.cloudinary;
using API.Settings.DI;
using API.Settings.MongoAtlas;
using API.Settings.Supabase;
using Config.AutoMapper;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

MongoDbConfiguration.Configure();
CloudinaryConfiguration.Configure(builder);
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
}); // Configuração do CORS

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirTudo"); // Permite requisições de qualquer origem (CORS)

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();