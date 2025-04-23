using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GooglePlusOneButtonWidget"/>.</para>
/// </summary>
public sealed class GooglePlusOneButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GooglePlusOneButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GooglePlusOneButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGooglePlusOneButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new GooglePlusOneButtonWidget();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("SizeProperty").Should().BeNull();
      widget.GetPropertyValue<string>("AlignmentProperty").Should().BeNull();
      widget.GetPropertyValue<string>("AnnotationProperty").Should().BeNull();
      widget.GetPropertyValue<string>("CallbackProperty").Should().BeNull();
      widget.GetPropertyValue<bool?>("RecommendationsProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new GooglePlusOneButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IGooglePlusOneButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new GooglePlusOneButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IGooglePlusOneButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Size(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new GooglePlusOneButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string size, IGooglePlusOneButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Alignment(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Alignment_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Alignment(null)).ThrowExactly<ArgumentNullException>().WithParameterName("alignment");
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Alignment(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("alignment");

      new GooglePlusOneButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string alignment, IGooglePlusOneButtonWidget widget) => widget.Alignment(alignment).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AlignmentProperty").Should().Be(alignment);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Annotation(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Annotation_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Annotation(null)).ThrowExactly<ArgumentNullException>().WithParameterName("annotation");
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Annotation(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("annotation");

      new GooglePlusOneButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string annotation, IGooglePlusOneButtonWidget widget) => widget.Annotation(annotation).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AnnotationProperty").Should().Be(annotation);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Callback(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Callback_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Callback(null)).ThrowExactly<ArgumentNullException>().WithParameterName("callback");
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Callback(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("callback");

      new GooglePlusOneButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string callback, IGooglePlusOneButtonWidget widget) => widget.Callback(callback).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CallbackProperty").Should().Be(callback);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Recommendations(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    using (new AssertionScope())
    {
      new GooglePlusOneButtonWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IGooglePlusOneButtonWidget widget) => widget.Recommendations(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("RecommendationsProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new GooglePlusOneButtonWidget(), "<g:plusone></g:plusone>");
      Validate(new GooglePlusOneButtonWidget().Url("url").Size(GooglePlusOneButtonSize.Small).Annotation(GooglePlusOneButtonAnnotation.None).Width("width").Alignment(GooglePlusOneButtonAlignment.Left).Callback("callback").Recommendations(true), """<g:plusone align="left" annotation="none" data-callback="callback" data-recommendations="true" href="url" size="small" width="width"></g:plusone>""");
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