using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="FacebookCommentsWidget"/>.</para>
/// </summary>
public sealed class FacebookCommentsWidgetTests : ClassTest<FacebookCommentsWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookCommentsWidget>();

    var widget = new FacebookCommentsWidget();
    widget.ColorScheme().Should().BeNull();
    widget.Mobile().Should().BeNull();
    widget.Order().Should().BeNull();
    widget.Posts().Should().BeNull();
    widget.Url().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().ColorScheme(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, IFacebookCommentsWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Mobile(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mobile_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookCommentsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool mobile, IFacebookCommentsWidget widget)
    {
      widget.Mobile(mobile).Should().BeSameAs(widget);
      widget.Mobile().Should().Be(mobile);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Order(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Order_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().Order(null));
    Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().Order(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string order, IFacebookCommentsWidget widget)
    {
      widget.Order(order).Should().BeSameAs(widget);
      widget.Order().Should().Be(order);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Posts(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Posts_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookCommentsWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte count, IFacebookCommentsWidget widget)
    {
      widget.Posts(count).Should().BeSameAs(widget);
      widget.Posts().Should().Be(count);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IFacebookCommentsWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookCommentsWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookCommentsWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookCommentsWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("""<div class="fb-comments"></div>""", new FacebookCommentsWidget().ToString());
    Assert.Equal("""<div class="fb-comments" data-colorscheme="dark" data-href="url" data-mobile="true" data-num-posts="1" data-order-by="reverse_time" data-width="width"></div>""", new FacebookCommentsWidget().Url("url").Posts(1).Width("width").ColorScheme(FacebookColorScheme.Dark).Mobile(true).Order(FacebookCommentsOrder.ReverseTime).ToString());
  }
}