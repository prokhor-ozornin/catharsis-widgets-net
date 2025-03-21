using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookLikeBoxWidget"/>.</para>
/// </summary>
public sealed class FacebookLikeBoxWidgetTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookLikeBoxWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookLikeBoxWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookLikeBoxWidget>();

    var widget = new FacebookLikeBoxWidget();
    widget.Border().Should().BeNull();
    widget.ColorScheme().Should().BeNull();
    widget.Faces().Should().BeNull();
    widget.Header().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Stream().Should().BeNull();
    widget.Url().Should().BeNull();
    widget.Wall().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Border(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Border_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookLikeBoxWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeBoxWidget widget)
    {
      widget.Border(enabled).Should().BeSameAs(widget);
      widget.Border().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("scheme");

      var widget = new FacebookLikeBoxWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, IFacebookLikeBoxWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Faces(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookLikeBoxWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeBoxWidget widget)
    {
      widget.Faces(enabled).Should().BeSameAs(widget);
      widget.Faces().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Header(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookLikeBoxWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeBoxWidget widget)
    {
      widget.Header(enabled).Should().BeSameAs(widget);
      widget.Header().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("height");

      var widget = new FacebookLikeBoxWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IFacebookLikeBoxWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Stream(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Stream_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookLikeBoxWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeBoxWidget widget)
    {
      widget.Stream(enabled).Should().BeSameAs(widget);
      widget.Stream().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("url");

      var widget = new FacebookLikeBoxWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IFacebookLikeBoxWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Wall(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Wall_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookLikeBoxWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeBoxWidget widget)
    {
      widget.Wall(enabled).Should().BeSameAs(widget);
      widget.Wall().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("width");

      var widget = new FacebookLikeBoxWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookLikeBoxWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookLikeBoxWidget());
      Validate(new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070"), """<div class="fb-like-box" data-href="https://www.facebook.com/pages/Clear-Words/515749945120070"></div>""");
      Validate(new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Wall(true).Header(true).Border(true).Faces(true).Stream(true), """<div class="fb-like-box" data-colorscheme="dark" data-force-wall="true" data-header="true" data-height="height" data-href="https://www.facebook.com/pages/Clear-Words/515749945120070" data-show-border="true" data-show-faces="true" data-stream="true" data-width="width"></div>""");
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