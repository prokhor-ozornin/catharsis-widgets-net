using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Yandex(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void Yandex_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Yandex(null));

    Assert.NotNull(html.Yandex());
    Assert.True(ReferenceEquals(html.Yandex(), html.Yandex()));
  }
}