using System.Xml.Linq;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuIcqWidget"/>.</para>
/// </summary>
public sealed class MailRuIcqWidgetTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuIcqWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuIcqWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuIcqWidget>();

    var widget = new MailRuIcqWidget();
    widget.Account().Should().BeNull();
    widget.Language().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuIcqWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuIcqWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new MailRuIcqWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

      var widget = new MailRuIcqWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IMailRuIcqWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuIcqWidget.Language(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuIcqWidget().Language(null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");
      AssertionExtensions.Should(() => new MailRuIcqWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("language");

      var widget = new MailRuIcqWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string language, IMailRuIcqWidget widget)
    {
      widget.Language(language).Should().BeSameAs(widget);
      widget.Language().Should().Be(language);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuIcqWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuIcqWidget(), new XElement("script", new XAttribute("src", "http://c.icq.com/siteim/icqbar/js/partners/initbar_ru.js"), new XAttribute("type", "text/javascript")).ToString());
      Validate(new MailRuIcqWidget().Account("account").Language("en"), "window.ICQ = {siteOwner:'account'};", """<script src="http://c.icq.com/siteim/icqbar/js/partners/initbar_en.js" type="text/javascript"></script>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
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