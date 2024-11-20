using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="CackleCommentsWidget"/>.</para>
/// </summary>
public sealed class CackleCommentsWidgetTests : ClassTest<CackleCommentsWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleCommentsWidget>();

    var widget = new CackleCommentsWidget();
    widget.Account().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new CackleCommentsWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new CackleCommentsWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new CackleCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, ICackleCommentsWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(string.Empty, new CackleCommentsWidget());
      Validate("""<div id="mc-container"></div>""", new CackleCommentsWidget().Account("account"));
      Validate("""{"widget":"Comment","id":"account"}""", new CackleCommentsWidget().Account("account"));
    }

    return;

    static void Validate(string result, ICackleCommentsWidget widget) => widget.ToHtml().Should().NotBeSameAs(widget.ToHtml()).And.Contain(result);
  }
}