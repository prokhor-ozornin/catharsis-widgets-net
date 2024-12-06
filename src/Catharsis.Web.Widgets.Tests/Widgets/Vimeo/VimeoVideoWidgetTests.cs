using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VimeoVideoWidget"/>.</para>
/// </summary>
public sealed class VimeoVideoWidgetTests : ClassTest<VimeoVideoWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VimeoVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VimeoVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVimeoVideoWidget>();

    var widget = new VimeoVideoWidget();
    widget.Id().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.AutoPlay().Should().BeFalse();
    widget.Loop().Should().BeFalse();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new VimeoVideoWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VimeoVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVimeoVideoWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VimeoVideoWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VimeoVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVimeoVideoWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new VimeoVideoWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VimeoVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IVimeoVideoWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.AutoPlay(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AutoPlay_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VimeoVideoWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IVimeoVideoWidget widget)
    {
      widget.AutoPlay(enabled).Should().BeSameAs(widget);
      widget.AutoPlay().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Loop(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Loop_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VimeoVideoWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IVimeoVideoWidget widget)
    {
      widget.Loop(enabled).Should().BeSameAs(widget);
      widget.Loop().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VimeoVideoWidget());
      Validate(new VimeoVideoWidget().Id("id").Height("height"));
      Validate(new VimeoVideoWidget().Id("id").Width("width"));
      Validate(new VimeoVideoWidget().Height("height").Width("width"));
      Validate(new VimeoVideoWidget().Id("id").Height("height").Width("width"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="https://player.vimeo.com/video/id?badge=0" webkitallowfullscreen="true" width="width"></iframe>""");
      Validate(new VimeoVideoWidget().Id("id").Height("height").Width("width").AutoPlay(true).Loop(true), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="https://player.vimeo.com/video/id?badge=0&amp;autoplay=1&amp;loop=1" webkitallowfullscreen="true" width="width"></iframe>""");
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