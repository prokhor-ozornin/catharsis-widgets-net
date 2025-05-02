using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookCommentsWidget"/>.</para>
/// </summary>
public sealed class FacebookCommentsWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookCommentsWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookCommentsWidget();
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("MobileProperty").Should().BeNull();
      widget.GetPropertyValue<string>("OrderProperty").Should().BeNull();
      widget.GetPropertyValue<byte?>("PostsProperty").Should().BeNull();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookCommentsWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookCommentsWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new FacebookCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookCommentsWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Mobile(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mobile_Method()
  {
    using (new AssertionScope())
    {
      new FacebookCommentsWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool mobile, IFacebookCommentsWidget widget) => widget.Mobile(mobile).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("MobileProperty").Should().Be(mobile);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Order(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Order_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookCommentsWidget().Order(null)).ThrowExactly<ArgumentNullException>().WithParameterName("order");
      AssertionExtensions.Should(() => new FacebookCommentsWidget().Order(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("order");

      new FacebookCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string order, IFacebookCommentsWidget widget) => widget.Order(order).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("OrderProperty").Should().Be(order);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Posts(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Posts_Method()
  {
    using (new AssertionScope())
    {
      new FacebookCommentsWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte count, IFacebookCommentsWidget widget) => widget.Posts(count).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("PostsProperty").Should().Be(count);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookCommentsWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookCommentsWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new FacebookCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IFacebookCommentsWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookCommentsWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookCommentsWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new FacebookCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookCommentsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookCommentsWidget());
      Validate(Attributes.FacebookCommentsWidget());
    }

    return;

    static void Validate(IFacebookCommentsWidget original)
    {
      var clone = original.Clone<IFacebookCommentsWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookCommentsWidget(), """<div class="fb-comments"></div>""");
      Validate(new FacebookCommentsWidget().Url("url").Posts(1).Width("width").ColorScheme(FacebookColorScheme.Dark).Mobile(true).Order(FacebookCommentsOrder.ReverseTime), """<div class="fb-comments" data-colorscheme="dark" data-href="url" data-mobile="true" data-num-posts="1" data-order-by="reverse_time" data-width="width"></div>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      if (html.IsUnset())
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