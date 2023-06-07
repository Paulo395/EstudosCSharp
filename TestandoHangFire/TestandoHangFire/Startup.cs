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
            // Configura��es de middleware e roteamento aqui

            app.UseHangfireDashboard();
            BackgroundJob.Enqueue(() => MensagemSegundoPlano()); // Express�o Lambda
            BackgroundJob.Enqueue(() => MensagemPlano());
            RecurringJob.AddOrUpdate(() => Console.WriteLine("Bom dia"), Cron.Daily); // Est� obsoleto
            BackgroundJob.Schedule(() => MensagemPlano(), TimeSpan.FromDays(7));

            string jobId = BackgroundJob.Enqueue(() => MensagemSegundoPlano());
            BackgroundJob.ContinueJobWith(jobId, () => Console.WriteLine("Job Filha"));
        }

        public void MensagemSegundoPlano()
        {
            Console.WriteLine("Ol� Mundo HangFire!");
        }

        public async Task MensagemPlano()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Ol� Mundo HangFire de novo!");
            });
        }
    }
}
