using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteCommentsWidget"/>.</para>
/// </summary>
public sealed class VkontakteCommentsWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteCommentsWidget>();

    var widget = new VkontakteCommentsWidget();
    widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Should().BeEmpty();
    widget.GetPropertyValue<bool?>("AutoPublishProperty").Should().BeNull();
    widget.GetPropertyValue<bool?>("AutoUpdateProperty").Should().BeNull();
    widget.GetPropertyValue<string>("ElementIdProperty").Should().BeNull();
    widget.GetPropertyValue<byte>("LimitProperty").Should().Be((byte) VkontakteCommentsLimit.Limit5);
    widget.GetPropertyValue<bool?>("MiniProperty").Should().BeNull();
    widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Limit(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteCommentsWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte limit, IVkontakteCommentsWidget widget)
    {
      widget.Limit(limit).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("LimitProperty").Should().Be(limit);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommentsWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteCommentsWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      var widget = new VkontakteCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteCommentsWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ElementIdProperty").Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Attach(string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Attach_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommentsWidget().Attach(null)).ThrowExactly<ArgumentNullException>().WithParameterName("types");

      var widget = new VkontakteCommentsWidget();
      new string[][] { [string.Empty, "type"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string[] types, IVkontakteCommentsWidget widget)
    {
      widget.Attach(types).Should().BeSameAs(widget);
      widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Should().Equal(types);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommentsWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VkontakteCommentsWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      var widget = new VkontakteCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontakteCommentsWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.AutoPublish(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AutoPublish_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteCommentsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IVkontakteCommentsWidget widget)
    {
      widget.AutoPublish(enabled).Should().BeSameAs(widget);
      widget.GetPropertyValue<bool?>("AutoPublishProperty").Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.AutoUpdate(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AutoUpdate_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteCommentsWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IVkontakteCommentsWidget widget)
    {
      widget.AutoUpdate(enabled).Should().BeSameAs(widget);
      widget.GetPropertyValue<bool?>("AutoUpdateProperty").Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Mini(bool?)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mini_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteCommentsWidget();
      new bool?[] { null, false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool? enabled, IVkontakteCommentsWidget widget)
    {
      widget.Mini(enabled).Should().BeSameAs(widget);
      widget.GetPropertyValue<bool?>("MiniProperty").Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteCommentsWidget(), """<div id="vk_comments"></div>""", """<script type="text/javascript">""", """VK.Widgets.Comments("vk_comments", {"limit":5,"attach":false});""");
      Validate(new VkontakteCommentsWidget().Limit(10).Attach(VkontakteCommentsAttach.All).Width("width").AutoPublish(true).AutoUpdate(true).ElementId("elementId").Mini(true), """<div id="elementId"></div>""", """<script type="text/javascript">""", """VK.Widgets.Comments("elementId", {"limit":10,"attach":"*","width":"width","autoPublish":1,"norealtime":0,"mini":1});""");
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