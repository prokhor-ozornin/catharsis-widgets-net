using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreatorExtensions"/>
public sealed partial class IWebWidgetsCreatorExtensionsTest : Test
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Yandex(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Yandex_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Yandex(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.Yandex().Should().BeOfType<YandexWidgetsCreator>().And.BeSameAs(Widgets.Create.Yandex());
  }
}