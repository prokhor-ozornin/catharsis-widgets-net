using System;
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

      Assert.Equal("box_count", new FacebookLikeButtonWidget().Layout(FacebookButtonLayout.BoxCount).Layout());
      Assert.Equal("button_count", new FacebookLikeButtonWidget().Layout(FacebookButtonLayout.ButtonCount).Layout());
      Assert.Equal("standard", new FacebookLikeButtonWidget().Layout(FacebookButtonLayout.Standard).Layout());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Width(IFacebookLikeButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookLikeButtonWidget().Width(1).Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Verb(IFacebookLikeButtonWidget, FacebookLikeButtonVerb)"/> method.</para>
    /// </summary>
    [Fact]
    public void Verb_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.Verb(null, FacebookLikeButtonVerb.Like));

      Assert.Equal("like", new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Like).Verb());
      Assert.Equal("recommend", new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Recommend).Verb());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.ColorScheme(IFacebookLikeButtonWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookLikeButtonWidgetExtensions.ColorScheme(null, FacebookColorScheme.Light));

      Assert.Equal("dark", new FacebookLikeButtonWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
      Assert.Equal("light", new FacebookLikeButtonWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
    }
  }
}