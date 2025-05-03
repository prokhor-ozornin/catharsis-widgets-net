using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteLikeButtonWidget"/>.</para>
/// </summary>
public sealed class VkontakteLikeButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteLikeButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteLikeButtonWidget();
      widget.GetPropertyValue<string>("ElementIdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TextProperty").Should().BeNull();
      widget.GetPropertyValue<byte?>("VerbProperty").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
      widget.GetPropertyValue<string>("TitleProperty").Should().BeNull();
      widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("DescriptionProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ImageProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IVkontakteLikeButtonWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Text(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("text");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Text(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("text");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string text, IVkontakteLikeButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextProperty").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Verb(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteLikeButtonWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte verb, IVkontakteLikeButtonWidget widget) => widget.Verb(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("VerbProperty").Should().Be(verb);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Layout(null)).ThrowExactly<ArgumentNullException>().WithParameterName("layout");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("layout");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string layout, IVkontakteLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutProperty").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IVkontakteLikeButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IVkontakteLikeButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Title(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Title_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Title(null)).ThrowExactly<ArgumentNullException>().WithParameterName("title");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Title(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("title");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string title, IVkontakteLikeButtonWidget widget) => widget.Title(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleProperty").Should().Be(title);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IVkontakteLikeButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Description(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Description_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Description(null)).ThrowExactly<ArgumentNullException>().WithParameterName("description");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Description(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("description");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string description, IVkontakteLikeButtonWidget widget) => widget.Description(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionProperty").Should().Be(description);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Image(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Image_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Image(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new VkontakteLikeButtonWidget().Image(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new VkontakteLikeButtonWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IVkontakteLikeButtonWidget widget) => widget.Image(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageProperty").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteLikeButtonWidget());
      Validate(Attributes.VkontakteLikeButtonWidget());
    }

    return;

    static void Validate(IVkontakteLikeButtonWidget original)
    {
      var clone = original.Clone<IVkontakteLikeButtonWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteLikeButtonWidget(), """<div id="vk_like"></div>""", """<script type="text/javascript">""", """VK.Widgets.Like("vk_like", {});""");
      Validate(new VkontakteLikeButtonWidget().Layout(VkontakteLikeButtonLayout.Button).ElementId("elementId").Width("width").Title("title").Description("description").Url("url").Image("image").Text("text").Height("height").Verb(1), """<div id="elementId"></div>""", """<script type="text/javascript">""", """VK.Widgets.Like("elementId", {"type":"button","width":"width","pageTitle":"title","pageDescription":"description","pageUrl":"url","pageImage":"image","text":"text","height":"height","verb":1});""");
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