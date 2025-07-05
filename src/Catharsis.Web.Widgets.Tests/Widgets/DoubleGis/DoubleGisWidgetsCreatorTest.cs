using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisWidgetsCreator"/>.</para>
/// </summary>
public sealed class DoubleGisWidgetsCreatorTest : Test
{
  private IDoubleGisWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.DoubleGis();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(DoubleGisWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IDoubleGisWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisWidgetsCreator.ContactsMap()"/> method.</para>
  /// </summary>
  [Fact]
  public void ContactsMap_Method()
  {
    Widgets.ContactsMap().Should().BeOfType<DoubleGisContactsMapWidget>().And.NotBeSameAs(Widgets.ContactsMap());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisWidgetsCreator.Map()"/> method.</para>
  /// </summary>
  [Fact]
  public void Map_Method()
  {
    Widgets.Map().Should().BeOfType<DoubleGisMapWidget>().And.NotBeSameAs(Widgets.Map());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisWidgetsCreator.MiniMap()"/> method.</para>
  /// </summary>
  [Fact]
  public void MiniMap_Method()
  {
    Widgets.MiniMap().Should().BeOfType<DoubleGisMiniMapWidget>().And.NotBeSameAs(Widgets.MiniMap());
  }
}