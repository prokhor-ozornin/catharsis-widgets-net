using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IIntenseDebateHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class IIntenseDebateHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IIntenseDebateHtmlHelperExtensions.Comments(IIntenseDebateHtmlHelper, Action{IIntenseDebateCommentsWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Comments_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IIntenseDebateHtmlHelperExtensions.Comments(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateHtmlHelper().Comments(null));

      Assert.Equal(new IntenseDebateHtmlHelper().Comments().ToHtmlString(), new IntenseDebateHtmlHelper().Comments(x => { }));
      Assert.Equal(new IntenseDebateHtmlHelper().Comments().Account("account").ToHtmlString(), new IntenseDebateHtmlHelper().Comments(x => x.Account("account")));
    }
  }
}