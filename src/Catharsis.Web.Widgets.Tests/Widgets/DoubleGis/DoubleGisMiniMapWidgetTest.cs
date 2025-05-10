using AutoFixture;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisMiniMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisMiniMapWidgetTest : Test
{
  private IDoubleGisMiniMapWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public DoubleGisMiniMapWidgetTest() => Widget = Fixture.Create<IDoubleGisMiniMapWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisMiniMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisMiniMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisMiniMapWidget>();

    using (new AssertionScope())
    {
      var widget = new DoubleGisMiniMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisMiniMapWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new DoubleGisMiniMapWidget());
      Test(Fixture.Create<DoubleGisMiniMapWidget>());
    }

    return;

    static void Test(IDoubleGisMiniMapWidget original)
    {
      var clone = original.Clone<IDoubleGisMiniMapWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisMiniMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new DoubleGisMiniMapWidget());
      Test(Fixture.Create<DoubleGisMiniMapWidget>());
    }

    return;

    static void Test(IDoubleGisMiniMapWidget widget, params string[] html)
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