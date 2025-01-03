using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisWidgetsCreator"/>.</para>
/// </summary>
public sealed class DoubleGisWidgetsCreatorTests : ClassTest<DoubleGisWidgetsCreator>
{
  private readonly IDoubleGisWidgetsCreator widgets = Widgets.Create.DoubleGis();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IDoubleGisWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisWidgetsCreator.ContactsMap()"/> method.</para>
  /// </summary>
  [Fact]
  public void ContactsMap_Method()
  {
    widgets.ContactsMap().Should().BeOfType<DoubleGisContactsMapWidget>().And.NotBeSameAs(widgets.ContactsMap());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisWidgetsCreator.Map()"/> method.</para>
  /// </summary>
  [Fact]
  public void Map_Method()
  {
    widgets.Map().Should().BeOfType<DoubleGisMapWidget>().And.NotBeSameAs(widgets.Map());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DoubleGisWidgetsCreator.MiniMap()"/> method.</para>
  /// </summary>
  [Fact]
  public void MiniMap_Method()
  {
    widgets.MiniMap().Should().BeOfType<DoubleGisMiniMapWidget>().And.NotBeSameAs(widgets.MiniMap());
  }
}