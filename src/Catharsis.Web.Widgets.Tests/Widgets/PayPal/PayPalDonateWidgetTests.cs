using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalDonateWidget"/>.</para>
/// </summary>
public sealed class PayPalDonateWidgetTests : ClassTest<PayPalDonateWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalDonateWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PayPalDonateWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPayPalDonateWidget>();

    var widget = new PayPalDonateWidget();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalDonateWidget.AsForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsForm_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalDonateWidget.AsUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsUrl_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalDonateWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    throw new NotImplementedException();
  }
}