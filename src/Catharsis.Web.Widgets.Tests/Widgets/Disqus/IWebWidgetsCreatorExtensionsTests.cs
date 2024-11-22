using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Disqus(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Disqus_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Disqus(null));

    widgets.Disqus().Should().BeOfType<DisqusWidgetsCreator>().And.BeSameAs(widgets.Disqus());
  }
}