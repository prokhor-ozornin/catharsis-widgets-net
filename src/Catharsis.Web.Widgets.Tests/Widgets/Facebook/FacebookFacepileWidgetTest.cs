using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookFacePileWidget"/>.</para>
/// </summary>
public sealed class FacebookFacePileWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookFacePileWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookFacePileWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookFacePileWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      widget.GetPropertyValue<IEnumerable<string>>("ActionsProperty").Should().BeEmpty();
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<byte?>("MaxRows").Should().BeNull();
      widget.GetPropertyValue<string>("PhotoSize").Should().BeNull();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Actions(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("actions");

      new FacebookFacePileWidget().With(widget => new[] { Enumerable.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(IEnumerable<string> actions, IFacebookFacePileWidget widget) => widget.Actions(actions).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ActionsProperty").Should().Equal(actions);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new FacebookFacePileWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookFacePileWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new FacebookFacePileWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IFacebookFacePileWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.MaxRows(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxRows_Method()
  {
    using (new AssertionScope())
    {
      new FacebookFacePileWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte count, IFacebookFacePileWidget widget) => widget.MaxRows(count).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("MaxRowsProperty").Should().Be(count);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.PhotoSize(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PhotoSize_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().PhotoSize(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().PhotoSize(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new FacebookFacePileWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string size, IFacebookFacePileWidget widget) => widget.PhotoSize(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PhotoSizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new FacebookFacePileWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IFacebookFacePileWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new FacebookFacePileWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookFacePileWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookFacePileWidget(), """<div class="fb-facepile"></div>""");
      Validate(new FacebookFacePileWidget().Url("url").Actions("actions").PhotoSize(FacebookFacePilePhotoSize.Large).Width("width").Height("height").MaxRows(10).ColorScheme(FacebookColorScheme.Dark), """<div class="fb-facepile" data-action="actions" data-colorscheme="dark" data-height="height" data-href="url" data-max-rows="10" data-size="large" data-width="width"></div>""");
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