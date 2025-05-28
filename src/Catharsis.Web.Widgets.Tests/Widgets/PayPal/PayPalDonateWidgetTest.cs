using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalDonateWidget"/>.</para>
/// </summary>
public sealed class PayPalDonateWidgetTest : Test
{
  private IPayPalDonateWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PayPalDonateWidgetTest() => Widget = Fixture<IPayPalDonateWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalDonateWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PayPalDonateWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPayPalDonateWidget>();

    using (new AssertionScope())
    {
      var widget = new PayPalDonateWidget();
    }
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
  ///   <para>Performs testing of <see cref="PayPalDonateWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new PayPalDonateWidget());
      Test(Fixture<PayPalDonateWidget>.Create());
    }

    return;

    static void Test(IPayPalDonateWidget original)
    {
      var clone = original.Clone<IPayPalDonateWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalDonateWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(Fixture<PayPalDonateWidget>.Create());
      throw new NotImplementedException();
    }

    return;

    static void Test(IPayPalDonateWidget widget, params string[] html)
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