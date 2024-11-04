using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="RobokassaHtmlHelper"/>.</para>
  /// </summary>
  public sealed class RobokassaHtmlHelperTests
  {
    private readonly HtmlHelper html = new MockHtmlHelper();

    /// <summary>
    ///   <para>Performs testing of <see cref="RobokassaHtmlHelper.PaymentForm()"/> method.</para>
    /// </summary>
    [Fact]
    public void Robokassa_Method()
    {
      Assert.False(ReferenceEquals(this.html.Robokassa().PaymentForm(), this.html.Robokassa().PaymentForm()));
      Assert.True(this.html.Robokassa().PaymentForm() is RobokassaPaymentFormWidget);
    }
  }
}