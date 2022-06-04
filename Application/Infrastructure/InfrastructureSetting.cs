using Application.Infrastructure.Jwt;
using Application.Infrastructure.Jwt.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Application.Infrastructure
{
    public static class InfrastructureSetting
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                    options.SlidingExpiration = true;
                    options.AccessDeniedPath = "/Login/Index";
                });


            //var jwtConfiguration = new JwtConfiguration();
            //configuration.GetSection("JwtSettings").Bind(jwtConfiguration);

            //services.AddAuthentication(config =>
            //{
            //    config.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(config =>
            //{
            //    config.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfiguration.SecretKey)),
            //        ValidateLifetime = true,
            //        ValidateIssuer = false,
            //        ValidateAudience = false,
            //        ClockSkew = TimeSpan.Zero
            //    };
            //});

            //services
            //    .AddSingleton<IJwtConfiguration>(jwtConfiguration)      
            //    .AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        }
    }
}