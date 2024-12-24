using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookRecommendationsFeedWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookRecommendationsFeedWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Actions(IFacebookRecommendationsFeedWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.Actions(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.False(new FacebookRecommendationsFeedWidget().Actions().Any());
    Assert.True(new FacebookRecommendationsFeedWidget().Actions("first", "second").Actions().SequenceEqual(new[] { "first", "second" }));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Width(IFacebookRecommendationsFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookRecommendationsFeedWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Height(IFacebookRecommendationsFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookRecommendationsFeedWidget().Height(1).Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.ColorScheme(IFacebookRecommendationsFeedWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("dark", new FacebookRecommendationsFeedWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
    Assert.Equal("light", new FacebookRecommendationsFeedWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
  }
}