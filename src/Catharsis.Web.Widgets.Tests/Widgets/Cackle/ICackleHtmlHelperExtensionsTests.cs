using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="ICackleWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class CackleWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ICackleWidgetsCreatorExtensions.Comments(ICackleWidgetsCreator, Action{ICackleCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ICackleWidgetsCreatorExtensions.Comments(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new CackleWidgetsCreator().Comments(null));

    Assert.Equal(new CackleWidgetsCreator().Comments().ToHtml(), new CackleWidgetsCreator().Comments(x => { }));
    Assert.Equal(new CackleWidgetsCreator().Comments().Account("account").ToHtml(), new CackleWidgetsCreator().Comments(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ICackleWidgetsCreatorExtensions.CommentsCount(ICackleWidgetsCreator, Action{ICackleCommentsCountWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void CommentsCount_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ICackleWidgetsCreatorExtensions.CommentsCount(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new CackleWidgetsCreator().CommentsCount(null));

    Assert.Equal(new CackleWidgetsCreator().CommentsCount().ToHtml(), new CackleWidgetsCreator().CommentsCount(x => { }));
    Assert.Equal(new CackleWidgetsCreator().CommentsCount().Account("account").ToHtml(), new CackleWidgetsCreator().CommentsCount(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ICackleWidgetsCreatorExtensions.LatestComments(ICackleWidgetsCreator, Action{ICackleLatestCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void LatestComments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ICackleWidgetsCreatorExtensions.LatestComments(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new CackleWidgetsCreator().LatestComments(null));

    Assert.Equal(new CackleWidgetsCreator().LatestComments().ToHtml(), new CackleWidgetsCreator().LatestComments(x => { }));
    Assert.Equal(new CackleWidgetsCreator().LatestComments().Account("account").ToHtml(), new CackleWidgetsCreator().LatestComments(x => x.Account("account")));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ICackleWidgetsCreatorExtensions.Login(ICackleWidgetsCreator, Action{ICackleLoginWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Login_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ICackleWidgetsCreatorExtensions.Login(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new CackleWidgetsCreator().Login(null));

    Assert.Equal(new CackleWidgetsCreator().Login().ToHtml(), new CackleWidgetsCreator().Login(x => { }));
    Assert.Equal(new CackleWidgetsCreator().Login().Account("account").ToHtml(), new CackleWidgetsCreator().Login(x => x.Account("account")));
  }
}