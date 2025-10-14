using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IGooglePlusOneButtonWidgetExtensions"/>.</para>
/// </summary>
/// <seealso cref="IGooglePlusOneButtonWidgetExtensions"/>
public sealed class IGooglePlusOneButtonWidgetExtensionsTest : Test
{
  private IGooglePlusOneButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IGooglePlusOneButtonWidgetExtensionsTest() => Widget = Fixture<IGooglePlusOneButtonWidget>.Create();

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

      new[] { Fixture<Uri>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(Uri url, IGooglePlusOneButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url.ToString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGooglePlusOneButtonWidgetExtensions.Width(IGooglePlusOneButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGooglePlusOneButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(short width, IGooglePlusOneButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
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

      Enum.GetValues<GooglePlusOneButtonSize>().ForEach(size => Test(size, Widget));
    }

    return;

    static void Test(GooglePlusOneButtonSize size, IGooglePlusOneButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size.ToString().ToLowerInvariant());
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

      Enum.GetValues<GooglePlusOneButtonAlignment>().ForEach(alignment => Test(alignment, Widget));
    }

    return;

    static void Test(GooglePlusOneButtonAlignment alignment, IGooglePlusOneButtonWidget widget) => widget.Alignment(alignment).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AlignmentValue").Should().Be(alignment.ToString().ToLowerInvariant());
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

      Enum.GetValues<GooglePlusOneButtonAnnotation>().ForEach(annotation => Test(annotation, Widget));
    }

    return;

    static void Test(GooglePlusOneButtonAnnotation annotation, IGooglePlusOneButtonWidget widget) => widget.Annotation(annotation).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AnnotationValue").Should().Be(annotation.ToString().ToLowerInvariant());
  }
}