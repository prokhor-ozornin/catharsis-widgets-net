using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.YouTube(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void YouTube_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.YouTube(null));

    Assert.NotNull(html.YouTube());
    Assert.True(ReferenceEquals(html.YouTube(), html.YouTube()));
  }
}