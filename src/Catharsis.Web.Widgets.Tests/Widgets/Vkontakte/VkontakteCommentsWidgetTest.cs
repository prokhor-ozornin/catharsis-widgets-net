using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteCommentsWidget"/>.</para>
/// </summary>
public sealed class VkontakteCommentsWidgetTest : Test
{
  private IVkontakteCommentsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteCommentsWidgetTest() => Widget = Fixture<IVkontakteCommentsWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteCommentsWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteCommentsWidget();
      widget.GetPropertyValue<IEnumerable<string>>("AttachValue").Should().BeEmpty();
      widget.GetPropertyValue<bool?>("AutoPublishValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("AutoUpdateValue").Should().BeNull();
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<byte>("LimitValue").Should().Be((byte) VkontakteCommentsLimit.Limit5);
      widget.GetPropertyValue<bool?>("MiniValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Limit(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte limit, IVkontakteCommentsWidget widget) => widget.Limit(limit).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LimitValue").Should().Be(limit);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IVkontakteCommentsWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Attach(string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Attach_Method()
  {
    using (new AssertionScope())
    {
      new string[][] { [string.Empty, Fixture<string>.Create()] }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string[] types, IVkontakteCommentsWidget widget) => widget.Attach(types).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("AttachValue").Should().Equal(types);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IVkontakteCommentsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.AutoPublish(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AutoPublish_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IVkontakteCommentsWidget widget) => widget.AutoPublish(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("AutoPublishValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.AutoUpdate(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AutoUpdate_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IVkontakteCommentsWidget widget) => widget.AutoUpdate(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("AutoUpdateValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Mini(bool?)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mini_Method()
  {
    using (new AssertionScope())
    {
      new bool?[] { null, false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool? enabled, IVkontakteCommentsWidget widget) => widget.Mini(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("MiniValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteCommentsWidget());
      Test(Fixture<VkontakteCommentsWidget>.Create());
    }

    return;

    static void Test(IVkontakteCommentsWidget original)
    {
      var clone = original.Clone<IVkontakteCommentsWidget>();

      clone.GetPropertyValue<IEnumerable<string>>("AttachValue").Should().Equal(original.GetPropertyValue<IEnumerable<string>>("AttachValue"));
      clone.GetPropertyValue<bool?>("AutoPublishValue").Should().Be(original.GetPropertyValue<bool?>("AutoPublishValue"));
      clone.GetPropertyValue<bool?>("AutoUpdateValue").Should().Be(original.GetPropertyValue<bool?>("AutoUpdateValue"));
      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<byte>("LimitValue").Should().Be(original.GetPropertyValue<byte>("LimitValue"));
      clone.GetPropertyValue<bool?>("MiniValue").Should().Be(original.GetPropertyValue<bool?>("MiniValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
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
      Test(new VkontakteCommentsWidget(), """<div id="vk_comments"></div>""", """<script type="text/javascript">""", """VK.Widgets.Comments("vk_comments", {"limit":5,"attach":false});""");
      Test(new VkontakteCommentsWidget().Limit(10).Attach(VkontakteCommentsAttach.All).Width("width").AutoPublish(true).AutoUpdate(true).ElementId("elementId").Mini(true), """<div id="elementId"></div>""", """<script type="text/javascript">""", """VK.Widgets.Comments("elementId", {"limit":10,"attach":"*","width":"width","autoPublish":1,"norealtime":0,"mini":1});""");
      Test(Fixture<VkontakteCommentsWidget>.Create());
    }

    return;

    static void Test(IVkontakteCommentsWidget widget, params string[] html)
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