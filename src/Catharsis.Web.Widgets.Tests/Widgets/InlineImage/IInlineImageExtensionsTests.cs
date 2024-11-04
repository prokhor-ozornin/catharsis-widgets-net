using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IInlineImageExtensions"/>.</para>
  /// </summary>
  public sealed class IInlineImageExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IInlineImageExtensions.Jpg(IInlineImageWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Jpg_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IInlineImageExtensions.Jpg(null));

      var widget = new InlineImageWidget();
      Assert.True(ReferenceEquals(widget.Jpg(), widget));
      Assert.True(widget.Contents(Guid.Empty.ToByteArray()).ToHtmlString().Contains("data:jpg"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IInlineImageExtensions.Png(IInlineImageWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Png_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IInlineImageExtensions.Png(null));

      var widget = new InlineImageWidget();
      Assert.True(ReferenceEquals(widget.Png(), widget));
      Assert.True(widget.Contents(Guid.Empty.ToByteArray()).ToHtmlString().Contains("data:png"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IInlineImageExtensions.Gif(IInlineImageWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Gif_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IInlineImageExtensions.Gif(null));

      var widget = new InlineImageWidget();
      Assert.True(ReferenceEquals(widget.Gif(), widget));
      Assert.True(widget.Contents(Guid.Empty.ToByteArray()).ToHtmlString().Contains("data:gif"));
    }
  }
}