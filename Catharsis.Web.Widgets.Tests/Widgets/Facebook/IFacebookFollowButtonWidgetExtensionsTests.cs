using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookFollowButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookFollowButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Width(IFacebookFollowButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFollowButtonWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookFollowButtonWidget().Width(1).Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Height(IFacebookFollowButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFollowButtonWidgetExtensions.Height(null, 0));

      Assert.Equal("1", new FacebookFollowButtonWidget().Height(1).Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.ColorScheme(IFacebookFollowButtonWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFollowButtonWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookFollowButtonWidget().ColorScheme(FacebookColorScheme.Dark).Field("colorScheme").To<string>());
      Assert.Equal("light", new FacebookFollowButtonWidget().ColorScheme(FacebookColorScheme.Light).Field("colorScheme").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Layout(IFacebookFollowButtonWidget, FacebookButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFollowButtonWidgetExtensions.Layout(null, FacebookButtonLayout.BoxCount));

      Assert.Equal("box_count", new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.BoxCount).Field("layout").To<string>());
      Assert.Equal("button_count", new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.ButtonCount).Field("layout").To<string>());
      Assert.Equal("standard", new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.Standard).Field("layout").To<string>());
    }
  }
}