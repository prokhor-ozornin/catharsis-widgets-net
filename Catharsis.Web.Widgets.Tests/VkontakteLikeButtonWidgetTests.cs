﻿using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteLikeButtonWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteLikeButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="VkontakteLikeButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("text") == null);
      Assert.True(widget.Field("verb") == null);
      Assert.True(widget.Field("layout") == null);
      Assert.True(widget.Field("width") == null);
      Assert.True(widget.Field("height") == null);
      Assert.True(widget.Field("pageTitle") == null);
      Assert.True(widget.Field("pageUrl") == null);
      Assert.True(widget.Field("pageDescription") == null);
      Assert.True(widget.Field("pageImageUrl") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Text(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Text(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Text(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("text") == null);
      Assert.True(ReferenceEquals(widget.Text("text"), widget));
      Assert.True(widget.Field("text").To<string>() == "text");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Verb(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Verb_Method()
    {
      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("verb") == null);
      Assert.True(ReferenceEquals(widget.Verb(1), widget));
      Assert.True(widget.Field("verb").To<byte>() == 1);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Layout(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("layout") == null);
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.True(widget.Field("layout").To<string>() == "layout");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Width(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("width") == null);
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Height(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("height") == null);
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.PageTitle(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PageTitle_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().PageTitle(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().PageTitle(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("pageTitle") == null);
      Assert.True(ReferenceEquals(widget.PageTitle("pageTitle"), widget));
      Assert.True(widget.Field("pageTitle").To<string>() == "pageTitle");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.PageUrl(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PageUrl_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().PageUrl(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().PageUrl(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("pageUrl") == null);
      Assert.True(ReferenceEquals(widget.PageUrl("pageUrl"), widget));
      Assert.True(widget.Field("pageUrl").To<string>() == "pageUrl");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.PageDescription(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PageDescription_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().PageDescription(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().PageDescription(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("pageDescription") == null);
      Assert.True(ReferenceEquals(widget.PageDescription("pageDescription"), widget));
      Assert.True(widget.Field("pageDescription").To<string>() == "pageDescription");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.PageImageUrl(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PageImageUrl_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().PageImageUrl(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().PageImageUrl(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.True(widget.Field("pageImageUrl") == null);
      Assert.True(ReferenceEquals(widget.PageImageUrl("pageImageUrl"), widget));
      Assert.True(widget.Field("pageImageUrl").To<string>() == "pageImageUrl");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Write(null));

      new StringWriter().With(writer =>
      {
        new VkontakteLikeButtonWidget().Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_like""></div>"));
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"VK.Widgets.Like(""vk_like"", {});"));
      });

      new StringWriter().With(writer =>
      {
        new VkontakteLikeButtonWidget()
          .Layout(VkontakteLikeButtonLayout.Button)
          .Width("width")
          .PageTitle("pageTitle")
          .PageDescription("pageDescription")
          .PageUrl("pageUrl")
          .PageImageUrl("pageImageUrl")
          .Text("text")
          .Height("height")
          .Verb(1)
          .Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_like""></div>"));
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"VK.Widgets.Like(""vk_like"", {""type"":""button"",""width"":""width"",""pageTitle"":""pageTitle"",""pageDescription"":""pageDescription"",""pageUrl"":""pageUrl"",""pageImage"":""pageImageUrl"",""text"":""text"",""height"":""height"",""verb"":1});"));
      });
    }
  }
}