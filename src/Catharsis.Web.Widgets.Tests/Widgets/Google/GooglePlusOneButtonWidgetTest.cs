using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GooglePlusOneButtonWidget"/>.</para>
/// </summary>
public sealed class GooglePlusOneButtonWidgetTest : Test
{
  private IGooglePlusOneButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public GooglePlusOneButtonWidgetTest() => Widget = Fixture.Create<IGooglePlusOneButtonWidget>();

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
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("SizeValue").Should().BeNull();
      widget.GetPropertyValue<string>("AlignmentValue").Should().BeNull();
      widget.GetPropertyValue<string>("AnnotationValue").Should().BeNull();
      widget.GetPropertyValue<string>("CallbackValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("RecommendationsValue").Should().BeNull();
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string url, IGooglePlusOneButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string width, IGooglePlusOneButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string size, IGooglePlusOneButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string alignment, IGooglePlusOneButtonWidget widget) => widget.Alignment(alignment).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AlignmentValue").Should().Be(alignment);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string annotation, IGooglePlusOneButtonWidget widget) => widget.Annotation(annotation).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AnnotationValue").Should().Be(annotation);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string callback, IGooglePlusOneButtonWidget widget) => widget.Callback(callback).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CallbackValue").Should().Be(callback);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Recommendations(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IGooglePlusOneButtonWidget widget) => widget.Recommendations(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("RecommendationsValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new GooglePlusOneButtonWidget());
      Validate(Fixture.Create<IGooglePlusOneButtonWidget>());
    }

    return;

    static void Validate(IGooglePlusOneButtonWidget original)
    {
      var clone = original.Clone<IGooglePlusOneButtonWidget>();

      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("SizeValue").Should().Be(original.GetPropertyValue<string>("SizeValue"));
      clone.GetPropertyValue<string>("AlignmentValue").Should().Be(original.GetPropertyValue<string>("AlignmentValue"));
      clone.GetPropertyValue<string>("AnnotationValue").Should().Be(original.GetPropertyValue<string>("AnnotationValue"));
      clone.GetPropertyValue<string>("CallbackValue").Should().Be(original.GetPropertyValue<string>("CallbackValue"));
      clone.GetPropertyValue<bool?>("RecommendationsValue").Should().Be(original.GetPropertyValue<bool?>("RecommendationsValue"));
    }
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
      Validate(Fixture.Create<IGooglePlusOneButtonWidget>());
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