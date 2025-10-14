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
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.Tumblr(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void Tumblr_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.Tumblr(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.Tumblr().Should().BeOfType<TumblrWidgetsCreator>().And.BeSameAs(Widgets.Create.Tumblr());
  }
}