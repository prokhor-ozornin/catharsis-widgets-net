using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalWidgetsCreator"/>.</para>
/// </summary>
public sealed class PayPalWidgetsCreatorTest : Test
{
  private IPayPalWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.PayPal();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalWidgetsCreator()"/>
  [Fact]
  public void Constructors() => typeof(PayPalWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IPayPalWidgetsCreator>();

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.BuyGiftCertificate()"/> method.</para>
  /// </summary>
  [Fact]
  public void BuyGiftCertificate_Method()
  {
    Widgets.BuyGiftCertificate().Should().BeOfType<PayPalBuyGiftCertificateWidget>().And.NotBeSameAs(Widgets.BuyGiftCertificate());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.BuyNow()"/> method.</para>
  /// </summary>
  [Fact]
  public void BuyNow_Method()
  {
    Widgets.BuyNow().Should().BeOfType<PayPalBuyNowWidget>().And.NotBeSameAs(Widgets.BuyNow());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.Donate()"/> method.</para>
  /// </summary>
  [Fact]
  public void Donate_Method()
  {
    Widgets.Donate().Should().BeOfType<PayPalDonateWidget>().And.NotBeSameAs(Widgets.Donate());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalWidgetsCreator.Subscribe()"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribe_Method()
  {
    Widgets.Subscribe().Should().BeOfType<PayPalSubscribeWidget>().And.NotBeSameAs(Widgets.Subscribe());
  }
}