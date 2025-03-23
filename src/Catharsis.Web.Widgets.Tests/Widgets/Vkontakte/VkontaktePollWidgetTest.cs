using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontaktePollWidget"/>.</para>
/// </summary>
public sealed class VkontaktePollWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontaktePollWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontaktePollWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontaktePollWidget>();

    var widget = new VkontaktePollWidget();
    widget.GetPropertyValue<string>("ElementIdProperty").Should().BeNull();
    widget.GetPropertyValue<string>("IdProperty").Should().BeNull();
    widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
    widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
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

      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontaktePollWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ElementIdProperty").Should().Be(id);
    }
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

      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontaktePollWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("IdProperty").Should().Be(id);
    }
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

      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return; 

    static void Validate(string url, IVkontaktePollWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("UrlProperty").Should().Be(url);
    }
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

      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontaktePollWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width);
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
      Validate(new VkontaktePollWidget());
      Validate(new VkontaktePollWidget().Id("id"), """<div id="vk_poll_id"></div><script type="text/javascript">VK.Widgets.Poll("vk_poll_id", {}, "id");</script>""");
      Validate(new VkontaktePollWidget().Id("id").Url("url").Width("width").ElementId("elementId"), """<div id="elementId"></div><script type="text/javascript">VK.Widgets.Poll("elementId", {"pageUrl":"url","width":"width"}, "id");</script>""");
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