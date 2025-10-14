using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Test set for class <see cref="DisqusWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="DisqusWidgetsCreator"/>
public sealed class DisqusWidgetsCreatorTest : Test
{
  private IDisqusWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.Disqus();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DoubleGisWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(DoubleGisWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IDoubleGisWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Widgets.Comments().Should().BeOfType<DisqusCommentsWidget>().And.NotBeSameAs(Widgets.Comments());
  }
}