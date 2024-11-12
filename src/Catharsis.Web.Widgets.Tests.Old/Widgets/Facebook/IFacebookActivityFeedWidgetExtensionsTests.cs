using System;
using System.Linq;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookActivityFeedWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookActivityFeedWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Actions(IFacebookActivityFeedWidget, string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Actions_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookActivityFeedWidgetExtensions.Actions(null, Enumerable.Empty<string>().ToArray()));

      Assert.False(new FacebookActivityFeedWidget().Actions().Any());
      Assert.True(new FacebookActivityFeedWidget().Actions("first", "second").Actions().SequenceEqual(new [] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Width(IFacebookActivityFeedWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookActivityFeedWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookActivityFeedWidget().Width(1).Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Height(IFacebookActivityFeedWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookActivityFeedWidgetExtensions.Height(null, 0));

      Assert.Equal("1", new FacebookActivityFeedWidget().Height(1).Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.ColorScheme(IFacebookActivityFeedWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookActivityFeedWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookActivityFeedWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
      Assert.Equal("light", new FacebookActivityFeedWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
    }
  }
}