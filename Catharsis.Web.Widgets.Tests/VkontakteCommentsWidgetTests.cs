using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;
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
    ///   <seealso cref="VkontakteCommentsWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.True(widget.Field("limit").To<byte>() == (byte) VkontakteCommentsLimit.Limit5);
      Assert.False(widget.Field("attach").To<IEnumerable<string>>().Any());
      Assert.Null(widget.Field("width"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Limit(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Limit_Method()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.True(widget.Field("limit").To<byte>() == (byte) VkontakteCommentsLimit.Limit5);
      Assert.True(ReferenceEquals(widget.Limit(1), widget));
      Assert.True(widget.Field("limit").To<byte>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Attach(string[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Attach_Method()
    {
      var widget = new VkontakteCommentsWidget();
      Assert.False(widget.Field("attach").To<IEnumerable<string>>().Any());
      Assert.True(ReferenceEquals(widget.Attach("first", "second"), widget));
      Assert.True(widget.Field("attach").To<IEnumerable<string>>().SequenceEqual(new [] { "first", "second" }));
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommentsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommentsWidget().Write(null));

      new StringWriter().With(writer =>
      {
        new VkontakteCommentsWidget().Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_comments""></div>"));
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"VK.Widgets.Comments(""vk_comments"", {""limit"":5,""attach"":false});"));
      });

      new StringWriter().With(writer =>
      {
        new VkontakteCommentsWidget().Limit(10).Attach(VkontakteCommentsAttach.All).Width("width").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_comments""></div>"));
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"VK.Widgets.Comments(""vk_comments"", {""limit"":10,""attach"":""*"",""width"":""width""});"));
      });
    }
  }
}