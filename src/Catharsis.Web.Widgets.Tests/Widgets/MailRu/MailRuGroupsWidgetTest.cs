using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuGroupsWidget"/>.</para>
/// </summary>
public sealed class MailRuGroupsWidgetTest : Test
{
  private IMailRuGroupsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public MailRuGroupsWidgetTest() => Widget = Fixture.Create<IMailRuGroupsWidget>();

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
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("BackgroundColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("ButtonColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("DomainValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<bool>("SubscribersValue").Should().BeTrue();
      widget.GetPropertyValue<string>("TextColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, IMailRuGroupsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuGroupsWidget widget) => widget.BackgroundColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BackgroundColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuGroupsWidget widget) => widget.ButtonColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ButtonColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuGroupsWidget widget) => widget.Domain(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IMailRuGroupsWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Subscribers(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Subscribers_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IMailRuGroupsWidget widget) => widget.Subscribers(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("SubscribersValue").Should().Be(enabled);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuGroupsWidget widget) => widget.TextColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IMailRuGroupsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new MailRuGroupsWidget());
      Test(Fixture.Create<MailRuGroupsWidget>());
    }

    return;

    static void Test(IMailRuGroupsWidget original)
    {
      var clone = original.Clone<IMailRuGroupsWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("BackgroundColorValue").Should().Be(original.GetPropertyValue<string>("BackgroundColorValue"));
      clone.GetPropertyValue<string>("ButtonColorValue").Should().Be(original.GetPropertyValue<string>("ButtonColorValue"));
      clone.GetPropertyValue<string>("DomainValue").Should().Be(original.GetPropertyValue<string>("DomainValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<bool>("SubscribersValue").Should().Be(original.GetPropertyValue<bool>("SubscribersValue"));
      clone.GetPropertyValue<string>("TextColorValue").Should().Be(original.GetPropertyValue<string>("TextColorValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuGroupsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new MailRuGroupsWidget());
      Test(new MailRuGroupsWidget().Account("account").Width("width"));
      Test(new MailRuGroupsWidget().Account("account").Height("height"));
      Test(new MailRuGroupsWidget().Width("width").Height("height"));
      Test(new MailRuGroupsWidget().Account("account").Width("width").Height("height"), """<a class="mrc__plugin_groups_widget" href="http://connect.mail.ru/groups_widget?group=account&amp;max_sub=50&amp;width=width&amp;height=height&amp;show_subscribers=true" rel="{&quot;group&quot;:&quot;account&quot;,&quot;max_sub&quot;:50,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;show_subscribers&quot;:true}" target="_blank">Группы</a>""");
      Test(new MailRuGroupsWidget().Account("account").Width("width").Height("height").Subscribers(false).BackgroundColor("backgroundColor").TextColor("textColor").ButtonColor("buttonColor").Domain("domain"), """<a class="mrc__plugin_groups_widget" href="http://connect.mail.ru/groups_widget?group=account&amp;max_sub=50&amp;width=width&amp;height=height&amp;background=backgroundColor&amp;color=textColor&amp;button_background=buttonColor&amp;domain=domain" rel="{&quot;group&quot;:&quot;account&quot;,&quot;max_sub&quot;:50,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;button_background&quot;:&quot;buttonColor&quot;,&quot;domain&quot;:&quot;domain&quot;}" target="_blank">Группы</a>""");
      Test(Fixture.Create<MailRuGroupsWidget>());
    }

    return;

    static void Test(IMailRuGroupsWidget widget, params string[] html)
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