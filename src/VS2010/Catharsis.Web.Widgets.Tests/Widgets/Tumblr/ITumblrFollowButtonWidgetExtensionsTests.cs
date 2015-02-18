using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ITumblrFollowButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class ITumblrFollowButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ITumblrFollowButtonWidgetExtensions.Type(ITumblrFollowButtonWidget, TumblrFollowButtonType)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrFollowButtonWidgetExtensions.Type(null, TumblrFollowButtonType.First));

      new TumblrFollowButtonWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Type(TumblrFollowButtonType.First), widget));
        Assert.Equal(1, widget.Type());
        Assert.Equal(2, widget.Type(TumblrFollowButtonType.Second).Type());
        Assert.Equal(3, widget.Type(TumblrFollowButtonType.Third).Type());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ITumblrFollowButtonWidgetExtensions.ColorScheme(ITumblrFollowButtonWidget, TumblrFollowButtonColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ITumblrFollowButtonWidgetExtensions.ColorScheme(null, TumblrFollowButtonColorScheme.Dark));

      new TumblrFollowButtonWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.ColorScheme(TumblrFollowButtonColorScheme.Dark), widget));
        Assert.Equal("dark", widget.ColorScheme());
        Assert.Equal("light", widget.ColorScheme(TumblrFollowButtonColorScheme.Light).ColorScheme());
      });
    }
  }
}