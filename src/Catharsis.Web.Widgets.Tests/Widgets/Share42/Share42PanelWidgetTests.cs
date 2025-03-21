using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Share42PanelWidget"/>.</para>
/// </summary>
public sealed class Share42PanelWidgetTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="Share42PanelWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(Share42PanelWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IShare42PanelWidget>();

    var widget = new Share42PanelWidget();
    widget.Size().Should().Be((byte) Share42PanelSize.Size24);
    widget.Direction().Should().Be(Share42PanelDirection.Horizontal);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42PanelWidget.Direction(Share42PanelDirection)"/> method.</para>
  /// </summary>
  [Fact]
  public void Direction_Method()
  {
    using (new AssertionScope())
    {
      var widget = new Share42PanelWidget();
      Enum.GetValues<Share42PanelDirection>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(Share42PanelDirection direction, IShare42PanelWidget widget)
    {
      widget.Direction(direction).Should().BeSameAs(widget);
      widget.Direction().Should().Be(direction);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42PanelWidget.Size(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      var widget = new Share42PanelWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte size, IShare42PanelWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42PanelWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      throw new NotImplementedException();
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