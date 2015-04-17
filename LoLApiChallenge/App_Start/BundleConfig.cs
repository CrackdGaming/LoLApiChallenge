using System.Web;
using System.Web.Optimization;

namespace LoLApiChallenge
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/heatmap").Include("~/Scripts/heatmap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/d3").Include("~/Scripts/d3.v3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/numeral").Include("~/Scripts/numeral.min.js"));

            bundles.Add(new LessBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap/bootstrap.less"));

            bundles.Add(new LessBundle("~/bundles/less").Include("~/Content/main.less"));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
