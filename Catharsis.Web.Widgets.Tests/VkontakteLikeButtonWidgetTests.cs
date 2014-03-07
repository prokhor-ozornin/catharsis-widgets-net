using System;
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
    /// </summary>
    /// <seealso cref="VkontakteLikeButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteLikeButtonWidget();
      Assert.Null(widget.Field("text"));
      Assert.Null(widget.Field("verb"));
      Assert.Null(widget.Field("layout"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.Null(widget.Field("pageTitle"));
      Assert.Null(widget.Field("pageUrl"));
      Assert.Null(widget.Field("pageDescription"));
      Assert.Null(widget.Field("pageImageUrl"));
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
      Assert.Null(widget.Field("text"));
      Assert.True(ReferenceEquals(widget.Text("text"), widget));
      Assert.Equal("text", widget.Field("text").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Verb(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Verb_Method()
    {
      var widget = new VkontakteLikeButtonWidget();
      Assert.Null(widget.Field("verb"));
      Assert.True(ReferenceEquals(widget.Verb(1), widget));
      Assert.Equal(1, widget.Field("verb").To<byte>());
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
      Assert.Null(widget.Field("layout"));
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.Equal("layout", widget.Field("layout").To<string>());
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
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
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
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
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
      Assert.Null(widget.Field("pageTitle"));
      Assert.True(ReferenceEquals(widget.PageTitle("pageTitle"), widget));
      Assert.Equal("pageTitle", widget.Field("pageTitle").To<string>());
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
      Assert.Null(widget.Field("pageUrl"));
      Assert.True(ReferenceEquals(widget.PageUrl("pageUrl"), widget));
      Assert.Equal("pageUrl", widget.Field("pageUrl").To<string>());
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
      Assert.Null(widget.Field("pageDescription"));
      Assert.True(ReferenceEquals(widget.PageDescription("pageDescription"), widget));
      Assert.Equal("pageDescription", widget.Field("pageDescription").To<string>());
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
      Assert.Null(widget.Field("pageImageUrl"));
      Assert.True(ReferenceEquals(widget.PageImageUrl("pageImageUrl"), widget));
      Assert.Equal("pageImageUrl", widget.Field("pageImageUrl").To<string>());
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