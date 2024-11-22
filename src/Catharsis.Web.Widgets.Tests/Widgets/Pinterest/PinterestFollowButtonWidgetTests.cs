using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestFollowButtonWidget"/>.</para>
/// </summary>
public sealed class PinterestFollowButtonWidgetTests : ClassTest<PinterestFollowButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestFollowButtonWidget>();

    var widget = new PinterestFollowButtonWidget();
    widget.Account().Should().BeNull();
    widget.Label().Should().Be("Follow");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestFollowButtonWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new PinterestFollowButtonWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IPinterestFollowButtonWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Label(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Label_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new PinterestFollowButtonWidget().Label(null));
    Assert.Throws<ArgumentException>(() => new PinterestFollowButtonWidget().Label(string.Empty));

    using (new AssertionScope())
    {
      var widget = new PinterestFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string label, IPinterestFollowButtonWidget widget)
    {
      widget.Label(label).Should().BeSameAs(widget);
      widget.Label().Should().Be(label);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new PinterestFollowButtonWidget().ToString());
    Assert.Equal("""<a data-pin-do="buttonFollow" href="http://www.pinterest.com/account">Follow</a>""", new PinterestFollowButtonWidget().Account("account").ToString());
    Assert.Equal("""<a data-pin-do="buttonFollow" href="http://www.pinterest.com/account">label</a>""", new PinterestFollowButtonWidget().Account("account").Label("label").ToString());
  }
}