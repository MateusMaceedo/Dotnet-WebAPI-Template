using Microsoft.Extensions.DependencyInjection;
using Template_Modelo.Application;
using Template_Modelo.Application.Applications;
using Template_Modelo.Application.Interfaces.Order;
using Template_Modelo.Application.Interfaces.Product;
using Template_Modelo.Application.Interfaces.Security;
using Template_Modelo.Application.Interfaces.User;
using Template_Modelo.Application.Security;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Services;
using Template_Modelo.Infra.Repository.Repositories;

namespace Template_Modelo.CrossCutting.IoC
{
    public static class DependecyContainer
    {
        public static void DependencyInjection(IServiceCollection services)
        {
            // Client
            services.AddScoped<IClientApplication, ClientApplication>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRepository, ClientRepository>();

            // Order
            services.AddScoped<IOrderApplication, OrderApplication>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            // Product
            services.AddScoped<IProductApplication, ProductApplication>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            // User
            services.AddScoped<IUserApplication, UserApplication>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            // Authentication
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped<ITokenManager, TokenManager>();
            services.AddScoped<ITokenManager, TokenManager>();
        }
    }
}
