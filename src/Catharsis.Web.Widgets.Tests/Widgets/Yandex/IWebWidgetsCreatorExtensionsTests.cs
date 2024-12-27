using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Yandex(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Yandex_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Yandex(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    widgets.Yandex().Should().BeOfType<YandexWidgetsCreator>().And.BeSameAs(widgets.Yandex());
  }
}