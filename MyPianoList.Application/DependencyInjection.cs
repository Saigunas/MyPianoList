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
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IPianoSheetTagService, PianoSheetTagService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IStatusService, StatusService>();

            return services;
        }
    }
}
