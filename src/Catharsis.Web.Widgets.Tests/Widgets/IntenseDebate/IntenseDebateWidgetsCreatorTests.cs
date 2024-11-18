using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateWidgetsCreator"/>.</para>
/// </summary>
public sealed class IntenseDebateWidgetsCreatorTests
{
  private readonly IIntenseDebateWidgetsCreator widgets = Widgets.Web.IntenseDebate();

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(widgets.Comments(), widgets.Comments()));
    Assert.True(widgets.Comments() is IntenseDebateCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Link()"/> method.</para>
  /// </summary>
  [Fact]
  public void Link_Method()
  {
    Assert.False(ReferenceEquals(widgets.Link(), widgets.Link()));
    Assert.True(widgets.Link() is IntenseDebateLinkWidget);
  }
}