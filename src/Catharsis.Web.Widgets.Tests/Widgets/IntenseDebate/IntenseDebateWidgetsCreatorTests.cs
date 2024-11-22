using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateWidgetsCreator"/>.</para>
/// </summary>
public sealed class IntenseDebateWidgetsCreatorTests : ClassTest<IntenseDebateWidgetsCreator>
{
  private readonly IIntenseDebateWidgetsCreator widgets = Widgets.Web.IntenseDebate();

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    widgets.Comments().Should().BeOfType<IntenseDebateCommentsWidget>().And.NotBeSameAs(widgets.Comments());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Link()"/> method.</para>
  /// </summary>
  [Fact]
  public void Link_Method()
  {
    widgets.Link().Should().BeOfType<IntenseDebateLinkWidget>().And.NotBeSameAs(widgets.Link());
  }
}