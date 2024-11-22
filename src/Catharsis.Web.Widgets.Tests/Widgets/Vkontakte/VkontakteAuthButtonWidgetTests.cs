using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteAuthButtonWidget"/>.</para>
/// </summary>
public sealed class VkontakteAuthButtonWidgetTests : ClassTest<VkontakteAuthButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteAuthButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteAuthButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteAuthButtonWidget>();

    var widget = new VkontakteAuthButtonWidget();
    widget.Callback().Should().BeNull();
    widget.ElementId().Should().BeNull();
    widget.Type().Should().Be(VkontakteAuthButtonType.Standard);
    widget.Url().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().ElementId(null));
    Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().ElementId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteAuthButtonWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.ElementId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontakteAuthButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IVkontakteAuthButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Type(VkontakteAuthButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteAuthButtonWidget();
      Enum.GetValues<VkontakteAuthButtonType>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteAuthButtonType type, IVkontakteAuthButtonWidget widget)
    {
      widget.Type(type).Should().BeSameAs(widget);
      widget.Type().Should().Be(type);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Callback(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Callback_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Callback(null));
    Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Callback(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string callback, IVkontakteAuthButtonWidget widget)
    {
      widget.Callback(callback).Should().BeSameAs(widget);
      widget.Callback().Should().Be(callback);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new VkontakteAuthButtonWidget().ToString());
    Assert.Equal(string.Empty, new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Standard).ToString());
    Assert.Equal(string.Empty, new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Dynamic).ToString());
    Assert.Equal("""<div id="vk_auth"></div><script type="text/javascript">VK.Widgets.Auth("vk_auth", {"authUrl":"url"});</script>""", new VkontakteAuthButtonWidget().Standard("url").ToString());
    Assert.Equal("""<div id="vk_auth"></div><script type="text/javascript">VK.Widgets.Auth("vk_auth", {"onAuth":"callback"});</script>""", new VkontakteAuthButtonWidget().Dynamic("callback").ToString());
    Assert.Equal("""<div id="elementId"></div><script type="text/javascript">VK.Widgets.Auth("elementId", {"authUrl":"url","width":"width"});</script>""", new VkontakteAuthButtonWidget().Standard("url").ElementId("elementId").Width("width").ToString());
  }
}