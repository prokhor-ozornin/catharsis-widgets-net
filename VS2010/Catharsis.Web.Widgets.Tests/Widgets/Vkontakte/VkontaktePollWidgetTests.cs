using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontaktePollWidget"/>.</para>
  /// </summary>
  public sealed class VkontaktePollWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontaktePollWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontaktePollWidget();
      Assert.Null(widget.ElementId());
      Assert.Null(widget.Id());
      Assert.Null(widget.Url());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePollWidget.ElementId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ElementId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().ElementId(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().ElementId(string.Empty));

      var widget = new VkontaktePollWidget();
      Assert.Null(widget.ElementId());
      Assert.True(ReferenceEquals(widget.ElementId("elementId"), widget));
      Assert.Equal("elementId", widget.ElementId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePollWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().Id(string.Empty));

      var widget = new VkontaktePollWidget();
      Assert.Null(widget.Id());
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Id());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePollWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().Url(string.Empty));

      var widget = new VkontaktePollWidget();
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePollWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePollWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePollWidget().Width(string.Empty));

      var widget = new VkontaktePollWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePollWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VkontaktePollWidget().ToString());
      Assert.Equal(@"<div id=""vk_poll_id""></div><script type=""text/javascript"">VK.Widgets.Poll(""vk_poll_id"", {}, ""id"");</script>", new VkontaktePollWidget().Id("id").ToString());
      Assert.Equal(@"<div id=""elementId""></div><script type=""text/javascript"">VK.Widgets.Poll(""elementId"", {""pageUrl"":""url"",""width"":""width""}, ""id"");</script>", new VkontaktePollWidget().Id("id").Url("url").Width("width").ElementId("elementId").ToString());
    }
  }
}