using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IDisqusHtmlHelperExtensions"/>.</para>
/// </summary>
public sealed class IDisqusHtmlHelperExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IDisqusHtmlHelperExtensions.Comments(IDisqusWidgetsCreator, Action{IDisqusCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IDisqusHtmlHelperExtensions.Comments(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new DisqusWidgetsCreator().Comments(null));

    Assert.Equal(new DisqusWidgetsCreator().Comments().ToHtml(), new DisqusWidgetsCreator().Comments(x => { }));
    Assert.Equal(new DisqusWidgetsCreator().Comments().Account("account").ToHtml(), new DisqusWidgetsCreator().Comments(x => x.Account("account")));
  }
}