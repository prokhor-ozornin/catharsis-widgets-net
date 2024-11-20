using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteSubscriptionWidget"/>.</para>
/// </summary>
public sealed class VkontakteSubscriptionWidgetTests : ClassTest<VkontakteSubscriptionWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteSubscriptionWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteSubscriptionWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteSubscriptionWidget>();

    var widget = new VkontakteSubscriptionWidget();
    Assert.Null(widget.Account().Should().BeNull());
    Assert.Null(widget.ElementId().Should().BeNull());
    widget.Layout().Should().Be((byte) VkontakteSubscriptionButtonLayout.Button);
    widget.OnlyButton().Should().BeFalse();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteSubscriptionWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new VkontakteSubscriptionWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteSubscriptionWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IVkontakteSubscriptionWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteSubscriptionWidget().ElementId(null));
    Assert.Throws<ArgumentException>(() => new VkontakteSubscriptionWidget().ElementId(string.Empty));

    var widget = new VkontakteSubscriptionWidget();
    Assert.Null(widget.ElementId());
    Assert.True(ReferenceEquals(widget.ElementId("elementId"), widget));
    Assert.Equal("elementId", widget.ElementId());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Layout(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    var widget = new VkontakteSubscriptionWidget();
    Assert.Equal((byte)VkontakteSubscriptionButtonLayout.Button, widget.Layout());
    Assert.True(ReferenceEquals(widget.Layout(2), widget));
    Assert.Equal(2, widget.Layout());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.OnlyButton(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void OnlyButton_Method()
  {
    var widget = new VkontakteSubscriptionWidget();
    Assert.False(widget.OnlyButton());
    Assert.True(ReferenceEquals(widget.OnlyButton(true), widget));
    Assert.True(widget.OnlyButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new VkontakteSubscriptionWidget().ToString());

    var html = new VkontakteSubscriptionWidget().Account("account").ToString();
    Assert.True(html.Contains("""<div id="vk_subscribe_account"></div>"""));
    Assert.True(html.Contains("""
                              VK.Widgets.Subscribe("vk_subscribe_account", {"mode":0}, "account"
                              """));

    html = new VkontakteSubscriptionWidget().Account("account").Layout(VkontakteSubscriptionButtonLayout.LightButton).ElementId("elementId").OnlyButton(true).ToString();
    Assert.True(html.Contains("""<div id="elementId"></div>"""));
    Assert.True(html.Contains("""
                              VK.Widgets.Subscribe("elementId", {"mode":1,"soft":1}, "account"
                              """));
  }
}