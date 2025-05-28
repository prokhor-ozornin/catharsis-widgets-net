using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;
using Catharsis.Fixture;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisMapWidgetTest : Test
{
  private IDoubleGisMapWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public DoubleGisMapWidgetTest() => Widget = Fixture<IDoubleGisMapWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisMapWidget>();

    using (new AssertionScope())
    {
      var widget = new DoubleGisContactsMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisMapWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new DoubleGisMapWidget());
      Test(Fixture<DoubleGisMapWidget>.Create());
    }

    return;

    static void Test(IDoubleGisMapWidget original)
    {
      var clone = original.Clone<IDoubleGisMapWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new DoubleGisMapWidget());
      Test(Fixture<DoubleGisMapWidget>.Create());
    }

    return;

    static void Test(IDoubleGisMapWidget widget, params string[] html)
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