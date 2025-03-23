using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TumblrShareButtonWidget"/>.</para>
/// </summary>
public sealed class TumblrShareButtonWidgetTest : UnitTest
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
    widget.GetPropertyValue<byte>("TypeProperty").Should().Be((byte) TumblrShareButtonType.First);
    widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.Type(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      var widget = new TumblrShareButtonWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte type, ITumblrShareButtonWidget widget)
    {
      widget.Type(type).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("TypeProperty").Should().Be(type);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TumblrShareButtonWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new TumblrShareButtonWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      var widget = new TumblrShareButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, ITumblrShareButtonWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new TumblrShareButtonWidget(), """<a href="http://www.tumblr.com/share" style="display:inline-block; text-indent:-9999px; overflow:hidden; width:80px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_1.png&#39;) top left no-repeat transparent;" title="Share on Tumblr">Share on Tumblr</a>""");
      Validate(new TumblrShareButtonWidget().Type(TumblrShareButtonType.Second).ColorScheme(TumblrShareButtonColorScheme.Gray), """<a href="http://www.tumblr.com/share" style="display:inline-block; text-indent:-9999px; overflow:hidden; width:70px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_2T.png&#39;) top left no-repeat transparent;" title="Share on Tumblr">Share on Tumblr</a>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}