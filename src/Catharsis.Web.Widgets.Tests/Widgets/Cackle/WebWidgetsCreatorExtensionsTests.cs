using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class WebWidgetsCreatorExtensionsTests
{
  private readonly IWebWidgetsCreator creator = Widgets.Web;

  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Cackle(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Cackle_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Cackle(null));

    Assert.NotNull(creator.Cackle());
    Assert.True(ReferenceEquals(creator.Cackle(), creator.Cackle()));
  }
}