using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ICackleHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class ICackleHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ICackleHtmlHelperExtensions.Comments(ICackleHtmlHelper, Action{ICackleCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ICackleHtmlHelperExtensions.Comments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new CackleHtmlHelper().Comments(null));

      Assert.Equal(new CackleHtmlHelper().Comments().ToHtmlString(), new CackleHtmlHelper().Comments(x => { }));
      Assert.Equal(new CackleHtmlHelper().Comments().Account("account").ToHtmlString(), new CackleHtmlHelper().Comments(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ICackleHtmlHelperExtensions.CommentsCount(ICackleHtmlHelper, Action{ICackleCommentsCountWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void CommentsCount_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ICackleHtmlHelperExtensions.CommentsCount(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new CackleHtmlHelper().CommentsCount(null));

      Assert.Equal(new CackleHtmlHelper().CommentsCount().ToHtmlString(), new CackleHtmlHelper().CommentsCount(x => { }));
      Assert.Equal(new CackleHtmlHelper().CommentsCount().Account("account").ToHtmlString(), new CackleHtmlHelper().CommentsCount(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ICackleHtmlHelperExtensions.LatestComments(ICackleHtmlHelper, Action{ICackleLatestCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void LatestComments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ICackleHtmlHelperExtensions.LatestComments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new CackleHtmlHelper().LatestComments(null));

      Assert.Equal(new CackleHtmlHelper().LatestComments().ToHtmlString(), new CackleHtmlHelper().LatestComments(x => { }));
      Assert.Equal(new CackleHtmlHelper().LatestComments().Account("account").ToHtmlString(), new CackleHtmlHelper().LatestComments(x => x.Account("account")));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ICackleHtmlHelperExtensions.Login(ICackleHtmlHelper, Action{ICackleLoginWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Login_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ICackleHtmlHelperExtensions.Login(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new CackleHtmlHelper().Login(null));

      Assert.Equal(new CackleHtmlHelper().Login().ToHtmlString(), new CackleHtmlHelper().Login(x => { }));
      Assert.Equal(new CackleHtmlHelper().Login().Account("account").ToHtmlString(), new CackleHtmlHelper().Login(x => x.Account("account")));
    }
  }
}