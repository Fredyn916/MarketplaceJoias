﻿using Supabase;

namespace API.Settings.SupaBase;

public static class SupabaseClient
{
    public static void Inject(WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton(provider =>
        {
            var url = builder.Configuration["Supabase:Url"];
            var key = builder.Configuration["Supabase:Key"];

            var options = new SupabaseOptions
            {
                AutoConnectRealtime = false
            };

            var client = new Supabase.Client(url!, key!, options);
            client.InitializeAsync().Wait();
            return client;
        });
    }
}