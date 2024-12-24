using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookActivityFeedWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookActivityFeedWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Actions(IFacebookActivityFeedWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.Actions(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookActivityFeedWidget();
      new[] { Array.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string[] actions, IFacebookActivityFeedWidget widget)
    {
      widget.Actions(actions).Should().BeSameAs(widget);
      widget.Actions().Should().Equal(actions);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Width(IFacebookActivityFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookActivityFeedWidget();
      new[] { Array.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string[] actions, IFacebookActivityFeedWidget widget)
    {
      widget.Actions(actions).Should().BeSameAs(widget);
      widget.Actions().Should().Equal(actions);
    }


    Assert.Throws<ArgumentNullException>(() => IFacebookActivityFeedWidgetExtensions.Width(null, 0));

    Assert.Equal("1", new FacebookActivityFeedWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Height(IFacebookActivityFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookActivityFeedWidget().Height(1).Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.ColorScheme(IFacebookActivityFeedWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("dark", new FacebookActivityFeedWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
    Assert.Equal("light", new FacebookActivityFeedWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
  }
}