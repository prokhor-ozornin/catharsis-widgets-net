using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="CackleWidgetsCreator"/>.</para>
/// </summary>
public sealed class CackleWidgetsCreatorTests : ClassTest<CackleWidgetsCreator>
{
  private readonly ICackleWidgetsCreator widgets = Widgets.Web.Cackle();

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.Comments()"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.False(ReferenceEquals(widgets.Comments(), widgets.Comments()));
    Assert.True(widgets.Comments() is CackleCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.CommentsCount()"/> method.</para>
  /// </summary>
  [Fact]
  public void CommentsCount_Method()
  {
    Assert.False(ReferenceEquals(widgets.CommentsCount(), widgets.CommentsCount()));
    Assert.True(widgets.CommentsCount() is CackleCommentsCountWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.LatestComments()"/> method.</para>
  /// </summary>
  [Fact]
  public void LatestComments_Method()
  {
    Assert.False(ReferenceEquals(widgets.LatestComments(), widgets.LatestComments()));
    Assert.True(widgets.LatestComments() is CackleLatestCommentsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleWidgetsCreator.Login()"/> method.</para>
  /// </summary>
  [Fact]
  public void Login_Method()
  {
    Assert.False(ReferenceEquals(widgets.Login(), widgets.Login()));
    Assert.True(widgets.Login() is CackleLoginWidget);
  }
}