
using Scalar.AspNetCore;

namespace HttpClientApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<AppendQueryInUrlHandler>();

            // GetListV2
            //builder.Services.AddHttpClient();

            // GetListV3 - named client
            builder.Services.AddHttpClient("universities", x =>
            {
                x.BaseAddress = new Uri("http://universities.hipolabs.com/");
                //x.DefaultRequestHeaders = new Dictionary<string, string>();
            });


            builder.Services.AddHttpClient("jokes", x =>
            {
                x.BaseAddress = new Uri("https://official-joke-api.appspot.com/");
            });

            // uisng service
            builder.Services.AddHttpClient<JokeService>(x =>
            {
                x.BaseAddress = new Uri("https://official-joke-api.appspot.com/");
            })
                .AddHttpMessageHandler<AppendQueryInUrlHandler>();


            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
