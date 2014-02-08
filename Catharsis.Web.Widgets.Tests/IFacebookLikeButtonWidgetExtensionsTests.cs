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
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Layout(IFacebookLikeButtonWidget, FacebookLikeButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.Layout(null, FacebookLikeButtonLayout.Standard));

      Assert.True(new FacebookLikeButtonWidget().Layout(FacebookLikeButtonLayout.BoxCount).Field("layout").To<string>() == "box_count");
      Assert.True(new FacebookLikeButtonWidget().Layout(FacebookLikeButtonLayout.ButtonCount).Field("layout").To<string>() == "button_count");
      Assert.True(new FacebookLikeButtonWidget().Layout(FacebookLikeButtonLayout.Standard).Field("layout").To<string>() == "standard");
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
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.ColorScheme(IFacebookLikeButtonWidget, FacebookLikeButtonColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.ColorScheme(null, FacebookLikeButtonColorScheme.Light));

      Assert.True(new FacebookLikeButtonWidget().ColorScheme(FacebookLikeButtonColorScheme.Dark).Field("colorScheme").To<string>() == "dark");
      Assert.True(new FacebookLikeButtonWidget().ColorScheme(FacebookLikeButtonColorScheme.Light).Field("colorScheme").To<string>() == "light");
    }
  }
}