using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IntenseDebateHtmlHelper"/>.</para>
  /// </summary>
  public sealed class IntenseDebateHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateHtmlHelper.Comments()"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.False(ReferenceEquals(this.html.IntenseDebate().Comments(), this.html.IntenseDebate().Comments()));
      Assert.True(this.html.IntenseDebate().Comments() is IntenseDebateCommentsWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateHtmlHelper.Link()"/> method.</para>
    /// </summary>
    [Fact]
    public void Link_Method()
    {
      Assert.False(ReferenceEquals(this.html.IntenseDebate().Link(), this.html.IntenseDebate().Link()));
      Assert.True(this.html.IntenseDebate().Link() is IntenseDebateLinkWidget);
    }
  }
}