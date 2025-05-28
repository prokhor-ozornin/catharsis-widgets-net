using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalBuyNowWidget"/>.</para>
/// </summary>
public sealed class PayPalBuyNowWidgetTest : Test
{
  private IPayPalBuyNowWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PayPalBuyNowWidgetTest() => Widget = Fixture<IPayPalBuyNowWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalBuyNowWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PayPalBuyNowWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPayPalBuyNowWidget>();

    using (new AssertionScope())
    {
      var widget = new PayPalBuyNowWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyNowWidget.AsForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsForm_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyNowWidget.AsUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsUrl_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyNowWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new PayPalBuyNowWidget());
      Test(Fixture<PayPalBuyNowWidget>.Create());
    }

    return;

    static void Test(IPayPalBuyNowWidget original)
    {
      var clone = original.Clone<IPayPalBuyNowWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalBuyNowWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(Fixture<PayPalBuyNowWidget>.Create());
      throw new NotImplementedException();
    }

    return;

    static void Test(IPayPalBuyNowWidget widget, params string[] html)
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