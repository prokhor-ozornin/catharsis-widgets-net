using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.IntenseDebate(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void IntenseDebate_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.IntenseDebate(null));

    Assert.NotNull(html.IntenseDebate());
    Assert.True(ReferenceEquals(html.IntenseDebate(), html.IntenseDebate()));
  }
}