using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class WebWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.MailRu(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void MailRu_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.MailRu(null));

    Assert.NotNull(html.MailRu());
    Assert.True(ReferenceEquals(html.MailRu(), html.MailRu()));
  }
}