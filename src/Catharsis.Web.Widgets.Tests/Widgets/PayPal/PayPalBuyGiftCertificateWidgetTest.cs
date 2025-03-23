using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalBuyGiftCertificateWidget"/>.</para>
/// </summary>
public sealed class PayPalBuyGiftCertificateWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalBuyGiftCertificateWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PayPalBuyGiftCertificateWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPayPalBuyGiftCertificateWidget>();

    var widget = new PayPalBuyGiftCertificateWidget();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyGiftCertificateWidget.AsForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsForm_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyGiftCertificateWidget.AsUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsUrl_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyGiftCertificateWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    throw new NotImplementedException();

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}