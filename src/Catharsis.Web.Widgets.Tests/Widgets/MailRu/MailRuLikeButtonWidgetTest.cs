using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuLikeButtonWidget"/>.</para>
/// </summary>
public sealed class MailRuLikeButtonWidgetTest : Test
{
  private IMailRuLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public MailRuLikeButtonWidgetTest() => Widget = Fixture.Create<IMailRuLikeButtonWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuLikeButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new MailRuLikeButtonWidget();
      widget.GetPropertyValue<string>("TypeValue").Should().Be("combo");
      widget.GetPropertyValue<string>("SizeValue").Should().Be("20");
      widget.GetPropertyValue<byte>("LayoutValue").Should().Be((byte) MailRuLikeButtonLayout.First);
      widget.GetPropertyValue<bool>("TextValue").Should().BeTrue();
      widget.GetPropertyValue<byte>("TextTypeValue").Should().Be((byte) MailRuLikeButtonTextType.First);
      widget.GetPropertyValue<bool>("CounterValue").Should().BeTrue();
      widget.GetPropertyValue<string>("CounterPositionValue").Should().Be(nameof(MailRuLikeButtonCounterPosition.Right).ToLowerInvariant());
    }
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
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().Type(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("type");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string type, IMailRuLikeButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TypeValue").Should().Be(type);
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
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().Size(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string size, IMailRuLikeButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Layout(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(byte layout, IMailRuLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LayoutValue").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Text(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IMailRuLikeButtonWidget widget) => widget.Text(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("TextValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.TextType(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextType_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(byte type, IMailRuLikeButtonWidget widget) => widget.TextType(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextTypeValue").Should().Be(type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Counter(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Counter_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IMailRuLikeButtonWidget widget) => widget.Counter(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("CounterValue").Should().Be(enabled);
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
      AssertionExtensions.Should(() => new MailRuLikeButtonWidget().CounterPosition(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("position");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string position, IMailRuLikeButtonWidget widget) => widget.CounterPosition(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CounterPositionValue").Should().Be(position);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuLikeButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuLikeButtonWidget());
      Validate(Fixture.Create<IMailRuLikeButtonWidget>());
    }

    return;

    static void Validate(IMailRuLikeButtonWidget original)
    {
      var clone = original.Clone<IMailRuLikeButtonWidget>();

      clone.GetPropertyValue<string>("TypeValue").Should().Be(original.GetPropertyValue<string>("TypeValue"));
      clone.GetPropertyValue<string>("SizeValue").Should().Be(original.GetPropertyValue<string>("SizeValue"));
      clone.GetPropertyValue<byte>("LayoutValue").Should().Be(original.GetPropertyValue<byte>("LayoutValue"));
      clone.GetPropertyValue<byte>("TextValue").Should().Be(original.GetPropertyValue<byte>("TextValue"));
      clone.GetPropertyValue<bool>("TextTypeValue").Should().Be(original.GetPropertyValue<bool>("TextTypeValue"));
      clone.GetPropertyValue<byte>("TextTypeValue").Should().Be(original.GetPropertyValue<byte>("TextTypeValue"));
      clone.GetPropertyValue<bool>("CounterValue").Should().Be(original.GetPropertyValue<bool>("CounterValue"));
      clone.GetPropertyValue<string>("CounterPositionValue").Should().Be(original.GetPropertyValue<string>("CounterPositionValue"));
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
      Validate(Fixture.Create<IMailRuLikeButtonWidget>());
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