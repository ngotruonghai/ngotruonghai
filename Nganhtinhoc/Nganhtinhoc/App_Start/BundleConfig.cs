using System.Web;
using System.Web.Optimization;

namespace Nganhtinhoc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/template/newsfeed/assets/js/jquery.min.js",
                        "~/Content/template/newsfeed/assets/js/wow.min.js",
                        "~/Content/template/newsfeed/assets/js/bootstrap.min.js",
                        "~/Content/template/newsfeed/assets/js/slick.min.js",
                        "~/Content/template/newsfeed/assets/js/jquery.li-scroller.1.0.js",
                        "~/Content/template/newsfeed/assets/js/jquery.newsTicker.min.js",
                        "~/Content/template/newsfeed/assets/js/jquery.fancybox.pack.js",
                        "~/Content/template/newsfeed/assets/js/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/template/newsfeed/assets/css/bootstrap.min.css",
                      "~/Content/template/newsfeed/assets/css/font-awesome.min.css",
                      "~/Content/template/newsfeed/assets/css/animate.css",
                      "~/Content/template/newsfeed/assets/css/font.css",
                      "~/Content/template/newsfeed/assets/css/li-scroller.css",
                      "~/Content/template/newsfeed/assets/css/slick.css",
                      "~/Content/template/newsfeed/assets/css/jquery.fancybox.css",
                      "~/Content/template/newsfeed/assets/css/theme.css",
                      "~/Content/template/newsfeed/assets/css/style.css"));
        }
    }
}
