using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Disqus(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Disqus_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Disqus(null));

    Assert.NotNull(html.Disqus());
    Assert.True(ReferenceEquals(html.Disqus(), html.Disqus()));
  }
}