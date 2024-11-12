using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="CackleCommentsCountWidget"/>.</para>
/// </summary>
public sealed class CackleCommentsCountWidgetTests
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleCommentsCountWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleCommentsCountWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleCommentsCountWidget>();

    var widget = new CackleCommentsCountWidget();
    widget.Account().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new CackleCommentsCountWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new CackleCommentsCountWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new CackleCommentsCountWidget();
      new[] { null, string.Empty, new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, ICackleCommentsCountWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.ToHtml"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtmlString_Method()
  {
    using (new AssertionScope())
    {
      Validate(string.Empty, new CackleCommentsCountWidget());
      Validate(@"{""widget"":""CommentCount"",""id"":""account""}", new CackleCommentsCountWidget().Account("account"));
    }

    return;

    static void Validate(string result, ICackleCommentsCountWidget widget) => widget.ToHtml().Should().NotBeSameAs(widget.ToHtml()).And.Contain(result);
  }
}