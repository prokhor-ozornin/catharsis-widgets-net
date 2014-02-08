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
        Assert.True(widget.Field("type").To<byte>() == 1);
        Assert.True(widget.Type(TumblrShareButtonType.Second).Field("type").To<byte>() == 2);
        Assert.True(widget.Type(TumblrShareButtonType.Third).Field("type").To<byte>() == 3);
        Assert.True(widget.Type(TumblrShareButtonType.Forth).Field("type").To<byte>() == 4);
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
        Assert.True(widget.ColorScheme(TumblrShareButtonColorScheme.Gray).Field("colorScheme").To<string>() == "gray");
        Assert.True(widget.ColorScheme(TumblrShareButtonColorScheme.Light).Field("colorScheme").To<string>() == "light");
      });
    }
  }
}