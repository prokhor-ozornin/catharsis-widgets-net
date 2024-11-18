using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IDisqusWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class DisqusWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IDisqusWidgetsCreatorExtensions.Comments(IDisqusWidgetsCreator, Action{IDisqusCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IDisqusWidgetsCreatorExtensions.Comments(null, _=> { }));
    Assert.Throws<ArgumentNullException>(() => new DisqusWidgetsCreator().Comments(null));

    Assert.Equal(new DisqusWidgetsCreator().Comments().ToHtml(), new DisqusWidgetsCreator().Comments(_ => { }));
    Assert.Equal(new DisqusWidgetsCreator().Comments().Account("account").ToHtml(), new DisqusWidgetsCreator().Comments(x => x.Account("account")));
  }
}