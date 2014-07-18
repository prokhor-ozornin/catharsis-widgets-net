using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteAuthButtonWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteAuthButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontakteAuthButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteAuthButtonWidget();
      Assert.Null(widget.Callback());
      Assert.Null(widget.ElementId());
      Assert.Equal(VkontakteAuthButtonType.Standard, widget.Type());
      Assert.Null(widget.Url());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.ElementId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ElementId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().ElementId(null));
      Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().ElementId(string.Empty));

      var widget = new VkontakteAuthButtonWidget();
      Assert.Null(widget.ElementId());
      Assert.True(ReferenceEquals(widget.ElementId("elementId"), widget));
      Assert.Equal("elementId", widget.ElementId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Width(string.Empty));

      var widget = new VkontakteAuthButtonWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Url(string.Empty));

      var widget = new VkontakteAuthButtonWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Type(VkontakteAuthButtonType)"/> method.</para>
    /// </summary>
    [Fact]
    public void Type_Method()
    {
      var widget = new VkontakteAuthButtonWidget();
      Assert.Equal(VkontakteAuthButtonType.Standard, widget.Type());
      Assert.True(ReferenceEquals(widget.Type(VkontakteAuthButtonType.Dynamic), widget));
      Assert.Equal(VkontakteAuthButtonType.Dynamic, widget.Type());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.Callback(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Callback_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteAuthButtonWidget().Callback(null));
      Assert.Throws<ArgumentException>(() => new VkontakteAuthButtonWidget().Callback(string.Empty));

      var widget = new VkontakteAuthButtonWidget();
      Assert.Null(widget.Callback());
      Assert.True(ReferenceEquals(widget.Callback("callback"), widget));
      Assert.Equal("callback", widget.Callback());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteAuthButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VkontakteAuthButtonWidget().ToString());
      Assert.Equal(string.Empty, new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Standard).ToString());
      Assert.Equal(string.Empty, new VkontakteAuthButtonWidget().Type(VkontakteAuthButtonType.Dynamic).ToString());
      Assert.Equal(@"<div id=""vk_auth""></div><script type=""text/javascript"">VK.Widgets.Auth(""vk_auth"", {""authUrl"":""url""});</script>", new VkontakteAuthButtonWidget().Standard("url").ToString());
      Assert.Equal(@"<div id=""vk_auth""></div><script type=""text/javascript"">VK.Widgets.Auth(""vk_auth"", {""onAuth"":""callback""});</script>", new VkontakteAuthButtonWidget().Dynamic("callback").ToString());
      Assert.Equal(@"<div id=""elementId""></div><script type=""text/javascript"">VK.Widgets.Auth(""elementId"", {""authUrl"":""url"",""width"":""width""});</script>", new VkontakteAuthButtonWidget().Standard("url").ElementId("elementId").Width("width").ToString());
    }
  }
}