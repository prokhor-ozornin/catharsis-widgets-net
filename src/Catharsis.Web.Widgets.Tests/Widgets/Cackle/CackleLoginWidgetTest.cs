using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleLoginWidget"/>.</para>
/// </summary>
public sealed class CackleLoginWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleLoginWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleLoginWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleLoginWidget>();

    using (new AssertionScope())
    {
      var widget = new CackleLoginWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new CackleLoginWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new CackleLoginWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new CackleLoginWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, ICackleLoginWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleLoginWidget());
      Validate(new CackleLoginWidget().Account("account"), """<div id="mc-login"></div>""", """{"widget":"Login","id":"account"}""");
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