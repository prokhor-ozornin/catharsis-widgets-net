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

      Assert.True(new CackleHtmlHelper().Comments(x => { }) == new CackleHtmlHelper().Comments().ToHtmlString());
      Assert.True(new CackleHtmlHelper().Comments(x => x.Account("account")) == new CackleHtmlHelper().Comments().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ICackleHtmlHelperExtensions.CommentsCount(ICackleHtmlHelper, Action{ICackleCommentsCountWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void CommentsCount_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ICackleHtmlHelperExtensions.CommentsCount(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new CackleHtmlHelper().CommentsCount(null));

      Assert.True(new CackleHtmlHelper().CommentsCount(x => { }) == new CackleHtmlHelper().CommentsCount().ToHtmlString());
      Assert.True(new CackleHtmlHelper().CommentsCount(x => x.Account("account")) == new CackleHtmlHelper().CommentsCount().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ICackleHtmlHelperExtensions.LatestComments(ICackleHtmlHelper, Action{ICackleLatestCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void LatestComments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ICackleHtmlHelperExtensions.LatestComments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new CackleHtmlHelper().LatestComments(null));

      Assert.True(new CackleHtmlHelper().LatestComments(x => { }) == new CackleHtmlHelper().LatestComments().ToHtmlString());
      Assert.True(new CackleHtmlHelper().LatestComments(x => x.Account("account")) == new CackleHtmlHelper().LatestComments().Account("account").ToHtmlString());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ICackleHtmlHelperExtensions.Login(ICackleHtmlHelper, Action{ICackleLoginWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Login_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ICackleHtmlHelperExtensions.Login(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new CackleHtmlHelper().Login(null));

      Assert.True(new CackleHtmlHelper().Login(x => { }) == new CackleHtmlHelper().Login().ToHtmlString());
      Assert.True(new CackleHtmlHelper().Login(x => x.Account("account")) == new CackleHtmlHelper().Login().Account("account").ToHtmlString());
    }
  }
}