using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontaktePostWidget"/>.</para>
/// </summary>
public sealed class VkontaktePostWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("ElementIdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HashProperty").Should().BeNull();
      widget.GetPropertyValue<string>("IdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("OwnerProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
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

      new VkontaktePostWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IVkontaktePostWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdProperty").Should().Be(id);
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

      new VkontaktePostWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string hash, IVkontaktePostWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashProperty").Should().Be(hash);
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

      new VkontaktePostWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IVkontaktePostWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.Owner(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Owner_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontaktePostWidget().Owner(null)).ThrowExactly<ArgumentNullException>().WithParameterName("owner");
      AssertionExtensions.Should(() => new VkontaktePostWidget().Owner(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("owner");

      new VkontaktePostWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string owner, IVkontaktePostWidget widget) => widget.Owner(owner).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("OwnerProperty").Should().Be(owner);
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

      new VkontaktePostWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IVkontaktePostWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontaktePostWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontaktePostWidget());
      Validate(new VkontaktePostWidget().Owner("owner").Hash("hash"));
      Validate(new VkontaktePostWidget().Id("id").Owner("owner"));
      Validate(new VkontaktePostWidget().Id("id").Hash("hash"));
      Validate(new VkontaktePostWidget().Id("id").Owner("owner").Hash("hash"), """<div id="vk_post_owner_id"></div><script type="text/javascript">(function() { window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post("vk_post_owner_id", owner, id, "hash", {}) || setTimeout(arguments.callee, 50); }());</script>""");
      Validate(new VkontaktePostWidget().Id("id").Owner("owner").Hash("hash").ElementId("elementId").Width("width"), """<div id="elementId"></div><script type="text/javascript">(function() { window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post("elementId", owner, id, "hash", {"width":"width"}) || setTimeout(arguments.callee, 50); }());</script>""");
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