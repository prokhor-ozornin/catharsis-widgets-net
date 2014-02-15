using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookLikeButtonWidgetExtensions"/></para>
  /// </summary>
  public sealed class IFacebookLikeButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Layout(IFacebookLikeButtonWidget, FacebookButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.Layout(null, FacebookButtonLayout.Standard));

      Assert.True(new FacebookLikeButtonWidget().Layout(FacebookButtonLayout.BoxCount).Field("layout").To<string>() == "box_count");
      Assert.True(new FacebookLikeButtonWidget().Layout(FacebookButtonLayout.ButtonCount).Field("layout").To<string>() == "button_count");
      Assert.True(new FacebookLikeButtonWidget().Layout(FacebookButtonLayout.Standard).Field("layout").To<string>() == "standard");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Width(IFacebookLikeButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.Width(null, 0));

      Assert.True(new FacebookLikeButtonWidget().Width(1).Field("width").To<string>() == "1");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Verb(IFacebookLikeButtonWidget, FacebookLikeButtonVerb)"/> method.</para>
    /// </summary>
    [Fact]
    public void Verb_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.Verb(null, FacebookLikeButtonVerb.Like));

      Assert.True(new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Like).Field("verb").To<string>() == "like");
      Assert.True(new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Recommend).Field("verb").To<string>() == "recommend");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.ColorScheme(IFacebookLikeButtonWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.ColorScheme(null, FacebookColorScheme.Light));

      Assert.True(new FacebookLikeButtonWidget().ColorScheme(FacebookColorScheme.Dark).Field("colorScheme").To<string>() == "dark");
      Assert.True(new FacebookLikeButtonWidget().ColorScheme(FacebookColorScheme.Light).Field("colorScheme").To<string>() == "light");
    }
  }
}