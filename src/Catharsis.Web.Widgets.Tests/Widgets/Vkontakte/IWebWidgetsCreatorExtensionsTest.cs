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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Vkontakte(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Vkontakte_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Vkontakte(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.Vkontakte().Should().BeOfType<VkontakteWidgetsCreator>().And.BeSameAs(Widgets.Create.Vkontakte());
  }
}