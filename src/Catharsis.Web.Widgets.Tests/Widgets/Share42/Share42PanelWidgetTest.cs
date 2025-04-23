using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Share42PanelWidget"/>.</para>
/// </summary>
public sealed class Share42PanelWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="Share42PanelWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(Share42PanelWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IShare42PanelWidget>();

    using (new AssertionScope())
    {
      var widget = new Share42PanelWidget();
      widget.GetPropertyValue<byte>("SizeProperty").Should().Be((byte) Share42PanelSize.Size24);
      widget.GetPropertyValue<Share42PanelDirection>("DirectionProperty").Should().Be(Share42PanelDirection.Horizontal);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42PanelWidget.Direction(Share42PanelDirection)"/> method.</para>
  /// </summary>
  [Fact]
  public void Direction_Method()
  {
    using (new AssertionScope())
    {
      new Share42PanelWidget().With(widget => Enum.GetValues<Share42PanelDirection>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(Share42PanelDirection direction, IShare42PanelWidget widget) => widget.Direction(direction).Should().BeSameAs(widget).And.Subject.GetPropertyValue<Share42PanelDirection>("DirectionProperty").Should().Be(direction);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42PanelWidget.Size(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      new Share42PanelWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte size, IShare42PanelWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("SizeProperty").Should().Be(size);
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