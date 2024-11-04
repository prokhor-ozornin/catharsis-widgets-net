using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IDisqusHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IDisqusHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IDisqusHtmlHelperExtensions.Comments(IDisqusHtmlHelper, Action{IDisqusCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IDisqusHtmlHelperExtensions.Comments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new DisqusHtmlHelper().Comments(null));

      Assert.Equal(new DisqusHtmlHelper().Comments().ToHtmlString(), new DisqusHtmlHelper().Comments(x => { }));
      Assert.Equal(new DisqusHtmlHelper().Comments().Account("account").ToHtmlString(), new DisqusHtmlHelper().Comments(x => x.Account("account")));
    }
  }
}