using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookActivityFeedWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookActivityFeedWidgetExtensionsTest : Test
{
  private IFacebookActivityFeedWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IFacebookActivityFeedWidgetExtensionsTest() => Widget = Fixture.Create<IFacebookActivityFeedWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Actions(IFacebookActivityFeedWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { Array.Empty<string>(), [Fixture.Create<string>()] }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string[] actions, IFacebookActivityFeedWidget widget) => widget.Actions(actions).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(actions);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Width(IFacebookActivityFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture.Create<short>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, IFacebookActivityFeedWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.Height(IFacebookActivityFeedWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture.Create<short>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short height, IFacebookActivityFeedWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookActivityFeedWidgetExtensions.ColorScheme(IFacebookActivityFeedWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookActivityFeedWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<FacebookColorScheme>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(FacebookColorScheme scheme, IFacebookActivityFeedWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}