using CloudinaryDotNet;
using Microsoft.Extensions.Options;

namespace API.Settings.cloudinary;

public static class CloudinaryConfiguration
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("Cloudinary"));

        builder.Services.AddSingleton(sp =>
        {
            var config = sp.GetRequiredService<IOptions<CloudinarySettings>>().Value;
            var acc = new Account(config.CloudName, config.ApiKey, config.ApiSecret);
            return new Cloudinary(acc);
        });
    }
}