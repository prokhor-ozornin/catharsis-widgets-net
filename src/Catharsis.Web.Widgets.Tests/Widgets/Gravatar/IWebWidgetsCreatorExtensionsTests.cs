using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Gravatar(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Gravatar_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Gravatar(null));

    widgets.Gravatar().Should().BeOfType<GravatarWidgetsCreator>().And.BeSameAs(widgets.Gravatar());
  }
}