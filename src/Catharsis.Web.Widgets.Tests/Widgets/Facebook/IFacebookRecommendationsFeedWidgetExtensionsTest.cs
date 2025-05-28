using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookRecommendationsFeedWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookRecommendationsFeedWidgetExtensionsTest : Test
{
  private IFacebookRecommendationsFeedWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IFacebookRecommendationsFeedWidgetExtensionsTest() => Widget = Fixture<IFacebookRecommendationsFeedWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Actions(IFacebookRecommendationsFeedWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { Array.Empty<string>(), [Fixture<string>.Create()] }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string[] actions, IFacebookRecommendationsFeedWidget widget) => IFacebookRecommendationsFeedWidgetExtensions.Actions(widget, actions).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(actions);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookRecommendationsFeedWidgetExtensions.Width(IFacebookRecommendationsFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookRecommendationsFeedWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, IFacebookRecommendationsFeedWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
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
      AssertionExtensions.Should(() => new FacebookRecommendationsFeedWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short height, IFacebookRecommendationsFeedWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
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

      Enum.GetValues<FacebookColorScheme>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(FacebookColorScheme scheme, IFacebookRecommendationsFeedWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}