using Microsoft.Extensions.DependencyInjection;
using src.Api.Domain.Interfaces.Services.User;
using src.Api.Service.Services;

namespace src.Api.CrossCutting.DependencyIntection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
