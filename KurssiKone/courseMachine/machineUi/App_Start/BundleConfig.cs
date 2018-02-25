using System.Web;
using System.Web.Optimization;

namespace machineUi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                    "~/Scripts/angular.js",
                    "~/Scripts/angular-route.js",
                    "~/Scripts/angular-cookies.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                    "~/Scripts/Controllers/app.js",
                    "~/Scripts/Controllers/hubController.js",
                    "~/Scripts/Controllers/hiddenController.js",
                    "~/Scripts/Controllers/courseConfig/configController.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/config").Include(
                    "~/Scripts/Controllers/courseConfig/configController.ks",
                    "~/Scripts/Controllers/courseConfig/treeController.js",
                    "~/Scripts/Controllers/courseConfig/viewController.js"
                ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/hub.css"));
        }
    }
}
