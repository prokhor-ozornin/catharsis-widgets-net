using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.MailRu(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void MailRu_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.MailRu(null));

    widgets.MailRu().Should().BeOfType<MailRuWidgetsCreator>().And.BeSameAs(widgets.MailRu());
  }
}