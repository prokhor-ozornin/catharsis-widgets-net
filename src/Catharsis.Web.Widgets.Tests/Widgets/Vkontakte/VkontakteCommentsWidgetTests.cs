using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteCommentsWidget"/>.</para>
/// </summary>
public sealed class VkontakteCommentsWidgetTests : ClassTest<VkontakteCommentsWidget>
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
    widget.Attach().Should().BeEmpty();
    widget.AutoPublish().Should().BeNull();
    widget.AutoUpdate().Should().BeNull();
    widget.ElementId().Should().BeNull();
    widget.Limit().Should().Be((byte) VkontakteCommentsLimit.Limit5);
    widget.Mini().Should().BeNull();
    widget.Width().Should().BeNull();
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
      widget.Limit().Should().Be(limit);
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
      AssertionExtensions.Should(() => new VkontakteCommentsWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("id");

      var widget = new VkontakteCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteCommentsWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.ElementId().Should().Be(id);
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
      widget.Attach().Should().Equal(types);
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
      AssertionExtensions.Should(() => new VkontakteCommentsWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("width");

      var widget = new VkontakteCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontakteCommentsWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
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
      widget.AutoPublish().Should().Be(enabled);
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
      widget.AutoUpdate().Should().Be(enabled);
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
      widget.Mini().Should().Be(enabled);
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