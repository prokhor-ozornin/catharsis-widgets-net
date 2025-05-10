using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteAuthButtonWidget"/>.</para>
/// </summary>
public sealed class VkontakteAuthButtonWidgetTest : Test
{
  private IVkontakteAuthButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteAuthButtonWidgetTest() => Widget = Fixture.Create<IVkontakteAuthButtonWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteAuthButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteAuthButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteAuthButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteAuthButtonWidget();
      widget.GetPropertyValue<string>("CallbackValue").Should().BeNull();
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<VkontakteAuthButtonType>("TypeValue").Should().Be(VkontakteAuthButtonType.Standard);
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IVkontakteAuthButtonWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IVkontakteAuthButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string url, IVkontakteAuthButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Type(VkontakteAuthButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<VkontakteAuthButtonType>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(VkontakteAuthButtonType type, IVkontakteAuthButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<VkontakteAuthButtonType>("TypeValue").Should().Be(type);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string callback, IVkontakteAuthButtonWidget widget) => widget.Callback(callback).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CallbackValue").Should().Be(callback);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteAuthButtonWidget());
      Test(Fixture.Create<VkontakteAuthButtonWidget>());
    }

    return;

    static void Test(IVkontakteAuthButtonWidget original)
    {
      var clone = original.Clone<IVkontakteAuthButtonWidget>();

      clone.GetPropertyValue<string>("CallbackValue").Should().Be(original.GetPropertyValue<string>("CallbackValue"));
      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<VkontakteAuthButtonType>("TypeValue").Should().Be(original.GetPropertyValue<VkontakteAuthButtonType>("TypeValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
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
      Test(new VkontakteAuthButtonWidget());
      Test(new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Standard));
      Test(new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Dynamic));
      Test(new VkontakteAuthButtonWidget().Standard("url"), """<div id="vk_auth"></div><script type="text/javascript">VK.Widgets.Auth("vk_auth", {"authUrl":"url"});</script>""");
      Test(new VkontakteAuthButtonWidget().Dynamic("callback"), """<div id="vk_auth"></div><script type="text/javascript">VK.Widgets.Auth("vk_auth", {"onAuth":"callback"});</script>""");
      Test(new VkontakteAuthButtonWidget().Standard("url").ElementId("elementId").Width("width"), """<div id="elementId"></div><script type="text/javascript">VK.Widgets.Auth("elementId", {"authUrl":"url","width":"width"});</script>""");
      Test(Fixture.Create<VkontakteAuthButtonWidget>());
    }

    return;

    static void Test(IVkontakteAuthButtonWidget widget, params string[] html)
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