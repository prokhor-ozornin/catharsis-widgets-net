using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuFacesWidget"/>.</para>
/// </summary>
public sealed class MailRuFacesWidgetTests : ClassTest<MailRuFacesWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuFacesWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuFacesWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuFacesWidget>();

    var widget = new MailRuFacesWidget();
    widget.BackgroundColor().Should().BeNull();
    widget.BorderColor().Should().BeNull();
    widget.Domain().Should().BeNull();
    widget.Font().Should().Be(MailRuFacesFont.Arial.ToString());
    widget.Height().Should().BeNull();
    widget.HyperlinkColor().Should().BeNull();
    widget.TextColor().Should().BeNull();
    widget.Title().Should().BeTrue();
    widget.TitleColor().Should().BeNull();
    widget.TitleText().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.BackgroundColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BackgroundColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().BackgroundColor(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().BackgroundColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget)
    {
      widget.BackgroundColor(color).Should().BeSameAs(widget);
      widget.BackgroundColor().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.BorderColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BorderColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().BorderColor(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().BorderColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget)
    {
      widget.BorderColor(color).Should().BeSameAs(widget);
      widget.BorderColor().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Domain(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Domain_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Domain(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Domain(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string domain, IMailRuFacesWidget widget)
    {
      widget.Domain(domain).Should().BeSameAs(widget);
      widget.Domain().Should().Be(domain);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Font(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Font_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Font(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Font(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string font, IMailRuFacesWidget widget)
    {
      widget.Font(font).Should().BeSameAs(widget);
      widget.Font().Should().Be(font);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IMailRuFacesWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.HyperlinkColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void HyperlinkColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().HyperlinkColor(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().HyperlinkColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget)
    {
      widget.HyperlinkColor(color).Should().BeSameAs(widget);
      widget.HyperlinkColor().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.TextColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().TextColor(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().TextColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget)
    {
      widget.TextColor(color).Should().BeSameAs(widget);
      widget.TextColor().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Title(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IMailRuFacesWidget widget)
    {
      widget.Title(enabled).Should().BeSameAs(widget);
      widget.Title().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.TitleColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TitleColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().TitleColor(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().TitleColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget)
    {
      widget.TitleColor(color).Should().BeSameAs(widget);
      widget.TitleColor().Should().Be(color);
    }
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.TitleText(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TitleText_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().TitleText(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().TitleText(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string text, IMailRuFacesWidget widget)
    {
      widget.TitleText(text).Should().BeSameAs(widget);
      widget.TitleText().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuFacesWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new MailRuFacesWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IMailRuFacesWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new MailRuFacesWidget().ToString());
    Assert.Equal(string.Empty, new MailRuFacesWidget().Domain("domain").Width("width").ToString());
    Assert.Equal(string.Empty, new MailRuFacesWidget().Domain("domain").Height("height").ToString());
    Assert.Equal(string.Empty, new MailRuFacesWidget().Width("width").Height("height").ToString());
    Assert.Equal("""<a class="mrc__plugin_share_friends" href="http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height" rel="{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}">Друзья</a>""", new MailRuFacesWidget().Domain("domain").Width("width").Height("height").ToString());
    Assert.Equal("""<a class="mrc__plugin_share_friends" href="http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height&amp;title=title&amp;notitle=true&amp;title-color=titleColor&amp;background=backgroundColor&amp;border=borderColor&amp;color=textColor&amp;link-color=hyperlinkColor" rel="{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;title&quot;:&quot;title&quot;,&quot;notitle&quot;:true,&quot;title-color&quot;:&quot;titleColor&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;border&quot;:&quot;borderColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;link-color&quot;:&quot;hyperlinkColor&quot;}">Друзья</a>""", new MailRuFacesWidget().Domain("domain").Width("width").Height("height").TitleText("title").Title(false).TitleColor("titleColor").BackgroundColor("backgroundColor").BorderColor("borderColor").TextColor("textColor").HyperlinkColor("hyperlinkColor").ToString());
  }
}