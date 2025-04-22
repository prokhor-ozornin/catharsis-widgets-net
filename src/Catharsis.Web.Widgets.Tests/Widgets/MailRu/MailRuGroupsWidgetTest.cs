using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuGroupsWidget"/>.</para>
/// </summary>
public sealed class MailRuGroupsWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuGroupsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuGroupsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuGroupsWidget>();

    using (new AssertionScope())
    {
      var widget = new MailRuGroupsWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<string>("BackgroundColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ButtonColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("DomainProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<bool>("SubscribersProperty").Should().BeTrue();
      widget.GetPropertyValue<string>("TextColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new MailRuGroupsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, IMailRuGroupsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.BackgroundColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BackgroundColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuGroupsWidget().BackgroundColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuGroupsWidget().BackgroundColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuGroupsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuGroupsWidget widget) => widget.BackgroundColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BackgroundColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.ButtonColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ButtonColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuGroupsWidget().ButtonColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuGroupsWidget().ButtonColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuGroupsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuGroupsWidget widget) => widget.ButtonColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ButtonColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Domain(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Domain_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Domain(null)).ThrowExactly<ArgumentNullException>().WithParameterName("domain");
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Domain(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("domain");

      new MailRuGroupsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuGroupsWidget widget) => widget.Domain(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new MailRuGroupsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IMailRuGroupsWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Subscribers(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribers_Method()
  {
    using (new AssertionScope())
    {
      new MailRuGroupsWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IMailRuGroupsWidget widget) => widget.Subscribers(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("SubscribersProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.TextColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuGroupsWidget().TextColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuGroupsWidget().TextColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuGroupsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuGroupsWidget widget) => widget.TextColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new MailRuGroupsWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new MailRuGroupsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IMailRuGroupsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuGroupsWidget());
      Validate(new MailRuGroupsWidget().Account("account").Width("width"));
      Validate(new MailRuGroupsWidget().Account("account").Height("height"));
      Validate(new MailRuGroupsWidget().Width("width").Height("height"));
      Validate(new MailRuGroupsWidget().Account("account").Width("width").Height("height"), """<a class="mrc__plugin_groups_widget" href="http://connect.mail.ru/groups_widget?group=account&amp;max_sub=50&amp;width=width&amp;height=height&amp;show_subscribers=true" rel="{&quot;group&quot;:&quot;account&quot;,&quot;max_sub&quot;:50,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;show_subscribers&quot;:true}" target="_blank">Группы</a>""");
      Validate(new MailRuGroupsWidget().Account("account").Width("width").Height("height").Subscribers(false).BackgroundColor("backgroundColor").TextColor("textColor").ButtonColor("buttonColor").Domain("domain"), """<a class="mrc__plugin_groups_widget" href="http://connect.mail.ru/groups_widget?group=account&amp;max_sub=50&amp;width=width&amp;height=height&amp;background=backgroundColor&amp;color=textColor&amp;button_background=buttonColor&amp;domain=domain" rel="{&quot;group&quot;:&quot;account&quot;,&quot;max_sub&quot;:50,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;button_background&quot;:&quot;buttonColor&quot;,&quot;domain&quot;:&quot;domain&quot;}" target="_blank">Группы</a>""");
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