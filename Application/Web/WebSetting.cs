using Microsoft.AspNetCore.Mvc.Razor;

namespace Application.Web
{
    public static class WebSetting
    {
        public static void AddWeb(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(o =>
            {
                // o.ViewLocationFormats.Clear();
                o.ViewLocationFormats.Add("/Web/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add("/Web/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
            });
        }
    }
}
