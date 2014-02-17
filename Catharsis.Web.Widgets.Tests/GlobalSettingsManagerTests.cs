using System.Linq;
using System.Web;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GlobalSettingsManager"/>.</para>
  /// </summary>
  public sealed class GlobalSettingsManagerTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="GlobalSettingsManager.Application"/> property.</para>
    /// </summary>
    [Fact(Skip = "Tests must run in context of web application")]
    public void Application_Property()
    {
      Assert.NotNull(Settings.Global.Application);
      Assert.True(ReferenceEquals(Settings.Global.Application, Settings.Global.Application));

      TestSettingsProvider(Settings.Global.Application);
      TestSettingsProvider(Settings.Local.Cookies);
      TestSettingsProvider(Settings.Local.Session);
    }

    private static void TestSettingsProvider(ISettingsProvider provider)
    {
      Assertion.NotNull(provider);

      const string key= "key";

      Assert.False(provider.Keys.Any());
      Assert.Null(provider[key]);
      var value = new object();
      provider[key] = value;
      Assert.Equal(1, provider.Keys.Count());
      Assert.Equal(key, provider.Keys.Single());
      Assert.True(ReferenceEquals(provider[key], value));
      Assert.True(ReferenceEquals(provider.Remove(key), provider));
      Assert.False(provider.Keys.Any());
      provider[key] = value;
      Assert.True(ReferenceEquals(provider.Clear(), provider));
      Assert.False(provider.Keys.Any());
    }
  }
}