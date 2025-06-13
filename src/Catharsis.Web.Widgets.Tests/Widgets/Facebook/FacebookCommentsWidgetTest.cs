using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookCommentsWidget"/>.</para>
/// </summary>
public sealed class FacebookCommentsWidgetTest : Test
{
  private IFacebookCommentsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookCommentsWidgetTest() => Widget = Fixture<IFacebookCommentsWidget>.Create();

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
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("MobileValue").Should().BeNull();
      widget.GetPropertyValue<string>("OrderValue").Should().BeNull();
      widget.GetPropertyValue<byte?>("PostsValue").Should().BeNull();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
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

      new[] { Fixture<string>.Create() }.ForEach(scheme => Test(scheme, Widget));
    }

    return;

    static void Test(string scheme, IFacebookCommentsWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Mobile(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mobile_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(mobile => Test(mobile, Widget));
    }

    return;

    static void Test(bool mobile, IFacebookCommentsWidget widget) => widget.Mobile(mobile).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("MobileValue").Should().Be(mobile);
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

      new[] { Fixture<string>.Create() }.ForEach(order => Test(order, Widget));
    }

    return;

    static void Test(string order, IFacebookCommentsWidget widget) => widget.Order(order).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("OrderValue").Should().Be(order);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Posts(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Posts_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(count => Test(count, Widget));
    }

    return;

    static void Test(byte count, IFacebookCommentsWidget widget) => widget.Posts(count).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("PostsValue").Should().Be(count);
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

      new[] { Fixture<string>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(string url, IFacebookCommentsWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
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

      new[] { Fixture<string>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(string width, IFacebookCommentsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookCommentsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookCommentsWidget());
      Test(Fixture<FacebookCommentsWidget>.Create());
    }

    return;

    static void Test(IFacebookCommentsWidget original)
    {
      var clone = original.Clone<IFacebookCommentsWidget>();

      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
      clone.GetPropertyValue<bool?>("MobileValue").Should().Be(original.GetPropertyValue<bool?>("MobileValue"));
      clone.GetPropertyValue<string>("OrderValue").Should().Be(original.GetPropertyValue<string>("OrderValue"));
      clone.GetPropertyValue<byte?>("PostsValue").Should().Be(original.GetPropertyValue<byte?>("PostsValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
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
      Test(new FacebookCommentsWidget(), """<div class="fb-comments"></div>""");
      Test(new FacebookCommentsWidget().Url("url").Posts(1).Width("width").ColorScheme(FacebookColorScheme.Dark).Mobile(true).Order(FacebookCommentsOrder.ReverseTime), """<div class="fb-comments" data-colorscheme="dark" data-href="url" data-mobile="true" data-num-posts="1" data-order-by="reverse_time" data-width="width"></div>""");
      Test(Fixture<FacebookCommentsWidget>.Create());
    }

    return;

    static void Test(IFacebookCommentsWidget widget, params string[] html)
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