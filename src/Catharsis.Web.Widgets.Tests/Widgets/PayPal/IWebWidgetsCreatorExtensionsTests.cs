using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.PayPal(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void PayPal_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IWebWidgetsCreatorExtensions.PayPal(null));

    widgets.PayPal().Should().BeOfType<PayPalWidgetsCreator>().And.BeSameAs(widgets.PayPal());
  }
}