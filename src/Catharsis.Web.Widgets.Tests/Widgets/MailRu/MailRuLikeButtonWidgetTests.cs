using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuLikeButtonWidget"/>.</para>
/// </summary>
public sealed class MailRuLikeButtonWidgetTests : ClassTest<MailRuLikeButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuLikeButtonWidget>();

    var widget = new MailRuLikeButtonWidget();
    widget.Type().Should().Be("combo");
    widget.Size().Should().Be("20");
    widget.Layout().Should().Be((byte) MailRuLikeButtonLayout.First);
    widget.Text().Should().BeTrue();
    widget.TextType().Should().Be((byte) MailRuLikeButtonTextType.First);
    widget.Counter().Should().BeTrue();
    widget.CounterPosition().Should().Be(MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Type(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().Type(null)).ThrowExactly<ArgumentNullException>().WithParameterName("type");
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().Type(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("type");

      var widget = new MailRuLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string type, IMailRuLikeButtonWidget widget)
    {
      widget.Type(type).Should().BeSameAs(widget);
      widget.Type().Should().Be(type);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Size(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().Size(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("size");

      var widget = new MailRuLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string size, IMailRuLikeButtonWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Layout(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      var widget = new MailRuLikeButtonWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte layout, IMailRuLikeButtonWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.Layout().Should().Be(layout);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Text(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      var widget = new MailRuLikeButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IMailRuLikeButtonWidget widget)
    {
      widget.Text(enabled).Should().BeSameAs(widget);
      widget.Text().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.TextType(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextType_Method()
  {
    using (new AssertionScope())
    {
      var widget = new MailRuLikeButtonWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte type, IMailRuLikeButtonWidget widget)
    {
      widget.TextType(type).Should().BeSameAs(widget);
      widget.TextType().Should().Be(type);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Counter(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      var widget = new MailRuLikeButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IMailRuLikeButtonWidget widget)
    {
      widget.Counter(enabled).Should().BeSameAs(widget);
      widget.Counter().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.CounterPosition(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void CounterPosition_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().CounterPosition(null)).ThrowExactly<ArgumentNullException>().WithParameterName("position");
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().CounterPosition(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("position");

      var widget = new MailRuLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string position, IMailRuLikeButtonWidget widget)
    {
      widget.CounterPosition(position).Should().BeSameAs(widget);
      widget.CounterPosition().Should().Be(position);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuLikeButtonWidget(), """<a class="mrc__plugin_uber_like_button" data-mrc-config="{&quot;sz&quot;:&quot;20&quot;,&quot;st&quot;:1,&quot;tp&quot;:&quot;combo&quot;,&quot;cm&quot;:1,&quot;ck&quot;:1}" href="http://connect.mail.ru/share" target="_blank">Нравится</a>""");
      Validate(new MailRuLikeButtonWidget().Size(MailRuLikeButtonSize.Size30).Layout(MailRuLikeButtonLayout.Second).Type(MailRuLikeButtonType.MailRu).Counter(true).CounterPosition(MailRuLikeButtonCounterPosition.Upper).Text(false), """<a class="mrc__plugin_uber_like_button" data-mrc-config="{&quot;sz&quot;:&quot;30&quot;,&quot;st&quot;:2,&quot;tp&quot;:&quot;mm&quot;,&quot;vt&quot;:1,&quot;nt&quot;:1}" href="http://connect.mail.ru/share" target="_blank">Нравится</a>""");
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