using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Twitter(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Twitter_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Twitter(null));

    widgets.Twitter().Should().BeOfType<TwitterWidgetsCreator>().And.BeSameAs(widgets.Twitter());
  }
}