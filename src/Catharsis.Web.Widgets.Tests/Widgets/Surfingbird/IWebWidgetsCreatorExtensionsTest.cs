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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Surfingbird(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Surfingbird_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Surfingbird(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");
    
    Widgets.Create.Surfingbird().Should().BeOfType<SurfingbirdWidgetsCreator>().And.BeSameAs(Widgets.Create.Surfingbird());
  }
}