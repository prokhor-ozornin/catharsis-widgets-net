using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestPinWidget"/>.</para>
/// </summary>
public sealed class PinterestPinWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestPinWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestPinWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestPinWidget>();

    using (new AssertionScope())
    {
      var widget = new PinterestPinWidget();
      widget.GetPropertyValue<string>("IdProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestPinWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new PinterestPinWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new PinterestPinWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IPinterestPinWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestPinWidget());
      Validate(Attributes.PinterestPinWidget());
    }

    return;

    static void Validate(IPinterestPinWidget original)
    {
      var clone = original.Clone<IPinterestPinWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestPinWidget());
      Validate(new PinterestPinWidget().Id("id"), """<a data-pin-do="embedPin" href="http://www.pinterest.com/pin/id"></a>""");
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