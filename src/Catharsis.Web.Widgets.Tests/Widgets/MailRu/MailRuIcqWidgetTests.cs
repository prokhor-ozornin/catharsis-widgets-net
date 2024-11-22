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
public sealed class MailRuIcqWidgetTests : ClassTest<MailRuIcqWidget>
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
    Assert.Throws<ArgumentNullException>(() => new MailRuIcqWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new MailRuIcqWidget().Account(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Throws<ArgumentNullException>(() => new MailRuIcqWidget().Language(null));
    Assert.Throws<ArgumentException>(() => new MailRuIcqWidget().Language(string.Empty));

    using (new AssertionScope())
    {
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
    Assert.Equal(new XElement("script", new XAttribute("src", "http://c.icq.com/siteim/icqbar/js/partners/initbar_ru.js"), new XAttribute("type", "text/javascript")).ToString(), new MailRuIcqWidget().ToString());

    var html = new MailRuIcqWidget().Account("account").Language("en").ToString();
    Assert.True(html.Contains("window.ICQ = {siteOwner:'account'};"));
    Assert.True(html.Contains("""<script src="http://c.icq.com/siteim/icqbar/js/partners/initbar_en.js" type="text/javascript"></script>"""));
  }
}