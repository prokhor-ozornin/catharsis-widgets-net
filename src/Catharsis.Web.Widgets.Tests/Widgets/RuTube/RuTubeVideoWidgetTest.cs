using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RuTubeVideoWidget"/>.</para>
/// </summary>
public sealed class RuTubeVideoWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="RuTubeVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(RuTubeVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IRuTubeVideoWidget>();

    using (new AssertionScope())
    {
      var widget = new RuTubeVideoWidget();
      widget.GetPropertyValue<string>("IdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new RuTubeVideoWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new RuTubeVideoWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new RuTubeVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IRuTubeVideoWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new RuTubeVideoWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new RuTubeVideoWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new RuTubeVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IRuTubeVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new RuTubeVideoWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new RuTubeVideoWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new RuTubeVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IRuTubeVideoWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="RuTubeVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new RuTubeVideoWidget());
      Validate(new RuTubeVideoWidget().Id("id").Height("height"));
      Validate(new RuTubeVideoWidget().Id("id").Width("width"));
      Validate(new RuTubeVideoWidget().Height("height").Width("width"));
      Validate(new RuTubeVideoWidget().Id("id").Height("height").Width("width"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" scrolling="no" src="http://rutube.ru/embed/id" webkitallowfullscreen="true" width="width"></iframe>""");
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