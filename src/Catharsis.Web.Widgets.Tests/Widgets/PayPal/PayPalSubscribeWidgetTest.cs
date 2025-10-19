using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalSubscribeWidget"/>.</para>
/// </summary>
/// <seealso cref="PayPalSubscribeWidget"/>
public sealed class PayPalSubscribeWidgetTest : Test
{
  private IPayPalSubscribeWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PayPalSubscribeWidgetTest() => Widget = Fixture<IPayPalSubscribeWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PayPalSubscribeWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PayPalSubscribeWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPayPalSubscribeWidget>();

    using (new AssertionScope())
    {
      var widget = new PayPalSubscribeWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalSubscribeWidget.AsForm()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsForm_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalSubscribeWidget.AsUrl()"/> method.</para>
  /// </summary>
  [Fact]
  public void AsUrl_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalSubscribeWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new PayPalSubscribeWidget());
      Test(Fixture<PayPalSubscribeWidget>.Create());
    }

    return;

    static void Test(IPayPalSubscribeWidget original)
    {
      var clone = original.Clone<IPayPalSubscribeWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalSubscribeWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(Fixture<PayPalSubscribeWidget>.Create());
      
      throw new NotImplementedException();
    }

    return;

    static void Test(IPayPalSubscribeWidget widget, params string[] html)
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