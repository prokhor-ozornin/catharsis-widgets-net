using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookLikeButtonWidget"/>.</para>
/// </summary>
public sealed class FacebookLikeButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookLikeButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("FacesProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("KidsMode").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TrackLabel").Should().BeNull();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("VerbProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new FacebookLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string scheme, IFacebookLikeButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Faces(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    using (new AssertionScope())
    {
      new FacebookLikeButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeButtonWidget widget) => widget.Faces(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("FacesProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.KidsMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void KidsMode_Method()
  {
    using (new AssertionScope())
    {
      new FacebookLikeButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeButtonWidget widget) => widget.KidsMode(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("KidsModeProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Layout(null)).ThrowExactly<ArgumentNullException>().WithParameterName("layout");
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("layout");

      new FacebookLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string layout, IFacebookLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutProperty").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().TrackLabel(null)).ThrowExactly<ArgumentNullException>().WithParameterName("label");
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().TrackLabel(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("label");

      new FacebookLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string label, IFacebookLikeButtonWidget widget) => widget.TrackLabel(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TrackLabelProperty").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new FacebookLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IFacebookLikeButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Verb(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Verb(null)).ThrowExactly<ArgumentNullException>().WithParameterName("verb");
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Verb(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("verb");

      new FacebookLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string verb, IFacebookLikeButtonWidget widget) => widget.Verb(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("VerbProperty").Should().Be(verb);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookLikeButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new FacebookLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookLikeButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookLikeButtonWidget(), """<div class="fb-like"></div>""");
      Validate(new FacebookLikeButtonWidget().Url("url"), """<div class="fb-like" data-href="url"></div>""");
      Validate(new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Recommend).ColorScheme(FacebookColorScheme.Dark).Url("url").KidsMode(true).Layout(FacebookButtonLayout.BoxCount).TrackLabel("trackLabel").Faces(true).Width("width"), """<div class="fb-like" data-action="recommend" data-colorscheme="dark" data-href="url" data-kid-directed-site="true" data-layout="box_count" data-ref="trackLabel" data-show-faces="true" data-width="width"></div>""");
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