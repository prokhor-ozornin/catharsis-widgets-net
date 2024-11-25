using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IShare42WidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class IShare42WidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IShare42WidgetsCreatorExtensions.Panel(IShare42WidgetsCreator, Action{IShare42PanelWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Panel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IShare42WidgetsCreatorExtensions.Panel(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new Share42WidgetsCreator().Panel(null));

    Assert.Equal(new Share42WidgetsCreator().Panel().ToHtml(), new Share42WidgetsCreator().Panel(_ => { }));
    Assert.Equal(new Share42WidgetsCreator().Panel().Id("id").ToHtml(), new Share42WidgetsCreator().Panel(x => x.Id("id")));
  }
}