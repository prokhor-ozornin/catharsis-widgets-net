using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TumblrShareButtonWidget"/>.</para>
  /// </summary>
  public sealed class TumblrShareButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="TumblrShareButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new TumblrShareButtonWidget();
      Assert.Equal((byte) TumblrShareButtonType.First, widget.Type());
      Assert.Null(widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.Type(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      var widget = new TumblrShareButtonWidget();
      Assert.Equal((byte) TumblrShareButtonType.First, widget.Type());
      Assert.True(ReferenceEquals(widget.Type(1), widget));
      Assert.Equal(1, widget.Type());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TumblrShareButtonWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new TumblrShareButtonWidget().ColorScheme(string.Empty));

      var widget = new TumblrShareButtonWidget();
      Assert.Null(widget.ColorScheme());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.ColorScheme());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<a href=""http://www.tumblr.com/share"" style=""display:inline-block; text-indent:-9999px; overflow:hidden; width:80px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_1.png&#39;) top left no-repeat transparent;"" title=""Share on Tumblr"">Share on Tumblr</a>", new TumblrShareButtonWidget().ToString());
      Assert.Equal(@"<a href=""http://www.tumblr.com/share"" style=""display:inline-block; text-indent:-9999px; overflow:hidden; width:70px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_2T.png&#39;) top left no-repeat transparent;"" title=""Share on Tumblr"">Share on Tumblr</a>", new TumblrShareButtonWidget().Type(TumblrShareButtonType.Second).ColorScheme(TumblrShareButtonColorScheme.Gray).ToString());
    }
  }
}