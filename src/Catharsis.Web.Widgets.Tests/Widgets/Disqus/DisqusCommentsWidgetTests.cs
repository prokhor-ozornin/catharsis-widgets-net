using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DisqusCommentsWidget"/>.</para>
/// </summary>
public sealed class DisqusCommentsWidgetTests : ClassTest<DisqusCommentsWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DisqusCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DisqusCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDisqusCommentsWidget>();

    var widget = new DisqusCommentsWidget();
    widget.Account().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new DisqusCommentsWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new DisqusCommentsWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new DisqusCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IDisqusCommentsWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new DisqusCommentsWidget().ToString());

    var html = new DisqusCommentsWidget().Account("account").ToString();
    Assert.True(html.Contains("""<div id="disqus_thread"></div>"""));
    Assert.True(html.Contains("""
                              var disqus_shortname = "account"
                              """));
  }
}