using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuVideoWidget"/>.</para>
/// </summary>
public sealed class MailRuVideoWidgetTests : ClassTest<MailRuVideoWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IMailRuVideoWidget>();

    var widget = new MailRuVideoWidget();
    widget.Id().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IMailRuVideoWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IMailRuVideoWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new MailRuVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IMailRuVideoWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new MailRuVideoWidget());
      Validate(new MailRuVideoWidget().Id("id").Height("height"));
      Validate(new MailRuVideoWidget().Id("id").Width("width"));
      Validate(new MailRuVideoWidget().Height("height").Width("width"));
      Validate(new MailRuVideoWidget().Id("id").Height("height").Width("width"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://api.video.mail.ru/videos/embed/mail/id" webkitallowfullscreen="true" width="width"></iframe>""");
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