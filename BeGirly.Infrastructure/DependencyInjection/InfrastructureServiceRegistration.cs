namespace BeGirly.Infrastructure.DependencyInjection
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration
            )
        {
            var connectionString = configuration.GetConnectionString("BeGirlyDb");
            
            services.AddDbContext<BeGirlyDbContext>(options=>
              options.UseSqlServer(connectionString)
            );

            return services;
        }
    }
}
