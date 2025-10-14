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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.MailRu(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void MailRu_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.MailRu(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.MailRu().Should().BeOfType<MailRuWidgetsCreator>().And.BeSameAs(Widgets.Create.MailRu());
  }
}