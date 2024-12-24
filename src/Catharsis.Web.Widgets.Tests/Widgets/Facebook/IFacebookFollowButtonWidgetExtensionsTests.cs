using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookFollowButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookFollowButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Width(IFacebookFollowButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookFollowButtonWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Height(IFacebookFollowButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookFollowButtonWidget().Height(1).Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.ColorScheme(IFacebookFollowButtonWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("dark", new FacebookFollowButtonWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
    Assert.Equal("light", new FacebookFollowButtonWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Layout(IFacebookFollowButtonWidget, FacebookButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("box_count", new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.BoxCount).Layout());
    Assert.Equal("button_count", new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.ButtonCount).Layout());
    Assert.Equal("standard", new FacebookFollowButtonWidget().Layout(FacebookButtonLayout.Standard).Layout());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Url(IFacebookFollowButtonWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    throw new NotImplementedException();
  }
}