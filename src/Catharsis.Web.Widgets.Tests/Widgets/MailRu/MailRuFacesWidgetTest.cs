using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuFacesWidget"/>.</para>
/// </summary>
public sealed class MailRuFacesWidgetTest : Test
{
  private IMailRuFacesWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public MailRuFacesWidgetTest() => Widget = Fixture.Create<IMailRuFacesWidget>();

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
      widget.GetPropertyValue<string>("BackgroundColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("BorderColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("DomainValue").Should().BeNull();
      widget.GetPropertyValue<string>("FontValue").Should().Be(nameof(MailRuFacesFont.Arial));
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<string>("HyperlinkColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("TextColorValue").Should().BeNull();
      widget.GetPropertyValue<bool>("TitleValue").Should().BeTrue();
      widget.GetPropertyValue<string>("TitleColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("TitleTextValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuFacesWidget widget) => widget.BackgroundColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BackgroundColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuFacesWidget widget) => widget.BorderColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BorderColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string domain, IMailRuFacesWidget widget) => widget.Domain(domain).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainValue").Should().Be(domain);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string font, IMailRuFacesWidget widget) => widget.Font(font).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FontValue").Should().Be(font);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IMailRuFacesWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuFacesWidget widget) => widget.HyperlinkColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HyperlinkColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuFacesWidget widget) => widget.TextColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextColorValue").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Title(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IMailRuFacesWidget widget) => widget.Title(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("TitleValue").Should().Be(enabled);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IMailRuFacesWidget widget) => widget.TitleColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string text, IMailRuFacesWidget widget) => widget.TitleText(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleTextValue").Should().Be(text);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IMailRuFacesWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuFacesWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new MailRuFacesWidget());
      Test(Fixture.Create<MailRuFacesWidget>());
    }

    return;

    static void Test(IMailRuFacesWidget original)
    {
      var clone = original.Clone<IMailRuFacesWidget>();

      clone.GetPropertyValue<string>("BackgroundColorValue").Should().Be(original.GetPropertyValue<string>("BackgroundColorValue"));
      clone.GetPropertyValue<string>("BorderColorValue").Should().Be(original.GetPropertyValue<string>("BorderColorValue"));
      clone.GetPropertyValue<string>("DomainValue").Should().Be(original.GetPropertyValue<string>("DomainValue"));
      clone.GetPropertyValue<string>("FontValue").Should().Be(original.GetPropertyValue<string>("FontValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("HyperlinkColorValue").Should().Be(original.GetPropertyValue<string>("HyperlinkColorValue"));
      clone.GetPropertyValue<string>("TextColorValue").Should().Be(original.GetPropertyValue<string>("TextColorValue"));
      clone.GetPropertyValue<bool>("TitleValue").Should().Be(original.GetPropertyValue<bool>("TitleValue"));
      clone.GetPropertyValue<string>("TitleColorValue").Should().Be(original.GetPropertyValue<string>("TitleColorValue"));
      clone.GetPropertyValue<string>("TitleTextValue").Should().Be(original.GetPropertyValue<string>("TitleTextValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
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
      Test(new MailRuFacesWidget());
      Test(new MailRuFacesWidget().Domain("domain").Width("width"));
      Test(new MailRuFacesWidget().Domain("domain").Height("height"));
      Test(new MailRuFacesWidget().Width("width").Height("height"));
      Test(new MailRuFacesWidget().Domain("domain").Width("width").Height("height"), """<a class="mrc__plugin_share_friends" href="http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height" rel="{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}">Друзья</a>""");
      Test(new MailRuFacesWidget().Domain("domain").Width("width").Height("height").TitleText("title").Title(false).TitleColor("titleColor").BackgroundColor("backgroundColor").BorderColor("borderColor").TextColor("textColor").HyperlinkColor("hyperlinkColor"), """<a class="mrc__plugin_share_friends" href="http://connect.mail.ru/share_friends?domain=domain&amp;font=Arial&amp;width=width&amp;height=height&amp;title=title&amp;notitle=true&amp;title-color=titleColor&amp;background=backgroundColor&amp;border=borderColor&amp;color=textColor&amp;link-color=hyperlinkColor" rel="{&quot;domain&quot;:&quot;domain&quot;,&quot;font&quot;:&quot;Arial&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;,&quot;title&quot;:&quot;title&quot;,&quot;notitle&quot;:true,&quot;title-color&quot;:&quot;titleColor&quot;,&quot;background&quot;:&quot;backgroundColor&quot;,&quot;border&quot;:&quot;borderColor&quot;,&quot;color&quot;:&quot;textColor&quot;,&quot;link-color&quot;:&quot;hyperlinkColor&quot;}">Друзья</a>""");
      Test(Fixture.Create<MailRuFacesWidget>());
    }

    return;

    static void Test(IMailRuFacesWidget widget, params string[] html)
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