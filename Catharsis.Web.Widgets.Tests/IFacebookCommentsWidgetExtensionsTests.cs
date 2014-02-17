using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookCommentsWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookCommentsWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Width(IFacebookCommentsWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookCommentsWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookCommentsWidget().Width(1).Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.ColorScheme(IFacebookCommentsWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookCommentsWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookCommentsWidget().ColorScheme(FacebookColorScheme.Dark).Field("colorScheme").To<string>());
      Assert.Equal("light", new FacebookCommentsWidget().ColorScheme(FacebookColorScheme.Light).Field("colorScheme").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Order(IFacebookCommentsWidget, FacebookCommentsOrder)"/> method.</para>
    /// </summary>
    [Fact]
    public void Order_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookCommentsWidgetExtensions.Order(null, FacebookCommentsOrder.Social));

      Assert.Equal("reverse_time", new FacebookCommentsWidget().Order(FacebookCommentsOrder.ReverseTime).Field("order").To<string>());
      Assert.Equal("social", new FacebookCommentsWidget().Order(FacebookCommentsOrder.Social).Field("order").To<string>());
      Assert.Equal("time", new FacebookCommentsWidget().Order(FacebookCommentsOrder.Time).Field("order").To<string>());
    }
  }
}