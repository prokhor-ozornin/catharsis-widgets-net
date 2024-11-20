using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IIntenseDebateWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IIntenseDebateWidgetsCreatorExtensionsTests : UnitTest
{
  private readonly IIntenseDebateWidgetsCreator widgets = Widgets.Web.IntenseDebate();

  /// <summary>
  ///   <para>Performs testing of <see cref="IIntenseDebateWidgetsCreatorExtensions.Comments(IIntenseDebateWidgetsCreator, Action{IIntenseDebateCommentsWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Comments_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IIntenseDebateWidgetsCreatorExtensions.Comments(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => widgets.Comments(null));

    Assert.Equal(widgets.Comments().ToHtml(), widgets.Comments(_ => { }));
    Assert.Equal(widgets.Comments().Account("account").ToHtml(), widgets.Comments(x => x.Account("account")));
  }
}