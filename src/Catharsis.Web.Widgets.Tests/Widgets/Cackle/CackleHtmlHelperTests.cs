using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="CackleWidgetsCreator"/>.</para>
/// </summary>
public sealed class CackleWidgetsCreatorTests
{
  private readonly HtmlHelper html = new MockHtmlHelper();

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(this.html.Cackle().Comments(), this.html.Cackle().Comments()));
    Assert.True(this.html.Cackle().Comments() is CackleCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.CommentsCount()"/> method.</para>
  /// </summary>
  [Fact]
  public void CommentsCount_Method()
  {
    Assert.False(ReferenceEquals(this.html.Cackle().CommentsCount(), this.html.Cackle().CommentsCount()));
    Assert.True(this.html.Cackle().CommentsCount() is CackleCommentsCountWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.LatestComments()"/> method.</para>
  /// </summary>
  [Fact]
  public void LatestComments_Method()
  {
    Assert.False(ReferenceEquals(this.html.Cackle().LatestComments(), this.html.Cackle().LatestComments()));
    Assert.True(this.html.Cackle().LatestComments() is CackleLatestCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.Login()"/> method.</para>
  /// </summary>
  [Fact]
  public void Login_Method()
  {
    Assert.False(ReferenceEquals(this.html.Cackle().Login(), this.html.Cackle().Login()));
    Assert.True(this.html.Cackle().Login() is CackleLoginWidget);
  }
}