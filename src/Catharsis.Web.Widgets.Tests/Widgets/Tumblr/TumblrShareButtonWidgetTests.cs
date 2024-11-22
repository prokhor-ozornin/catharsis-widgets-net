using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TumblrShareButtonWidget"/>.</para>
/// </summary>
public sealed class TumblrShareButtonWidgetTests : ClassTest<TumblrShareButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TumblrShareButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TumblrShareButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITumblrShareButtonWidget>();

    var widget = new TumblrShareButtonWidget();
    widget.Type().Should().Be((byte) TumblrShareButtonType.First);
    widget.ColorScheme().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.Type(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      var widget = new TumblrFollowButtonWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte type, ITumblrFollowButtonWidget widget)
    {
      widget.Type(type).Should().BeSameAs(widget);
      widget.Type().Should().Be(type);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new TumblrShareButtonWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new TumblrShareButtonWidget().ColorScheme(string.Empty));

    using (new AssertionScope())
    {
      var widget = new TumblrFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, ITumblrFollowButtonWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("""<a href="http://www.tumblr.com/share" style="display:inline-block; text-indent:-9999px; overflow:hidden; width:80px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_1.png&#39;) top left no-repeat transparent;" title="Share on Tumblr">Share on Tumblr</a>""", new TumblrShareButtonWidget().ToString());
    Assert.Equal("""<a href="http://www.tumblr.com/share" style="display:inline-block; text-indent:-9999px; overflow:hidden; width:70px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_2T.png&#39;) top left no-repeat transparent;" title="Share on Tumblr">Share on Tumblr</a>""", new TumblrShareButtonWidget().Type(TumblrShareButtonType.Second).ColorScheme(TumblrShareButtonColorScheme.Gray).ToString());
  }
}