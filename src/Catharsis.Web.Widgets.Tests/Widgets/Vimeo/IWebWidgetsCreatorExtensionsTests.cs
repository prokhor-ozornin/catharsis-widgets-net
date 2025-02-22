using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Vimeo(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Vimeo_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Vimeo(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Vimeo().Should().BeOfType<VimeoWidgetsCreator>().And.BeSameAs(Widgets.Vimeo());
  }
}