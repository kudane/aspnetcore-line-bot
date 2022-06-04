using Microsoft.AspNetCore.Mvc.Razor;

namespace Application.LineLiff
{
    public static class LiffSetting
    {
        public static void AddLiff(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(o =>
            {
                // o.ViewLocationFormats.Clear();
                o.ViewLocationFormats.Add("/Liff/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add("/Liff/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
            });
        }
    }
}
