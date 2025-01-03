using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.Actions(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookRecommendationsFeedWidget();
      new[] { Array.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string[] actions, IFacebookRecommendationsFeedWidget widget)
    {
      IFacebookRecommendationsFeedWidgetExtensions.Actions(widget, actions).Should().BeSameAs(widget);
      widget.Actions().Should().Equal(actions);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Width(IFacebookRecommendationsFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookRecommendationsFeedWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IFacebookRecommendationsFeedWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Height(IFacebookRecommendationsFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("height");

      var widget = new FacebookRecommendationsFeedWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short height, IFacebookRecommendationsFeedWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.ColorScheme(IFacebookRecommendationsFeedWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookRecommendationsFeedWidget();
      Enum.GetValues<FacebookColorScheme>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(FacebookColorScheme scheme, IFacebookRecommendationsFeedWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme.ToString().ToLowerInvariant());
    }
  }
}