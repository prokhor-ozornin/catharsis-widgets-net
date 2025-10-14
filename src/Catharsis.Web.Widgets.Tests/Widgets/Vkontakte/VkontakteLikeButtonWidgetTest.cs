using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteLikeButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="VkontakteLikeButtonWidget"/>
public sealed class VkontakteLikeButtonWidgetTest : Test
{
  private IVkontakteLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteLikeButtonWidgetTest() => Widget = Fixture<IVkontakteLikeButtonWidget>.Create();

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
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<string>("TextValue").Should().BeNull();
      widget.GetPropertyValue<byte?>("VerbValue").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<string>("TitleValue").Should().BeNull();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("DescriptionValue").Should().BeNull();
      widget.GetPropertyValue<string>("ImageValue").Should().BeNull();
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

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IVkontakteLikeButtonWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
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

      new[] { Fixture<string>.Create() }.ForEach(text => Test(text, Widget));
    }

    return;

    static void Test(string text, IVkontakteLikeButtonWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextValue").Should().Be(text);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Verb(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(verb => Test(verb, Widget));
    }

    return;

    static void Test(byte verb, IVkontakteLikeButtonWidget widget) => widget.Verb(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("VerbValue").Should().Be(verb);
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

      new[] { Fixture<string>.Create() }.ForEach(layout => Test(layout, Widget));
    }

    return;

    static void Test(string layout, IVkontakteLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout);
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

      new[] { Fixture<string>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(string width, IVkontakteLikeButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
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

      new[] { Fixture<string>.Create() }.ForEach(height => Test(height, Widget));
    }

    return;

    static void Test(string height, IVkontakteLikeButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
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

      new[] { Fixture<string>.Create() }.ForEach(title => Test(title, Widget));
    }

    return;

    static void Test(string title, IVkontakteLikeButtonWidget widget) => widget.Title(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TitleValue").Should().Be(title);
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

      new[] { Fixture<string>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(string url, IVkontakteLikeButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
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

      new[] { Fixture<string>.Create() }.ForEach(description => Test(description, Widget));
    }

    return;

    static void Test(string description, IVkontakteLikeButtonWidget widget) => widget.Description(description).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DescriptionValue").Should().Be(description);
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

      new[] { Fixture<string>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(string url, IVkontakteLikeButtonWidget widget) => widget.Image(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ImageValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteLikeButtonWidget());
      Test(Fixture<VkontakteLikeButtonWidget>.Create());
    }

    return;

    static void Test(IVkontakteLikeButtonWidget original)
    {
      var clone = original.Clone<IVkontakteLikeButtonWidget>();

      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<string>("TextValue").Should().Be(original.GetPropertyValue<string>("TextValue"));
      clone.GetPropertyValue<byte?>("VerbValue").Should().Be(original.GetPropertyValue<byte?>("VerbValue"));
      clone.GetPropertyValue<string>("LayoutValue").Should().Be(original.GetPropertyValue<string>("LayoutValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("TitleValue").Should().Be(original.GetPropertyValue<string>("TitleValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("DescriptionValue").Should().Be(original.GetPropertyValue<string>("DescriptionValue"));
      clone.GetPropertyValue<string>("ImageValue").Should().Be(original.GetPropertyValue<string>("ImageValue"));
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
      Test(new VkontakteLikeButtonWidget(), """<div id="vk_like"></div>""", """<script type="text/javascript">""", """VK.Widgets.Like("vk_like", {});""");
      Test(new VkontakteLikeButtonWidget().Layout(VkontakteLikeButtonLayout.Button).ElementId("elementId").Width("width").Title("title").Description("description").Url("url").Image("image").Text("text").Height("height").Verb(1), """<div id="elementId"></div>""", """<script type="text/javascript">""", """VK.Widgets.Like("elementId", {"type":"button","width":"width","pageTitle":"title","pageDescription":"description","pageUrl":"url","pageImage":"image","text":"text","height":"height","verb":1});""");
      Test(Fixture<VkontakteLikeButtonWidget>.Create());
    }

    return;

    static void Test(IVkontakteLikeButtonWidget widget, params string[] html)
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