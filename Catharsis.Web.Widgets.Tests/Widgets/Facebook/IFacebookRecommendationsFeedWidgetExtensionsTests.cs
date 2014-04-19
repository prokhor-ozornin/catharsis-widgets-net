using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookRecommendationsFeedWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookRecommendationsFeedWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Actions(IFacebookRecommendationsFeedWidget, string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Actions_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookRecommendationsFeedWidgetExtensions.Actions(null, Enumerable.Empty<string>().ToArray()));

      Assert.False(new FacebookRecommendationsFeedWidget().Actions().Field("actions").To<IEnumerable<string>>().Any());
      Assert.True(new FacebookRecommendationsFeedWidget().Actions("first", "second").Field("actions").To<IEnumerable<string>>().SequenceEqual(new[] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Width(IFacebookRecommendationsFeedWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookRecommendationsFeedWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookRecommendationsFeedWidget().Width(1).Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Height(IFacebookRecommendationsFeedWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookRecommendationsFeedWidgetExtensions.Height(null, 0));

      Assert.Equal("1", new FacebookRecommendationsFeedWidget().Height(1).Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.ColorScheme(IFacebookRecommendationsFeedWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookRecommendationsFeedWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookRecommendationsFeedWidget().ColorScheme(FacebookColorScheme.Dark).Field("colorScheme").To<string>());
      Assert.Equal("light", new FacebookRecommendationsFeedWidget().ColorScheme(FacebookColorScheme.Light).Field("colorScheme").To<string>());
    }
  }
}