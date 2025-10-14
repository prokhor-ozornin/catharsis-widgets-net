using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Share42PanelWidget"/>.</para>
/// </summary>
/// <seealso cref="Share42PanelWidget"/>
public sealed class Share42PanelWidgetTest : Test
{
  private IShare42PanelWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public Share42PanelWidgetTest() => Widget = Fixture<IShare42PanelWidget>.Create();

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
      widget.GetPropertyValue<byte>("SizeValue").Should().Be((byte) Share42PanelSize.Size24);
      widget.GetPropertyValue<Share42PanelDirection>("DirectionValue").Should().Be(Share42PanelDirection.Horizontal);
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
      Enum.GetValues<Share42PanelDirection>().ForEach(direction => Test(direction, Widget));
    }

    return;

    static void Test(Share42PanelDirection direction, IShare42PanelWidget widget) => widget.Direction(direction).Should().BeSameAs(widget).And.Subject.GetPropertyValue<Share42PanelDirection>("DirectionValue").Should().Be(direction);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42PanelWidget.Size(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(size => Test(size, Widget));
    }

    return;

    static void Test(byte size, IShare42PanelWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("SizeValue").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Share42PanelWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new Share42PanelWidget());
      Test(Fixture<Share42PanelWidget>.Create());
    }

    return;

    static void Test(IShare42PanelWidget original)
    {
      var clone = original.Clone<IShare42PanelWidget>();

      clone.GetPropertyValue<Share42PanelDirection>("DirectionValue").Should().Be(original.GetPropertyValue<Share42PanelDirection>("DirectionValue"));
      clone.GetPropertyValue<byte>("SizeValue").Should().Be(original.GetPropertyValue<byte>("SizeValue"));
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
      Test(Fixture<Share42PanelWidget>.Create());
      throw new NotImplementedException();
    }

    return;

    static void Test(IShare42PanelWidget widget, params string[] html)
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