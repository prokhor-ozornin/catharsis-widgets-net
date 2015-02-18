using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ISoundCloudProfileIconWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class ISoundCloudProfileIconWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ISoundCloudProfileIconWidgetExtensions.OrangeWhite(ISoundCloudProfileIconWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void OrangeWhite_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISoundCloudProfileIconWidgetExtensions.OrangeWhite(null));

      new SoundCloudProfileIconWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => ISoundCloudProfileIconWidgetExtensions.WhiteOrange(null));

      new SoundCloudProfileIconWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => ISoundCloudProfileIconWidgetExtensions.BlackWhite(null));

      new SoundCloudProfileIconWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => ISoundCloudProfileIconWidgetExtensions.WhiteTransparent(null));

      new SoundCloudProfileIconWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => ISoundCloudProfileIconWidgetExtensions.OrangeTransparent(null));

      new SoundCloudProfileIconWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => ISoundCloudProfileIconWidgetExtensions.Size(null, SoundCloudProfileIconSize.Size16));

      new SoundCloudProfileIconWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Size(SoundCloudProfileIconSize.Size16), widget));
        Assert.Equal((short) 16, widget.Size());
      });
    }
  }
}