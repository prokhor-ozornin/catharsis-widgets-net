using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.LiveJournal(HtmlHelper)"/> method.</para>
  /// </summary>
  [Fact]
  public void LiveJournal_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.LiveJournal(null));

    Assert.NotNull(html.LiveJournal());
    Assert.True(ReferenceEquals(html.LiveJournal(), html.LiveJournal()));
  }
}