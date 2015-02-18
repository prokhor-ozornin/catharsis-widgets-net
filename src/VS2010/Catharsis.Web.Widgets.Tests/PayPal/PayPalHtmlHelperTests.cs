using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PayPalHtmlHelper"/>.</para>
  /// </summary>
  public sealed class PayPalHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="PayPalHtmlHelper.BuyGiftCertificate()"/> method.</para>
    /// </summary>
    [Fact]
    public void BuyGiftCertificate_Method()
    {
      Assert.False(ReferenceEquals(this.html.PayPal().BuyGiftCertificate(), this.html.PayPal().BuyGiftCertificate()));
      Assert.True(this.html.PayPal().BuyGiftCertificate() is PayPalBuyGiftCertificateWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PayPalHtmlHelper.BuyNow()"/> method.</para>
    /// </summary>
    [Fact]
    public void BuyNow_Method()
    {
      Assert.False(ReferenceEquals(this.html.PayPal().BuyNow(), this.html.PayPal().BuyNow()));
      Assert.True(this.html.PayPal().BuyNow() is PayPalBuyNowWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PayPalHtmlHelper.Donate()"/> method.</para>
    /// </summary>
    [Fact]
    public void Donate_Method()
    {
      Assert.False(ReferenceEquals(this.html.PayPal().Donate(), this.html.PayPal().Donate()));
      Assert.True(this.html.PayPal().Donate() is PayPalDonateWidget);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="PayPalHtmlHelper.Subscribe()"/> method.</para>
    /// </summary>
    [Fact]
    public void Subscribe_Method()
    {
      Assert.False(ReferenceEquals(this.html.PayPal().Subscribe(), this.html.PayPal().Subscribe()));
      Assert.True(this.html.PayPal().Subscribe() is PayPalSubscribeWidget);
    }
  }
}