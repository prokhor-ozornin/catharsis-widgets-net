using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateWidgetsCreator"/>.</para>
/// </summary>
public sealed class IntenseDebateWidgetsCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(this.html.IntenseDebate().Comments(), this.html.IntenseDebate().Comments()));
    Assert.True(this.html.IntenseDebate().Comments() is IntenseDebateCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateWidgetsCreator.Link()"/> method.</para>
  /// </summary>
  [Fact]
  public void Link_Method()
  {
    Assert.False(ReferenceEquals(this.html.IntenseDebate().Link(), this.html.IntenseDebate().Link()));
    Assert.True(this.html.IntenseDebate().Link() is IntenseDebateLinkWidget);
  }
}