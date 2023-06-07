using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Hangfire;
using Hangfire.MemoryStorage;
using System.Threading.Tasks;
using System;

namespace TestandoHangFire
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHangfire(op =>
            {
                op.UseMemoryStorage();
            });
            services.AddHangfireServer();
        }

        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configurações de middleware e roteamento aqui

            app.UseHangfireDashboard();
            BackgroundJob.Enqueue(() => MensagemSegundoPlano()); // Expressão Lambda
            BackgroundJob.Enqueue(() => MensagemPlano());
            RecurringJob.AddOrUpdate(() => Console.WriteLine("Bom dia"), Cron.Daily); // Está obsoleto
            BackgroundJob.Schedule(() => MensagemPlano(), TimeSpan.FromDays(7));

            string jobId = BackgroundJob.Enqueue(() => MensagemSegundoPlano());
            BackgroundJob.ContinueJobWith(jobId, () => Console.WriteLine("Job Filha"));
        }

        public void MensagemSegundoPlano()
        {
            Console.WriteLine("Olá Mundo HangFire!");
        }

        public async Task MensagemPlano()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Olá Mundo HangFire de novo!");
            });
        }
    }
}
