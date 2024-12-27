using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.IntenseDebate(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void IntenseDebate_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.IntenseDebate(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    widgets.IntenseDebate().Should().BeOfType<IntenseDebateWidgetsCreator>().And.BeSameAs(widgets.IntenseDebate());
  }
}