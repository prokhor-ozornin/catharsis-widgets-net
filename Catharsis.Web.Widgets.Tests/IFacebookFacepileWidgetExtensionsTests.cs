using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookFacepileWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookFacepileWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.Actions(IFacebookFacepileWidget, string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Actions_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.Actions(null));

      Assert.False(new FacebookFacepileWidget().Actions().Field("actions").To<IEnumerable<string>>().Any());
      Assert.Equal("actions", new FacebookFacepileWidget().Actions("actions").Field("actions").To<IEnumerable<string>>().Single());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.Size(IFacebookFacepileWidget, FacebookFacepileSize)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.Size(null, FacebookFacepileSize.Large));

      Assert.Equal("large", new FacebookFacepileWidget().Size(FacebookFacepileSize.Large).Field("size").To<string>());
      Assert.Equal("medium", new FacebookFacepileWidget().Size(FacebookFacepileSize.Medium).Field("size").To<string>());
      Assert.Equal("small", new FacebookFacepileWidget().Size(FacebookFacepileSize.Small).Field("size").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.Width(IFacebookFacepileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookFacepileWidget().Width(1).Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.Height(IFacebookFacepileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.Height(null, 0));

      Assert.Equal("1", new FacebookFacepileWidget().Height(1).Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.ColorScheme(IFacebookFacepileWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookFacepileWidget().ColorScheme(FacebookColorScheme.Dark).Field("colorScheme").To<string>());
      Assert.Equal("light", new FacebookFacepileWidget().ColorScheme(FacebookColorScheme.Light).Field("colorScheme").To<string>());
    }
  }
}