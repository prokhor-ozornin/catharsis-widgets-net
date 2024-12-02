using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalWidgetsCreator"/>.</para>
/// </summary>
public sealed class PayPalWidgetsCreatorTests : ClassTest<PayPalWidgetsCreator>
{
  private readonly IPayPalWidgetsCreator widgets = Widgets.Web.PayPal();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PayPalWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IPayPalWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.BuyGiftCertificate()"/> method.</para>
  /// </summary>
  [Fact]
  public void BuyGiftCertificate_Method()
  {
    widgets.BuyGiftCertificate().Should().BeOfType<PayPalBuyGiftCertificateWidget>().And.NotBeSameAs(widgets.BuyGiftCertificate());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.BuyNow()"/> method.</para>
  /// </summary>
  [Fact]
  public void BuyNow_Method()
  {
    widgets.BuyNow().Should().BeOfType<PayPalBuyNowWidget>().And.NotBeSameAs(widgets.BuyNow());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.Donate()"/> method.</para>
  /// </summary>
  [Fact]
  public void Donate_Method()
  {
    widgets.Donate().Should().BeOfType<PayPalDonateWidget>().And.NotBeSameAs(widgets.Donate());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.Subscribe()"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribe_Method()
  {
    widgets.Subscribe().Should().BeOfType<PayPalSubscribeWidget>().And.NotBeSameAs(widgets.Subscribe());
  }
}