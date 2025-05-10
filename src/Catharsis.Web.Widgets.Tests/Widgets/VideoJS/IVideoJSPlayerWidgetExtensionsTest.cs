using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVideoJSPlayerWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVideoJSPlayerWidgetExtensionsTest : Test
{
  private IVideoJSPlayerWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVideoJSPlayerWidgetExtensionsTest() => Widget = Fixture.Create<IVideoJSPlayerWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Width(IVideoJSPlayerWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture.Create<short>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, IVideoJSPlayerWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Height(IVideoJSPlayerWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture.Create<short>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short height, IVideoJSPlayerWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVideoJSPlayerWidgetExtensions.Videos(IVideoJSPlayerWidget, ValueTuple{string, string}[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Videos_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Videos(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IVideoJSPlayerWidgetExtensions.Videos(new VideoJSPlayerWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("videos");

      new[] { Array.Empty<(string Url, string ContentType)>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test((string Url, string ContentType)[] videos, IVideoJSPlayerWidget widget) => IVideoJSPlayerWidgetExtensions.Videos(widget, videos).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<(string ContentType, string Url)>>("VideosValue").Should().Equal(videos);
  }
}