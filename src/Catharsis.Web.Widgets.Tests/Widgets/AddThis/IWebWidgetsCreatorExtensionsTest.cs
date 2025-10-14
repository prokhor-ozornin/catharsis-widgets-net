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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.AddThis(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void AddThis_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.AddThis(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.AddThis().Should().BeOfType<AddThisWidgetsCreator>().And.BeSameAs(Widgets.Create.AddThis());
  }
}