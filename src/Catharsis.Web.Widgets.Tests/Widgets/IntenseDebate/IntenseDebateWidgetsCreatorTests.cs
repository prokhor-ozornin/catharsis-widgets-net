using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateWidgetsCreator"/>.</para>
/// </summary>
public sealed class IntenseDebateWidgetsCreatorTests : ClassTest<IntenseDebateWidgetsCreator>
{
  private IIntenseDebateWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.IntenseDebate();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="IntenseDebateWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(IntenseDebateWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IIntenseDebateWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Widgets.Comments().Should().BeOfType<IntenseDebateCommentsWidget>().And.NotBeSameAs(Widgets.Comments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Link()"/> method.</para>
  /// </summary>
  [Fact]
  public void Link_Method()
  {
    Widgets.Link().Should().BeOfType<IntenseDebateLinkWidget>().And.NotBeSameAs(Widgets.Link());
  }
}