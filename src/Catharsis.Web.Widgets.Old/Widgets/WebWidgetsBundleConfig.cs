using System.Web.Optimization;

namespace Catharsis.Web.Widgets
{
  public sealed class WebWidgetsBundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/WebWidgets/Cackle").Include("~/Scripts/WebWidgets/cackle.js"));
      bundles.Add(new ScriptBundle("~/WebWidgets/Disqus").Include("~/Scripts/WebWidgets/disqus.js"));
      bundles.Add(new ScriptBundle("~/WebWidgets/Google").Include("~/Scripts/WebWidgets/google_analytics.js", "~/Scripts/WebWidgets/google_plusone.js"));
      bundles.Add(new ScriptBundle("~/WebWidgets/Twitter").Include("~/Scripts/WebWidgets/twitter_initialize.js"));
    }
  }
}