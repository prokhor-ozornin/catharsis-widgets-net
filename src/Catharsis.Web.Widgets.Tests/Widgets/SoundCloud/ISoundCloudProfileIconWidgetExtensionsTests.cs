using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ISoundCloudProfileIconWidgetExtensions"/>.</para>
/// </summary>
public sealed class ISoundCloudProfileIconWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.OrangeWhite(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void OrangeWhite_Method()
  {
    AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.OrangeWhite(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SoundCloudProfileIconWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.OrangeWhite(), widget));
      Assert.Equal("orange_white", widget.Color());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.WhiteOrange(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void WhiteOrange_Method()
  {
    AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.WhiteOrange(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SoundCloudProfileIconWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.WhiteOrange(), widget));
      Assert.Equal("white_orange", widget.Color());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.BlackWhite(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void BlackWhite_Method()
  {
    AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.BlackWhite(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SoundCloudProfileIconWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.BlackWhite(), widget));
      Assert.Equal("black_white", widget.Color());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.WhiteTransparent(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void WhiteTransparent_Method()
  {
    AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.WhiteTransparent(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SoundCloudProfileIconWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.WhiteTransparent(), widget));
      Assert.Equal("white_transparent", widget.Color());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.OrangeTransparent(ISoundCloudProfileIconWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void OrangeTransparent_Method()
  {
    AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.OrangeTransparent(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SoundCloudProfileIconWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.OrangeTransparent(), widget));
      Assert.Equal("orange_transparent", widget.Color());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.Size(ISoundCloudProfileIconWidget, SoundCloudProfileIconSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    AssertionExtensions.Should(() => ISoundCloudProfileIconWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new SoundCloudProfileIconWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Size(SoundCloudProfileIconSize.Size16), widget));
      Assert.Equal((short) 16, widget.Size());
    });
  }
}