using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteSubscriptionWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteSubscriptionWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontakteSubscriptionWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteSubscriptionWidget();
      Assert.Null(widget.Account());
      Assert.Equal((byte)VkontakteSubscribeButtonLayout.First, widget.Layout());
      Assert.False(widget.OnlyButton());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteSubscriptionWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new VkontakteSubscriptionWidget().Account(string.Empty));

      var widget = new VkontakteSubscriptionWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Layout(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      var widget = new VkontakteSubscriptionWidget();
      Assert.Equal((byte)VkontakteSubscribeButtonLayout.First, widget.Layout());
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
    ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VkontakteSubscriptionWidget().ToString());

      var html = new VkontakteSubscriptionWidget().Account("account").ToString();
      Assert.True(html.Contains(@"<div id=""vk_subscribe""></div>"));
      Assert.True(html.Contains(@"VK.Widgets.Subscribe(""vk_subscribe"", {""mode"":1}, ""account"""));

      html = new VkontakteSubscriptionWidget().Account("account").Layout(VkontakteSubscribeButtonLayout.Second).OnlyButton(true).ToString();
      Assert.True(html.Contains(@"<div id=""vk_subscribe""></div>"));
      Assert.True(html.Contains(@"VK.Widgets.Subscribe(""vk_subscribe"", {""mode"":2,""soft"":1}, ""account"""));
    }
  }
}