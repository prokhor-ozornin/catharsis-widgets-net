using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DoubleGisWidgetsCreator"/>.</para>
/// </summary>
public sealed class DoubleGisWidgetsCreatorTests : ClassTest<DoubleGisWidgetsCreator>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DoubleGisWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IDoubleGisWidgetsCreator>();
  }
}