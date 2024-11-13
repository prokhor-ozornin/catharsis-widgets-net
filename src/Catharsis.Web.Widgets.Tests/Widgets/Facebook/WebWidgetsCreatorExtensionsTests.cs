using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Facebook(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void Facebook_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.Facebook(null));

    Assert.NotNull(html.Facebook());
    Assert.True(ReferenceEquals(html.Facebook(), html.Facebook()));
  }
}