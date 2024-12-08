using Microsoft.Extensions.DependencyInjection;
using MyPianoList.Application.Interfaces;
using MyPianoList.Application.Services;

namespace MyPianoList.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<IPianoSheetService, PianoSheetService>();

            return services;
        }
    }
}
