using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestFollowButtonWidget"/>.</para>
/// </summary>
public sealed class PinterestFollowButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestFollowButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new PinterestFollowButtonWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LabelProperty").Should().Be("Follow");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new PinterestFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, IPinterestFollowButtonWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Label(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Label_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Label(null)).ThrowExactly<ArgumentNullException>().WithParameterName("label");
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Label(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("label");

      new PinterestFollowButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string label, IPinterestFollowButtonWidget widget) => widget.Label(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LabelProperty").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestFollowButtonWidget());
      Validate(new PinterestFollowButtonWidget().Account("account"), """<a data-pin-do="buttonFollow" href="http://www.pinterest.com/account">Follow</a>""");
      Validate(new PinterestFollowButtonWidget().Account("account").Label("label"), """<a data-pin-do="buttonFollow" href="http://www.pinterest.com/account">label</a>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

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