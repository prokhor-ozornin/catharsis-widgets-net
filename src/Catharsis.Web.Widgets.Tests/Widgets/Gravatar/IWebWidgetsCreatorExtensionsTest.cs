using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Gravatar(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Gravatar_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Gravatar(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Gravatar().Should().BeOfType<GravatarWidgetsCreator>().And.BeSameAs(Widgets.Gravatar());
  }
}