using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TumblrFollowButtonWidget"/>.</para>
  /// </summary>
  public sealed class TumblrFollowButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="TumblrFollowButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new TumblrFollowButtonWidget();
      Assert.Null(widget.Field("account"));
      Assert.Equal(TumblrFollowButtonType.First, widget.Field("type").To<TumblrFollowButtonType>());
      Assert.Equal(TumblrFollowButtonColorScheme.Light.ToString().ToLowerInvariant(), widget.Field("colorScheme").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TumblrFollowButtonWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new TumblrFollowButtonWidget().Account(string.Empty));

      var widget = new TumblrFollowButtonWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.Type(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      var widget = new TumblrFollowButtonWidget();
      Assert.Equal((byte)TumblrFollowButtonType.First, widget.Field("type").To<byte>());
      Assert.True(ReferenceEquals(widget.Type(1), widget));
      Assert.Equal(1, widget.Field("type").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.ColorScheme(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TumblrFollowButtonWidget().ColorScheme(null));
      Assert.Throws<ArgumentException>(() => new TumblrFollowButtonWidget().ColorScheme(string.Empty));

      var widget = new TumblrFollowButtonWidget();
      Assert.Equal(TumblrFollowButtonColorScheme.Light.ToString().ToLowerInvariant(), widget.Field("colorScheme").To<string>());
      Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
      Assert.Equal("colorScheme", widget.Field("colorScheme").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void WriteTo_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TumblrFollowButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new TumblrFollowButtonWidget().Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<iframe allowtransparency=""true"" border=""0"" class=""btn"" frameborder=""0"" height=""25"" scrolling=""no"" src=""http://platform.tumblr.com/v1/follow_button.html?button_type=1&amp;tumblelog=account&amp;color_scheme=light"" width=""189""></iframe>", new StringWriter().With(writer => new TumblrFollowButtonWidget().Account("account").Write(writer)).ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" border=""0"" class=""btn"" frameborder=""0"" height=""25"" scrolling=""no"" src=""http://platform.tumblr.com/v1/follow_button.html?button_type=2&amp;tumblelog=account&amp;color_scheme=dark"" width=""113""></iframe>", new StringWriter().With(writer => new TumblrFollowButtonWidget().Account("account").Type(TumblrFollowButtonType.Second).ColorScheme(TumblrFollowButtonColorScheme.Dark).Write(writer)).ToString());
    }
  }
}