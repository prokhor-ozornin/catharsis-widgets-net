using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PayPalSubscribeWidget"/>.</para>
/// </summary>
public sealed class PayPalSubscribeWidgetTest : UnitTest
{
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
      Validate(new PayPalSubscribeWidget());
      Validate(Attributes.PayPalSubscribeWidget());
    }

    return;

    static void Validate(IPayPalSubscribeWidget original)
    {
      var clone = original.Clone<IPayPalSubscribeWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PayPalSubscribeWidget.ToHtml()"/> method.</para>
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