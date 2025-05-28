using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalBuyGiftCertificateWidget"/>.</para>
/// </summary>
public sealed class PayPalBuyGiftCertificateWidgetTest : Test
{
  private IPayPalBuyGiftCertificateWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PayPalBuyGiftCertificateWidgetTest() => Widget = Fixture<IPayPalBuyGiftCertificateWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalBuyGiftCertificateWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PayPalBuyGiftCertificateWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPayPalBuyGiftCertificateWidget>();

    using (new AssertionScope())
    {
      var widget = new PayPalBuyGiftCertificateWidget();
    }
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
  ///   <para>Performs testing of <see cref="PayPalBuyGiftCertificateWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new PayPalBuyGiftCertificateWidget());
      Test(Fixture<PayPalBuyGiftCertificateWidget>.Create());
    }

    return;

    static void Test(IPayPalBuyGiftCertificateWidget original)
    {
      var clone = original.Clone<IPayPalBuyGiftCertificateWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyGiftCertificateWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(Fixture<PayPalBuyGiftCertificateWidget>.Create());
      throw new NotImplementedException();
    }

    return;

    static void Test(IPayPalBuyGiftCertificateWidget widget, params string[] html)
    {
      if (html.IsUnset())
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