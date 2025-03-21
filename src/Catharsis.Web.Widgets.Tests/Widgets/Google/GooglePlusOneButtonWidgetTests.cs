using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GooglePlusOneButtonWidget"/>.</para>
/// </summary>
public sealed class GooglePlusOneButtonWidgetTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GooglePlusOneButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GooglePlusOneButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGooglePlusOneButtonWidget>();

    var widget = new GooglePlusOneButtonWidget();
    widget.Url().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Size().Should().BeNull();
    widget.Alignment().Should().BeNull();
    widget.Annotation().Should().BeNull();
    widget.Callback().Should().BeNull();
    widget.Recommendations().Should().BeNull();
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
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("url");

      var widget = new GooglePlusOneButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IGooglePlusOneButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
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
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("width");

      var widget = new GooglePlusOneButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IGooglePlusOneButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
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
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("size");

      var widget = new GooglePlusOneButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string size, IGooglePlusOneButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
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
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Alignment(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("alignment");

      var widget = new GooglePlusOneButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string alignment, IGooglePlusOneButtonWidget widget)
    {
      widget.Alignment(alignment).Should().BeSameAs(widget);
      widget.Alignment().Should().Be(alignment);
    }
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
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Annotation(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("annotation");

      var widget = new GooglePlusOneButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string annotation, IGooglePlusOneButtonWidget widget)
    {
      widget.Annotation(annotation).Should().BeSameAs(widget);
      widget.Annotation().Should().Be(annotation);
    }
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
      AssertionExtensions.Should(() => new GooglePlusOneButtonWidget().Callback(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("callback");

      var widget = new GooglePlusOneButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string callback, IGooglePlusOneButtonWidget widget)
    {
      widget.Callback(callback).Should().BeSameAs(widget);
      widget.Callback().Should().Be(callback);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GooglePlusOneButtonWidget.Recommendations(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    using (new AssertionScope())
    {
      var widget = new GooglePlusOneButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IGooglePlusOneButtonWidget widget)
    {
      widget.Recommendations(enabled).Should().BeSameAs(widget);
      widget.Recommendations().Should().Be(enabled);
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