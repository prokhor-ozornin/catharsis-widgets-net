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
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Tumblr(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    widgets.Tumblr().Should().BeOfType<TumblrWidgetsCreator>().And.BeSameAs(widgets.Tumblr());
  }
}