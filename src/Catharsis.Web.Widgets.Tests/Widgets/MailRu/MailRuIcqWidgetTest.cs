using AutoFixture;
using System.Xml.Linq;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuIcqWidget"/>.</para>
/// </summary>
public sealed class MailRuIcqWidgetTest : Test
{
  private IMailRuIcqWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public MailRuIcqWidgetTest() => Widget = Fixture.Create<IMailRuIcqWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuIcqWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuIcqWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuIcqWidget>();

    using (new AssertionScope())
    {
      var widget = new MailRuIcqWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("LanguageValue").Should().BeNull();
    }
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
      AssertionExtensions.Should(() => new MailRuIcqWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string account, IMailRuIcqWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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
      AssertionExtensions.Should(() => new MailRuIcqWidget().Language(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("language");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string language, IMailRuIcqWidget widget) => widget.Language(language).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(language);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuIcqWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuIcqWidget());
      Validate(Fixture.Create<IMailRuIcqWidget>());
    }

    return;

    static void Validate(IMailRuIcqWidget original)
    {
      var clone = original.Clone<IMailRuIcqWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("LanguageValue").Should().Be(original.GetPropertyValue<string>("LanguageValue"));
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
      Validate(Fixture.Create<IMailRuIcqWidget>());
    }

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