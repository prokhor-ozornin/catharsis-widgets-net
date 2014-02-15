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

      Assert.True(new FacebookFollowButtonWidget().Width(1).Field("width").To<string>() == "1");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Height(IFacebookFollowButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFollowButtonWidgetExtensions.Height(null, 0));

      Assert.True(new FacebookFollowButtonWidget().Height(1).Field("height").To<string>() == "1");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.ColorScheme(IFacebookFollowButtonWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFollowButtonWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.True(new FacebookFollowButtonWidget().ColorScheme(FacebookColorScheme.Dark).Field("colorScheme").To<string>() == "dark");
      Assert.True(new FacebookFollowButtonWidget().ColorScheme(FacebookColorScheme.Light).Field("colorScheme").To<string>() == "light");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Layout(IFacebookFollowButtonWidget, FacebookButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookFollowButtonWidgetExtensions.Layout(null, FacebookButtonLayout.BoxCount));

      Assert.True(new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.BoxCount).Field("layout").To<string>() == "box_count");
      Assert.True(new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.ButtonCount).Field("layout").To<string>() == "button_count");
      Assert.True(new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.Standard).Field("layout").To<string>() == "standard");
    }
  }
}