using System.Web;
using System.Web.Optimization;

namespace OlgadoUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
           

            bundles.Add(new StyleBundle("~/materialize/css").IncludeDirectory("~/Content/materialize", "*.css", true));

            bundles.Add(new StyleBundle("~/olgado/css").IncludeDirectory("~/Content/olgado", "*.css", true));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").IncludeDirectory("~/Scripts/materialize", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/olgado").IncludeDirectory("~/Scripts/olgado", "*.js", true));
        }
    }
}
