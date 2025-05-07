using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ISoundCloudProfileIconWidgetExtensions"/>.</para>
/// </summary>
public sealed class ISoundCloudProfileIconWidgetExtensionsTest : Test
{
  private ISoundCloudProfileIconWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public ISoundCloudProfileIconWidgetExtensionsTest() => Widget = Fixture.Create<ISoundCloudProfileIconWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.OrangeWhite(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void OrangeWhite_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.OrangeWhite(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(ISoundCloudProfileIconWidget widget) => widget.OrangeWhite().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("orange_white");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.WhiteOrange(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void WhiteOrange_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.WhiteOrange(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(ISoundCloudProfileIconWidget widget) => widget.WhiteOrange().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("white_orange");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.BlackWhite(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void BlackWhite_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.BlackWhite(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(ISoundCloudProfileIconWidget widget) => widget.BlackWhite().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("black_white");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.WhiteTransparent(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void WhiteTransparent_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.WhiteTransparent(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(ISoundCloudProfileIconWidget widget) => widget.WhiteTransparent().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("white_transparent");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.OrangeTransparent(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void OrangeTransparent_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.OrangeTransparent(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(ISoundCloudProfileIconWidget widget) => widget.OrangeTransparent().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("orange_transparent");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.Size(ISoundCloudProfileIconWidget, SoundCloudProfileIconSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<SoundCloudProfileIconSize>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(SoundCloudProfileIconSize size, ISoundCloudProfileIconWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<short>("SizeValue").Should().Be((short) size);
  }
}