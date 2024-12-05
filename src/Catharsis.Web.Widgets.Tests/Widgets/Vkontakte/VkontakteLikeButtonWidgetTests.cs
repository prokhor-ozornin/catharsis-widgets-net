using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteLikeButtonWidget"/>.</para>
/// </summary>
public sealed class VkontakteLikeButtonWidgetTests : ClassTest<VkontakteLikeButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteLikeButtonWidget>();

    var widget = new VkontakteLikeButtonWidget();
    widget.ElementId().Should().BeNull();
    widget.Text().Should().BeNull();
    widget.Verb().Should().BeNull();
    widget.Layout().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Title().Should().BeNull();
    widget.Url().Should().BeNull();
    widget.Description().Should().BeNull();
    widget.Image().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().ElementId(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().ElementId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteLikeButtonWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.ElementId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Text(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Text(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Text(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string text, IVkontakteLikeButtonWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.Text().Should().Be(text);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Verb(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte verb, IVkontakteLikeButtonWidget widget)
    {
      widget.Verb(verb).Should().BeSameAs(widget);
      widget.Verb().Should().Be(verb);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Layout(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Layout(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string layout, IVkontakteLikeButtonWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.Layout().Should().Be(layout);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontakteLikeButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IVkontakteLikeButtonWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Title(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Title(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Title(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string title, IVkontakteLikeButtonWidget widget)
    {
      widget.Title(title).Should().BeSameAs(widget);
      widget.Title().Should().Be(title);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IVkontakteLikeButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Description(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Description(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string description, IVkontakteLikeButtonWidget widget)
    {
      widget.Description(description).Should().BeSameAs(widget);
      widget.Description().Should().Be(description);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Image(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Image(null));
    Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Image(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IVkontakteLikeButtonWidget widget)
    {
      widget.Image(url).Should().BeSameAs(widget);
      widget.Image().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    var html = new VkontakteLikeButtonWidget().ToString();
    Assert.True(html.Contains("""<div id="vk_like"></div>"""));
    Assert.True(html.Contains("""<script type="text/javascript">"""));
    Assert.True(html.Contains("""VK.Widgets.Like("vk_like", {});"""));

    html = new VkontakteLikeButtonWidget().Layout(VkontakteLikeButtonLayout.Button).ElementId("elementId").Width("width").Title("title").Description("description").Url("url").Image("image").Text("text").Height("height").Verb(1).ToString();
    Assert.True(html.Contains("""<div id="elementId"></div>"""));
    Assert.True(html.Contains("""<script type="text/javascript">"""));
    Assert.True(html.Contains("""VK.Widgets.Like("elementId", {"type":"button","width":"width","pageTitle":"title","pageDescription":"description","pageUrl":"url","pageImage":"image","text":"text","height":"height","verb":1});"""));

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