using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Disqus(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Disqus_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Disqus(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Disqus().Should().BeOfType<DisqusWidgetsCreator>().And.BeSameAs(Widgets.Disqus());
  }
}