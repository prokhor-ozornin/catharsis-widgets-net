using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Tumblr(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Tumblr_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Tumblr(null));

    widgets.Tumblr().Should().BeOfType<SurfingbirdWidgetsCreator>().And.BeSameAs(widgets.Surfingbird());
  }
}