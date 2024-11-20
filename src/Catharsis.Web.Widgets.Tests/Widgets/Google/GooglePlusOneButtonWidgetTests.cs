using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="GooglePlusOneButtonWidget"/>.</para>
/// </summary>
public sealed class GooglePlusOneButtonWidgetTests : ClassTest<GooglePlusOneButtonWidget>
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
    Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Width(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Size(null));
    Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Size(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Alignment(null));
    Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Alignment(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Annotation(null));
    Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Annotation(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new GooglePlusOneButtonWidget().Callback(null));
    Assert.Throws<ArgumentException>(() => new GooglePlusOneButtonWidget().Callback(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Equal("<g:plusone></g:plusone>", new GooglePlusOneButtonWidget().ToString());
    Assert.Equal("""<g:plusone align="left" annotation="none" data-callback="callback" data-recommendations="true" href="url" size="small" width="width"></g:plusone>""", new GooglePlusOneButtonWidget().Url("url").Size(GooglePlusOneButtonSize.Small).Annotation(GooglePlusOneButtonAnnotation.None).Width("width").Alignment(GooglePlusOneButtonAlignment.Left).Callback("callback").Recommendations(true).ToString());
  }
}