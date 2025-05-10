using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteSubscriptionWidget"/>.</para>
/// </summary>
public sealed class VkontakteSubscriptionWidgetTest : Test
{
  private IVkontakteSubscriptionWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteSubscriptionWidgetTest() => Widget = Fixture.Create<IVkontakteSubscriptionWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteSubscriptionWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteSubscriptionWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteSubscriptionWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteSubscriptionWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<byte>("LayoutValue").Should().Be((byte) VkontakteSubscriptionButtonLayout.Button);
      widget.GetPropertyValue<bool>("OnlyButtonValue").Should().BeFalse();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteSubscriptionWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new VkontakteSubscriptionWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, IVkontakteSubscriptionWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteSubscriptionWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteSubscriptionWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IVkontakteSubscriptionWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Layout(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture.Create<byte>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte layout, IVkontakteSubscriptionWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LayoutValue").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.OnlyButton(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnlyButton_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IVkontakteSubscriptionWidget widget) => widget.OnlyButton(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("OnlyButtonValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteSubscriptionWidget());
      Test(Fixture.Create<VkontakteSubscriptionWidget>());
    }

    return;

    static void Test(IVkontakteSubscriptionWidget original)
    {
      var clone = original.Clone<IVkontakteSubscriptionWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<byte>("LayoutValue").Should().Be(original.GetPropertyValue<byte>("LayoutValue"));
      clone.GetPropertyValue<bool>("OnlyButtonValue").Should().Be(original.GetPropertyValue<bool>("OnlyButtonValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteSubscriptionWidget());
      Test(new VkontakteSubscriptionWidget().Account("account"), """<div id="vk_subscribe_account"></div>""", """
                                                                                                                  VK.Widgets.Subscribe("vk_subscribe_account", {"mode":0}, "account"
                                                                                                                  """);
      Test(new VkontakteSubscriptionWidget().Account("account").Layout(VkontakteSubscriptionButtonLayout.LightButton).ElementId("elementId").OnlyButton(true), """<div id="elementId"></div>""", """
                                                                                                                                                                                                      VK.Widgets.Subscribe("elementId", {"mode":1,"soft":1}, "account"
                                                                                                                                                                                                      """);
      Test(Fixture.Create<VkontakteSubscriptionWidget>());
    }

    return;

    static void Test(IVkontakteSubscriptionWidget widget, params string[] html)
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