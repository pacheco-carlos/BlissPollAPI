using BlissPollAPI.Repository;
using BlissPollAPI.Repository.Interfaces;

namespace BlissPollAPI.Extensions
{
	public static class ServiceExtensions
	{
		const string defaultConnectionString = "DefaultConnection";

		public static void ConfigureCors(this IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy",
					builder => builder.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader());
			});
		}

		public static void ConfigureControllers(this IServiceCollection services)
		{
			services.AddControllers()
				.AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
		}

		public static void ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString(defaultConnectionString)));
		}

		public static void AddRepositories(this IServiceCollection services)
		{
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped<IPollRepository, PollRepository>();
			services.AddScoped<IChoicesRepository, ChoicesRepository>();
		}

		public static void AddServices(this IServiceCollection services)
		{
			services.AddScoped<IEmailService, EmailService>();
		}

		public static void ConfigureHealthChecks(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddHealthChecks().AddSqlServer(configuration.GetConnectionString(defaultConnectionString));
			services.AddHealthChecksUI().AddInMemoryStorage();
		}
	}
}
