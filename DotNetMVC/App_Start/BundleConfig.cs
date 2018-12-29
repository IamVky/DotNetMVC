using System.Web.Optimization;

namespace DotNetMVC {
    public class BundleConfig {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Contents/lib/jquery/dist/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Contents/lib/popper.js/dist/umd/popper.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Contents/lib/jquery-validation/dist/jquery.validate.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Contents/lib/modernizr/dist/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Contents/lib/twitter-bootstrap/dist/js/bootstrap.bundle.js",
                      "~/Contents/lib/twitter-bootstrap/dist/js/bootstrap.js"));

            //bundles.Add(new ScriptBundle("~/Contents/js/body").Include(
            //          "~/Contents/js/body/body.js"));

            //bundles.Add(new ScriptBundle("~/Contents/js/head").Include(
            //          "~/Contents/js/head/head.js"));

            bundles.Add(new ScriptBundle("~/Contents/js").Include(
                      "~/Contents/js/site.js"));

            bundles.Add(new StyleBundle("~/Contents/css").Include(
                 "~/Contents/lib/twitter-bootstrap/dist/css/bootstrap.css",
                 "~/Contents/css/site.css"));
        }
    }
}
