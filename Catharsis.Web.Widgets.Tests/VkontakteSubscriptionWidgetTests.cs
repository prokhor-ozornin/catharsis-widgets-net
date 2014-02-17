using System;
using System.IO;
using Catharsis.Commons;
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
    ///   <seealso cref="VkontakteSubscriptionWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteSubscriptionWidget();
      Assert.Null(widget.Field("account"));
      Assert.Equal((byte)VkontakteSubscribeButtonLayout.First, widget.Field("layout").To<byte>());
      Assert.False(widget.Field("onlyButton").To<bool>());
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
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Layout(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      var widget = new VkontakteSubscriptionWidget();
      Assert.Equal((byte)VkontakteSubscribeButtonLayout.First, widget.Field("layout").To<byte>());
      Assert.True(ReferenceEquals(widget.Layout(2), widget));
      Assert.Equal(2, widget.Field("layout").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.OnlyButton(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void OnlyButton_Method()
    {
      var widget = new VkontakteSubscriptionWidget();
      Assert.False(widget.Field("onlyButton").To<bool>());
      Assert.True(ReferenceEquals(widget.OnlyButton(), widget));
      Assert.True(widget.Field("onlyButton").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteSubscriptionWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteSubscriptionWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new VkontakteSubscriptionWidget().Write(writer)).ToString().IsEmpty());
      
      new StringWriter().With(writer =>
      {
        new VkontakteSubscriptionWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_subscribe""></div>"));
        Assert.True(html.Contains(@"VK.Widgets.Subscribe(""vk_subscribe"", {""mode"":1}, ""account"""));
      });

      new StringWriter().With(writer =>
      {
        new VkontakteSubscriptionWidget().Account("account").Layout(VkontakteSubscribeButtonLayout.Second).OnlyButton().Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_subscribe""></div>"));
        Assert.True(html.Contains(@"VK.Widgets.Subscribe(""vk_subscribe"", {""mode"":2,""soft"":1}, ""account"""));
      });
    }
  }
}