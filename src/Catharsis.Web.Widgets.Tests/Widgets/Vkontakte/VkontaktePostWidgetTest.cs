using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontaktePostWidget"/>.</para>
/// </summary>
/// <seealso cref="VkontaktePostWidget"/>
public sealed class VkontaktePostWidgetTest : Test
{
  private IVkontaktePostWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontaktePostWidgetTest() => Widget = Fixture<IVkontaktePostWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontaktePostWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontaktePostWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontaktePostWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontaktePostWidget();
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<string>("HashValue").Should().BeNull();
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("OwnerValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePostWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontaktePostWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IVkontaktePostWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.Hash(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hash_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePostWidget().Hash(null)).ThrowExactly<ArgumentNullException>().WithParameterName("hash");
      AssertionExtensions.Should(() => new VkontaktePostWidget().Hash(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("hash");

      new[] { Fixture<string>.Create() }.ForEach(hash => Test(hash, Widget));
    }

    return;

    static void Test(string hash, IVkontaktePostWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashValue").Should().Be(hash);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePostWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontaktePostWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IVkontaktePostWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.Owner(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Owner_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePostWidget().Owner(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontaktePostWidget().Owner(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(owner => Test(owner, Widget));
    }

    return;

    static void Test(string owner, IVkontaktePostWidget widget) => widget.Owner(owner).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("OwnerValue").Should().Be(owner);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePostWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VkontaktePostWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(string width, IVkontaktePostWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontaktePostWidget());
      Test(Fixture<VkontaktePostWidget>.Create());
    }

    return;

    static void Test(IVkontaktePostWidget original)
    {
      var clone = original.Clone<IVkontaktePostWidget>();

      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<string>("HashValue").Should().Be(original.GetPropertyValue<string>("HashValue"));
      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<string>("OwnerValue").Should().Be(original.GetPropertyValue<string>("OwnerValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontaktePostWidget());
      Test(new VkontaktePostWidget().Owner("owner").Hash("hash"));
      Test(new VkontaktePostWidget().Id("id").Owner("owner"));
      Test(new VkontaktePostWidget().Id("id").Hash("hash"));
      Test(new VkontaktePostWidget().Id("id").Owner("owner").Hash("hash"), """<div id="vk_post_owner_id"></div><script type="text/javascript">(function() { window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post("vk_post_owner_id", owner, id, "hash", {}) || setTimeout(arguments.callee, 50); }());</script>""");
      Test(new VkontaktePostWidget().Id("id").Owner("owner").Hash("hash").ElementId("elementId").Width("width"), """<div id="elementId"></div><script type="text/javascript">(function() { window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post("elementId", owner, id, "hash", {"width":"width"}) || setTimeout(arguments.callee, 50); }());</script>""");
      Test(Fixture<VkontaktePostWidget>.Create());
    }

    return;

    static void Test(IVkontaktePostWidget widget, params string[] html)
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