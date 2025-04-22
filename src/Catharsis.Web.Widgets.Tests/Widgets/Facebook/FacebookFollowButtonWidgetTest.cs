using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookFollowButtonWidget"/>.</para>
/// </summary>
public sealed class FacebookFollowButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookFollowButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookFollowButtonWidget();
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("FacesProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("KidsModeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutProperty").Should().BeNull();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new FacebookFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookFollowButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Faces(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    using (new AssertionScope())
    {
      new FacebookFollowButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IFacebookFollowButtonWidget widget) => widget.Faces(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("FacesProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new FacebookFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IFacebookFollowButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.KidsMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void KidsMode_Method()
  {
    using (new AssertionScope())
    {
      new FacebookFollowButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IFacebookFollowButtonWidget widget) => widget.KidsMode(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("KidsModeProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Layout(null)).ThrowExactly<ArgumentNullException>().WithParameterName("layout");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("layout");

      new FacebookFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string layout, IFacebookFollowButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutProperty").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new FacebookFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IFacebookFollowButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new FacebookFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookFollowButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookFollowButtonWidget());
      Validate(new FacebookFollowButtonWidget().Url("url"), """<div class="fb-follow" data-href="url"></div>""");
      Validate(new FacebookFollowButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).KidsMode(true).Layout(FacebookButtonLayout.BoxCount).Faces(true).Width("width").Height("height"), """<div class="fb-follow" data-colorscheme="dark" data-height="height" data-href="url" data-kid-directed-site="true" data-layout="box_count" data-show-faces="true" data-width="width"></div>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

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