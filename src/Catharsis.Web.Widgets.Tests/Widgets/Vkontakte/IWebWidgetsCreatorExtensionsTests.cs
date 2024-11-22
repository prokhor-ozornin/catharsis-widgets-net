using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Vkontakte(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Vkontakte_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Vkontakte(null));

    Assert.NotNull(html.Vkontakte());
    Assert.True(ReferenceEquals(html.Vkontakte(), html.Vkontakte()));
  }
}