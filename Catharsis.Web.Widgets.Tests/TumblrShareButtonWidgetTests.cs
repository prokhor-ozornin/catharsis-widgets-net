using System;
using System.IO;
using Catharsis.Commons;
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
    ///   <seealso cref="TumblrShareButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new TumblrShareButtonWidget();
      Assert.Equal(TumblrShareButtonType.First, widget.Field("type").To<TumblrShareButtonType>());
      Assert.Equal(TumblrFollowButtonType.First, widget.Field("type").To<TumblrFollowButtonType>());
      Assert.Null(widget.Field("colorScheme"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.Type(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      var widget = new TumblrShareButtonWidget();
      Assert.Equal((byte)TumblrShareButtonType.First, widget.Field("type").To<byte>());
      Assert.True(ReferenceEquals(widget.Type(1), widget));
      Assert.Equal(1, widget.Field("type").To<byte>());
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
      Assert.Null(widget.Field("colorScheme"));
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.Field("colorScheme").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TumblrShareButtonWidget().Write(null));

      Assert.Equal(@"<a href=""http://www.tumblr.com/share"" style=""display:inline-block; text-indent:-9999px; overflow:hidden; width:80px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_1.png&#39;) top left no-repeat transparent;"" title=""Share on Tumblr"">Share on Tumblr</a>", new StringWriter().With(writer => new TumblrShareButtonWidget().Write(writer)).ToString());
      Assert.Equal(@"<a href=""http://www.tumblr.com/share"" style=""display:inline-block; text-indent:-9999px; overflow:hidden; width:70px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_2T.png&#39;) top left no-repeat transparent;"" title=""Share on Tumblr"">Share on Tumblr</a>", new StringWriter().With(writer => new TumblrShareButtonWidget().Type(TumblrShareButtonType.Second).ColorScheme(TumblrShareButtonColorScheme.Gray).Write(writer)).ToString());
    }
  }
}