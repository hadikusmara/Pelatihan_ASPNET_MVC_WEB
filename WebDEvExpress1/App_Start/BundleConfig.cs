using System.Web;
using System.Web.Optimization;

namespace WebDEvExpress1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/devexp").Include(
                     "~/Scripts/devexpresjs/cldr.min.js",
                     "~/Scripts/devexpresjs/currency.min.js",
                     "~/Scripts/devexpresjs/date.min.js",
                     "~/Scripts/devexpresjs/event.min.js",
                     "~/Scripts/devexpresjs/globalize.min.js",
                     "~/Scripts/devexpresjs/jquery.min.js",
                      "~/Scripts/devexpresjs/message.min.js",
                       "~/Scripts/devexpresjs/number.min.js",
                        "~/Scripts/devexpresjs/supplemental.min.js",
                        "~/Scripts/devexpresjs/unresolved.min.js",
                        "~/Scripts/devexpresjs/dx.all.js",
                         "~/Scripts/devexpresjs/underscore-1.5.1.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/styles.css"));
            bundles.Add(new StyleBundle("~/Content/cssDev").Include(
                   "~/Content/devexpres_css/dx.common.css",
                    "~/Content/devexpres_css/dx.light.css"
                   ));

           
           
        }
    }
}
