using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Facebook(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Facebook_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Facebook(null));

    widgets.Facebook().Should().BeOfType<FacebookWidgetsCreator>().And.BeSameAs(widgets.Disqus());
  }
}