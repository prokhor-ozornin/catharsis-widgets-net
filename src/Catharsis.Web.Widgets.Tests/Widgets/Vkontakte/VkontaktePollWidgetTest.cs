using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontaktePollWidget"/>.</para>
/// </summary>
public sealed class VkontaktePollWidgetTest : Test
{
  private IVkontaktePollWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontaktePollWidgetTest() => Widget = Fixture<IVkontaktePollWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontaktePollWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontaktePollWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontaktePollWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontaktePollWidget();
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePollWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontaktePollWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IVkontaktePollWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePollWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontaktePollWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IVkontaktePollWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePollWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new VkontaktePollWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return; 

    static void Test(string url, IVkontaktePollWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePollWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VkontaktePollWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IVkontaktePollWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontaktePollWidget());
      Test(Fixture<VkontaktePollWidget>.Create());
    }

    return;

    static void Test(IVkontaktePollWidget original)
    {
      var clone = original.Clone<IVkontaktePollWidget>();

      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontaktePollWidget());
      Test(new VkontaktePollWidget().Id("id"), """<div id="vk_poll_id"></div><script type="text/javascript">VK.Widgets.Poll("vk_poll_id", {}, "id");</script>""");
      Test(new VkontaktePollWidget().Id("id").Url("url").Width("width").ElementId("elementId"), """<div id="elementId"></div><script type="text/javascript">VK.Widgets.Poll("elementId", {"pageUrl":"url","width":"width"}, "id");</script>""");
      Test(Fixture<VkontaktePollWidget>.Create());
    }

    return;

    static void Test(IVkontaktePollWidget widget, params string[] html)
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