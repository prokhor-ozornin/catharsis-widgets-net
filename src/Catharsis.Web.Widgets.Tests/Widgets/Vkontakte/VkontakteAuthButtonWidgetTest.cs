using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteAuthButtonWidget"/>.</para>
/// </summary>
public sealed class VkontakteAuthButtonWidgetTest : UnitTest
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
    widget.GetPropertyValue<string>("CallbackProperty").Should().BeNull();
    widget.GetPropertyValue<string>("ElementIdProperty").Should().BeNull();
    widget.GetPropertyValue<VkontakteAuthButtonType>("TypeProperty").Should().Be(VkontakteAuthButtonType.Standard);
    widget.GetPropertyValue<string>("UrlProperty").Should().BeNull();
    widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteAuthButtonWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ElementIdProperty").Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontakteAuthButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IVkontakteAuthButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("UrlProperty").Should().Be(url);
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
      widget.GetPropertyValue<VkontakteAuthButtonType>("TypeProperty").Should().Be(type);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Callback(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Callback_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Callback(null)).ThrowExactly<ArgumentNullException>().WithParameterName("callback");
      AssertionExtensions.Should(() => new VkontakteAuthButtonWidget().Callback(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("callback");

      var widget = new VkontakteAuthButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string callback, IVkontakteAuthButtonWidget widget)
    {
      widget.Callback(callback).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("CallbackProperty").Should().Be(callback);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteAuthButtonWidget());
      Validate(new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Standard));
      Validate(new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Dynamic));
      Validate(new VkontakteAuthButtonWidget().Standard("url"), """<div id="vk_auth"></div><script type="text/javascript">VK.Widgets.Auth("vk_auth", {"authUrl":"url"});</script>""");
      Validate(new VkontakteAuthButtonWidget().Dynamic("callback"), """<div id="vk_auth"></div><script type="text/javascript">VK.Widgets.Auth("vk_auth", {"onAuth":"callback"});</script>""");
      Validate(new VkontakteAuthButtonWidget().Standard("url").ElementId("elementId").Width("width"), """<div id="elementId"></div><script type="text/javascript">VK.Widgets.Auth("elementId", {"authUrl":"url","width":"width"});</script>""");
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