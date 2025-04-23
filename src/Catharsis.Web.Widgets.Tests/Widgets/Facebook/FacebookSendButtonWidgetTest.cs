using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookSendButtonWidget"/>.</para>
/// </summary>
public sealed class FacebookSendButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookSendButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookSendButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookSendButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("KidsModeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TrackLabelProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new FacebookSendButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IFacebookSendButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new FacebookSendButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookSendButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new FacebookSendButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IFacebookSendButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new FacebookSendButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookSendButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.KidsMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void KidsMode_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookSendButtonWidget widget) => widget.KidsMode(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("KidsModeProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().TrackLabel(null)).ThrowExactly<ArgumentNullException>().WithParameterName("label");
      AssertionExtensions.Should(() => new FacebookSendButtonWidget().TrackLabel(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("label");

      new FacebookSendButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string label, IFacebookSendButtonWidget widget) => widget.TrackLabel(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TrackLabelProperty").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookSendButtonWidget(), """<div class="fb-send"></div>""");
      Validate(new FacebookSendButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).KidsMode(true).Width("width").Height("height").TrackLabel("trackLabel"), """<div class="fb-send" data-colorscheme="dark" data-height="height" data-href="url" data-kid-directed-site="true" data-ref="trackLabel" data-width="width"></div>""");
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