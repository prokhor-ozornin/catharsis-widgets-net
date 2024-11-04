using System;
using System.Linq;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteCommentsWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteCommentsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontakteCommentsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.False(widget.Attach().Any());
      Assert.Null(widget.AutoPublish());
      Assert.Null(widget.AutoUpdate());
      Assert.Null(widget.ElementId());
      Assert.Equal((byte)VkontakteCommentsLimit.Limit5, widget.Limit());
      Assert.Null(widget.Mini());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Limit(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Limit_Method()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.Equal((byte)VkontakteCommentsLimit.Limit5, widget.Limit());
      Assert.True(ReferenceEquals(widget.Limit(1), widget));
      Assert.Equal(1, widget.Limit());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.ElementId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ElementId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommentsWidget().ElementId(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommentsWidget().ElementId(string.Empty));

      var widget = new VkontakteCommentsWidget();
      Assert.Null(widget.ElementId());
      Assert.True(ReferenceEquals(widget.ElementId("elementId"), widget));
      Assert.Equal("elementId", widget.ElementId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Attach(string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Attach_Method()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.False(widget.Attach().Any());
      Assert.True(ReferenceEquals(widget.Attach("first", "second"), widget));
      Assert.True(widget.Attach().SequenceEqual(new [] { "first", "second" }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommentsWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommentsWidget().Width(string.Empty));

      var widget = new VkontakteCommentsWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.AutoPublish(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AutoPublish_Method()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.Null(widget.AutoPublish());
      Assert.True(ReferenceEquals(widget.AutoPublish(true), widget));
      Assert.True(widget.AutoPublish().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.AutoUpdate(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void AutoUpdate_Method()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.Null(widget.AutoUpdate());
      Assert.True(ReferenceEquals(widget.AutoUpdate(true), widget));
      Assert.True(widget.AutoUpdate().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Mini(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Mini_Method()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.Null(widget.Mini());
      Assert.True(ReferenceEquals(widget.Mini(true), widget));
      Assert.True(widget.Mini().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      var html = new VkontakteCommentsWidget().ToString();
      Assert.True(html.Contains(@"<div id=""vk_comments""></div>"));
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.Widgets.Comments(""vk_comments"", {""limit"":5,""attach"":false});"));

      html = new VkontakteCommentsWidget().Limit(10).Attach(VkontakteCommentsAttach.All).Width("width").AutoPublish(true).AutoUpdate(true).ElementId("elementId").Mini(true).ToString();
      Assert.True(html.Contains(@"<div id=""elementId""></div>"));
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.Widgets.Comments(""elementId"", {""limit"":10,""attach"":""*"",""width"":""width"",""autoPublish"":1,""norealtime"":0,""mini"":1});"));
    }
  }
}