using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YouTubeVideoWidget"/>.</para>
/// </summary>
public sealed class YouTubeVideoWidgetTests : ClassTest<YouTubeVideoWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YouTubeVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YouTubeVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYouTubeVideoWidget>();

    var widget = new YouTubeVideoWidget();
    widget.Id().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.PrivateMode().Should().BeFalse();
    widget.SecureMode().Should().BeFalse();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YouTubeVideoWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new YouTubeVideoWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YouTubeVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IYouTubeVideoWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YouTubeVideoWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new YouTubeVideoWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YouTubeVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IYouTubeVideoWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new YouTubeVideoWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new YouTubeVideoWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new YouTubeVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IYouTubeVideoWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.PrivateMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void PrivateMode_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YouTubeVideoWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYouTubeVideoWidget widget)
    {
      widget.PrivateMode(enabled).Should().BeSameAs(widget);
      widget.PrivateMode().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.SecureMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void SecureMode_Method()
  {
    using (new AssertionScope())
    {
      var widget = new YouTubeVideoWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IYouTubeVideoWidget widget)
    {
      widget.SecureMode(enabled).Should().BeSameAs(widget);
      widget.SecureMode().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new YouTubeVideoWidget());
      Validate(new YouTubeVideoWidget().Id("id").Height("height"));
      Validate(new YouTubeVideoWidget().Id("id").Width("width"));
      Validate(new YouTubeVideoWidget().Height("height").Width("width"));
      Validate(new YouTubeVideoWidget().Id("id").Height("height").Width("width"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://www.youtube.com/embed/id" webkitallowfullscreen="true" width="width"></iframe>""");
      Validate(new YouTubeVideoWidget().Id("id").Height("height").Width("width").PrivateMode(true).SecureMode(true), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="https://www.youtube-nocookie.com/embed/id" webkitallowfullscreen="true" width="width"></iframe>""");
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