﻿using System.Web;
using System.Web.Optimization;

namespace KendoUIAppScheduler
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // added by DP 

            bundles.Add(new ScriptBundle("~/bundles/2016.1.112/kendo").Include(
            "~/Scripts/kendo/2016.1.112/kendo.all.min.js",
            "~/Scripts/kendo/2016.1.112/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
            "~/Content/kendo/kendo.common-bootstrap.min.css",
            "~/Content/kendo/kendo.bootstrap.min.css"));


            //////bundles.Add(new ScriptBundle("~/bundles/kendo/2016.1.112").Include(
            //////"~/Scripts/kendo/2016.1.112/kendo.all.min.js",
            //////"~/Scripts/kendo/2016.1.112/kendo.web.js",
            //////    // "~/Scripts/kendo/kendo.timezones.min.js", // uncomment if using the Scheduler
            //////"~/Scripts/kendo/2016.1.112/kendo.aspnetmvc.min.js"));


            //////// 
            //////bundles.Add(new StyleBundle("~/Content/kendo/css/2016.1.112").Include(
            //////"~/Content/kendo/2016.1.112/kendo.common.min.css",
            //////"~/Content/kendo/2016.1.112/kendo.default.min.css"));

            bundles.IgnoreList.Clear();
        }
    }
}
