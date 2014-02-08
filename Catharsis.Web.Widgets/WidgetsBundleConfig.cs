using System.Web.Optimization;

namespace Catharsis.Web.Widgets
{
  public class WidgetsBundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle(WidgetsScriptsBundles.Cackle).Include("~/Scripts/widgets/cackle.js"));
      bundles.Add(new ScriptBundle(WidgetsScriptsBundles.Disqus).Include("~/Scripts/widgets/disqus.js"));
      bundles.Add(new ScriptBundle(WidgetsScriptsBundles.Facebook).Include("~/Scripts/widgets/facebook.js"));
      bundles.Add(new ScriptBundle(WidgetsScriptsBundles.Google).Include("~/Scripts/widgets/google_analytics.js", "~/Scripts/widgets/google_plusone.js"));
      bundles.Add(new ScriptBundle(WidgetsScriptsBundles.Twitter).Include("~/Scripts/widgets/twitter_initialize.js"));
      bundles.Add(new ScriptBundle("~/widgets").Include(WidgetsScriptsBundles.Cackle, WidgetsScriptsBundles.Disqus, WidgetsScriptsBundles.Facebook, WidgetsScriptsBundles.Google, WidgetsScriptsBundles.Twitter));
    }
  }
}