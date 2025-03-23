using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IGooglePlusOneButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IGooglePlusOneButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Url(IGooglePlusOneButtonWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Url(new GooglePlusOneButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      var widget = new GooglePlusOneButtonWidget();
      new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(Uri url, IGooglePlusOneButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("UrlProperty").Should().Be(url.ToString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Width(IGooglePlusOneButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new GooglePlusOneButtonWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IGooglePlusOneButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Size(IGooglePlusOneButtonWidget, GooglePlusOneButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new GooglePlusOneButtonWidget();
      Enum.GetValues<GooglePlusOneButtonSize>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(GooglePlusOneButtonSize size, IGooglePlusOneButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("SizeProperty").Should().Be(size.ToString().ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Alignment(IGooglePlusOneButtonWidget, GooglePlusOneButtonAlignment)"/> method.</para>
  /// </summary>
  [Fact]
  public void Alignment_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Alignment(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new GooglePlusOneButtonWidget();
      Enum.GetValues<GooglePlusOneButtonAlignment>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(GooglePlusOneButtonAlignment alignment, IGooglePlusOneButtonWidget widget)
    {
      widget.Alignment(alignment).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("AlignmentProperty").Should().Be(alignment.ToString().ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Annotation(IGooglePlusOneButtonWidget, GooglePlusOneButtonAnnotation)"/> method.</para>
  /// </summary>
  [Fact]
  public void Annotation_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Annotation(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new GooglePlusOneButtonWidget();
      Enum.GetValues<GooglePlusOneButtonAnnotation>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(GooglePlusOneButtonAnnotation annotation, IGooglePlusOneButtonWidget widget)
    {
      widget.Annotation(annotation).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("AnnotationProperty").Should().Be(annotation.ToString().ToLowerInvariant());
    }
  }
}