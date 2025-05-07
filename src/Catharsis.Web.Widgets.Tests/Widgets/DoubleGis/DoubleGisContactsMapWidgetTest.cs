using AutoFixture;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisContactsMapWidget"/>.</para>
/// </summary>
public sealed class DoubleGisContactsMapWidgetTest : Test
{
  private IDoubleGisContactsMapWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public DoubleGisContactsMapWidgetTest() => Widget = Fixture.Create<IDoubleGisContactsMapWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisContactsMapWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisContactsMapWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDoubleGisContactsMapWidget>();

    using (new AssertionScope())
    {
      var widget = new DoubleGisContactsMapWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisContactsMapWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new DoubleGisContactsMapWidget());
      Validate(Fixture.Create<IDoubleGisContactsMapWidget>());
    }

    return;

    static void Validate(IDoubleGisContactsMapWidget original)
    {
      var clone = original.Clone<IDoubleGisContactsMapWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisContactsMapWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new DoubleGisContactsMapWidget());
      Validate(Fixture.Create<IDoubleGisContactsMapWidget>());
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