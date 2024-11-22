using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontaktePollWidget"/>.</para>
/// </summary>
public sealed class VkontaktePollWidgetTests : ClassTest<VkontaktePollWidget>
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
    widget.ElementId().Should().BeNull();
    widget.Id().Should().BeNull();
    widget.Url().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().ElementId(null));
    Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().ElementId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontaktePollWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.ElementId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontaktePollWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return; 

    static void Validate(string url, IVkontaktePollWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontaktePollWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontaktePollWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePollWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new VkontaktePollWidget().ToString());
    Assert.Equal("""<div id="vk_poll_id"></div><script type="text/javascript">VK.Widgets.Poll("vk_poll_id", {}, "id");</script>""", new VkontaktePollWidget().Id("id").ToString());
    Assert.Equal("""<div id="elementId"></div><script type="text/javascript">VK.Widgets.Poll("elementId", {"pageUrl":"url","width":"width"}, "id");</script>""", new VkontaktePollWidget().Id("id").Url("url").Width("width").ElementId("elementId").ToString());
  }
}