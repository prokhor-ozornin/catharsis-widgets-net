using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreatorExtensions"/>
public sealed partial class IWebWidgetsCreatorExtensionsTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.InlineImage(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void InlineImage_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.InlineImage(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.InlineImage().Should().BeOfType<InlineImageWidget>().And.NotBeSameAs(Widgets.Create.InlineImage());
  }
}