using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuFacesWidget"/>.</para>
/// </summary>
public sealed class MailRuFacesWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuFacesWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuFacesWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuFacesWidget>();

    using (new AssertionScope())
    {
      var widget = new MailRuFacesWidget();
      widget.GetPropertyValue<string>("BackgroundColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("BorderColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("DomainProperty").Should().BeNull();
      widget.GetPropertyValue<string>("FontProperty").Should().Be(MailRuFacesFont.Arial.ToString());
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HyperlinkColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TextColorProperty").Should().BeNull();
      widget.GetPropertyValue<bool>("TitleProperty").Should().BeTrue();
      widget.GetPropertyValue<string>("TitleColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TitleTextProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.BackgroundColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BackgroundColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().BackgroundColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuFacesWidget().BackgroundColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget) => widget.BackgroundColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BackgroundColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.BorderColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BorderColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().BorderColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuFacesWidget().BorderColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget) => widget.BorderColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BorderColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Domain(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Domain_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().Domain(null)).ThrowExactly<ArgumentNullException>().WithParameterName("domain");
      AssertionExtensions.Should(() => new MailRuFacesWidget().Domain(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("domain");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string domain, IMailRuFacesWidget widget) => widget.Domain(domain).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainProperty").Should().Be(domain);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Font(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Font_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().Font(null)).ThrowExactly<ArgumentNullException>().WithParameterName("font");
      AssertionExtensions.Should(() => new MailRuFacesWidget().Font(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("font");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string font, IMailRuFacesWidget widget) => widget.Font(font).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FontProperty").Should().Be(font);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new MailRuFacesWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IMailRuFacesWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.HyperlinkColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void HyperlinkColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().HyperlinkColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuFacesWidget().HyperlinkColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget) => widget.HyperlinkColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HyperlinkColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.TextColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().TextColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuFacesWidget().TextColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget) => widget.TextColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Title(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    using (new AssertionScope())
    {
      new MailRuFacesWidget().With(widget => new[] { false, true }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(bool enabled, IMailRuFacesWidget widget) => widget.Title(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("TitleProperty").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.TitleColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TitleColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().TitleColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new MailRuFacesWidget().TitleColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IMailRuFacesWidget widget) => widget.TitleColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleColorProperty").Should().Be(color);
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.TitleText(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TitleText_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().TitleText(null)).ThrowExactly<ArgumentNullException>().WithParameterName("title");
      AssertionExtensions.Should(() => new MailRuFacesWidget().TitleText(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("title");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string text, IMailRuFacesWidget widget) => widget.TitleText(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleTextProperty").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuFacesWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new MailRuFacesWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new MailRuFacesWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IMailRuFacesWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuFacesWidget());
      Validate(Attributes.MailRuFacesWidget());
    }

    return;

    static void Validate(IMailRuFacesWidget original)
    {
      var clone = original.Clone<IMailRuFacesWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuFacesWidget());
      Validate(new MailRuFacesWidget().Domain("domain").Width("width"));
      Validate(new MailRuFacesWidget().Domain("domain").Height("height"));
      Validate(new MailRuFacesWidget().Width("width").Height("height"));
      Validate(new MailRuFacesWidget().Domain("domain").Width("width").Height("height"), """<a class="mrc__plugin_share_friends" href="http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height" rel="{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}">Друзья</a>""");
      Validate(new MailRuFacesWidget().Domain("domain").Width("width").Height("height").TitleText("title").Title(false).TitleColor("titleColor").BackgroundColor("backgroundColor").BorderColor("borderColor").TextColor("textColor").HyperlinkColor("hyperlinkColor"), """<a class="mrc__plugin_share_friends" href="http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height&amp;title=title&amp;notitle=true&amp;title-color=titleColor&amp;background=backgroundColor&amp;border=borderColor&amp;color=textColor&amp;link-color=hyperlinkColor" rel="{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;title&quot;:&quot;title&quot;,&quot;notitle&quot;:true,&quot;title-color&quot;:&quot;titleColor&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;border&quot;:&quot;borderColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;link-color&quot;:&quot;hyperlinkColor&quot;}">Друзья</a>""");
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