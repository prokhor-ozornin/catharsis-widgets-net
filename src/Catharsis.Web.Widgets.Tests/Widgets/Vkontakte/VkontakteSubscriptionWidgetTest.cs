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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string account, IVkontakteSubscriptionWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string id, IVkontakteSubscriptionWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Layout(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(byte layout, IVkontakteSubscriptionWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LayoutValue").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.OnlyButton(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnlyButton_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IVkontakteSubscriptionWidget widget) => widget.OnlyButton(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("OnlyButtonValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteSubscriptionWidget());
      Validate(Fixture.Create<IVkontakteSubscriptionWidget>());
    }

    return;

    static void Validate(IVkontakteSubscriptionWidget original)
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
      Validate(new VkontakteSubscriptionWidget());
      Validate(new VkontakteSubscriptionWidget().Account("account"), """<div id="vk_subscribe_account"></div>""", """
                                                                                                                  VK.Widgets.Subscribe("vk_subscribe_account", {"mode":0}, "account"
                                                                                                                  """);
      Validate(new VkontakteSubscriptionWidget().Account("account").Layout(VkontakteSubscriptionButtonLayout.LightButton).ElementId("elementId").OnlyButton(true), """<div id="elementId"></div>""", """
                                                                                                                                                                                                      VK.Widgets.Subscribe("elementId", {"mode":1,"soft":1}, "account"
                                                                                                                                                                                                      """);
      Validate(Fixture.Create<IVkontakteSubscriptionWidget>());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
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