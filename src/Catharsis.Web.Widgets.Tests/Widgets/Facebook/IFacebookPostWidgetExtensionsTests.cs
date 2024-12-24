using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookPostWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookPostWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookPostWidgetExtensions.Width(IFacebookPostWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IFacebookPostWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookPostWidget().Width(1).Width());
  }
}