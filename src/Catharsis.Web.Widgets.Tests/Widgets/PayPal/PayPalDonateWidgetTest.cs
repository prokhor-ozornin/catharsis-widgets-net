using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalDonateWidget"/>.</para>
/// </summary>
public sealed class PayPalDonateWidgetTest : UnitTest
{
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
      Validate(new PayPalDonateWidget());
      Validate(Attributes.PayPalDonateWidget());
    }

    return;

    static void Validate(IPayPalDonateWidget original)
    {
      var clone = original.Clone<IPayPalDonateWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalDonateWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    throw new NotImplementedException();

    return;

    static void Validate(IWebWidget widget, params string[] html)
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