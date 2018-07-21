using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iamonline.Context;
using Iamonline.Context.Seed.Seed;
using Iamonline.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Iamonline
{
	public class Startup
	{
		private readonly IConfiguration _config;

		public Startup(IConfiguration config)
		{
			_config = config;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<IamonlineContext>(cfg =>
				{
					cfg.UseSqlServer(_config.GetConnectionString("IamonlineContext"), b => b.MigrationsAssembly("DataAccess"));
				});

			services.AddTransient<IamonlineSeeder>();
			services.AddScoped<IIamonlineRepository, IamonlineRepository>();



			services.AddMvc()
				.AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(options =>
			{
				options.Authority = _config["Auth0:Authority"];
				options.Audience = _config["Auth0:Audience"];
				options.RequireHttpsMetadata = false;
			});


		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/error");
			}

			app.UseAuthentication();
			app.UseStaticFiles();

			app.UseMvc(cfg =>
			{
				cfg.MapRoute("Default",
							"{controller}/{action}/{id?}",
							new { controller = "App", Action = "Index" });
			});

			//Seed The database
			using (var scope = app.ApplicationServices.CreateScope())
			{
				var seeder = scope.ServiceProvider.GetService<IamonlineSeeder>();

				seeder.SeedPersistedData();
				if (env.IsDevelopment()) seeder.SeedDummyData();
			}


		}
	}
}
