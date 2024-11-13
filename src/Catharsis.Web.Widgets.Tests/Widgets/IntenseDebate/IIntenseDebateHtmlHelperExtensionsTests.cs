using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IIntenseDebateWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IntenseDebateWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IIntenseDebateWidgetsCreatorExtensions.Comments(IIntenseDebateWidgetsCreator, Action{IIntenseDebateCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IIntenseDebateWidgetsCreatorExtensions.Comments(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new IntenseDebateHtmlHelper().Comments(null));

    Assert.Equal(new IntenseDebateHtmlHelper().Comments().ToHtml(), new IntenseDebateHtmlHelper().Comments(x => { }));
    Assert.Equal(new IntenseDebateHtmlHelper().Comments().Account("account").ToHtml(), new IntenseDebateHtmlHelper().Comments(x => x.Account("account")));
  }
}