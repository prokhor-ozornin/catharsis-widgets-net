using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleLoginWidget"/>.</para>
/// </summary>
public sealed class CackleLoginWidgetTests : ClassTest<CackleLoginWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleLoginWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleLoginWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleLoginWidget>();

    var widget = new CackleLoginWidget();
    widget.Account().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new CackleLoginWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new CackleLoginWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new CackleLoginWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, ICackleLoginWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new CackleLoginWidget().ToString());

    var html = new CackleLoginWidget().Account("account").ToString();
    Assert.True(html.Contains("""<div id="mc-login"></div>"""));
    Assert.True(html.Contains("""{"widget":"Login","id":"account"}"""));
  }
}