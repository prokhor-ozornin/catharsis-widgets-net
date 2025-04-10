using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Facebook(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Facebook_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Facebook(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.Facebook().Should().BeOfType<FacebookWidgetsCreator>().And.BeSameAs(Widgets.Create.Disqus());
  }
}