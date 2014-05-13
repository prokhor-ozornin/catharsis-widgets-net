using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ITumblrShareButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class ITumblrShareButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ITumblrShareButtonWidgetExtensions.Type(ITumblrShareButtonWidget, TumblrShareButtonType)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrShareButtonWidgetExtensions.Type(null, 0));

      new TumblrShareButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Type(TumblrShareButtonType.First), widget));
        Assert.Equal(1, widget.Type());
        Assert.Equal(2, widget.Type(TumblrShareButtonType.Second).Type());
        Assert.Equal(3, widget.Type(TumblrShareButtonType.Third).Type());
        Assert.Equal(4, widget.Type(TumblrShareButtonType.Forth).Type());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITumblrShareButtonWidgetExtensions.ColorScheme(ITumblrShareButtonWidget, TumblrShareButtonColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrShareButtonWidgetExtensions.ColorScheme(null, TumblrShareButtonColorScheme.Gray));

      new TumblrShareButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.ColorScheme(TumblrShareButtonColorScheme.Gray), widget));
        Assert.Equal("gray", widget.ColorScheme(TumblrShareButtonColorScheme.Gray).ColorScheme());
        Assert.Equal("light", widget.ColorScheme(TumblrShareButtonColorScheme.Light).ColorScheme());
      });
    }
  }
}