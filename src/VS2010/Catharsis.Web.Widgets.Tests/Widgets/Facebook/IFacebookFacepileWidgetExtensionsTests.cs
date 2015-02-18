using System;
using System.Linq;
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

      Assert.False(new FacebookFacepileWidget().Actions().Any());
      Assert.Equal("actions", new FacebookFacepileWidget().Actions("actions").Actions().Single());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.PhotoSize(IFacebookFacepileWidget, FacebookFacepilePhotoSize)"/> method.</para>
    /// </summary>
    [Fact]
    public void PhotoSize_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.PhotoSize(null, FacebookFacepilePhotoSize.Large));

      Assert.Equal("large", new FacebookFacepileWidget().PhotoSize(FacebookFacepilePhotoSize.Large).PhotoSize());
      Assert.Equal("medium", new FacebookFacepileWidget().PhotoSize(FacebookFacepilePhotoSize.Medium).PhotoSize());
      Assert.Equal("small", new FacebookFacepileWidget().PhotoSize(FacebookFacepilePhotoSize.Small).PhotoSize());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.Width(IFacebookFacepileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookFacepileWidget().Width(1).Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.Height(IFacebookFacepileWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.Height(null, 0));

      Assert.Equal("1", new FacebookFacepileWidget().Height(1).Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFacepileWidgetExtensions.ColorScheme(IFacebookFacepileWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFacepileWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookFacepileWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
      Assert.Equal("light", new FacebookFacepileWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
    }
  }
}