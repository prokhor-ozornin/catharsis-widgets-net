using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestPinWidget"/>.</para>
/// </summary>
public sealed class PinterestPinWidgetTests : ClassTest<PinterestPinWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestPinWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestPinWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestPinWidget>();

    var widget = new PinterestPinWidget();
    widget.Id().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestPinWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new PinterestPinWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestPinWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IPinterestPinWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestPinWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new PinterestPinWidget().ToString());
    Assert.Equal("""<a data-pin-do="embedPin" href="http://www.pinterest.com/pin/id"></a>""", new PinterestPinWidget().Id("id").ToString());

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