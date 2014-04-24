using System;
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
      Assert.Null(widget.Field("title"));
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("description"));
      Assert.Null(widget.Field("image"));
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
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Title(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Title_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Title(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Title(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.Null(widget.Field("title"));
      Assert.True(ReferenceEquals(widget.Title("title"), widget));
      Assert.Equal("title", widget.Field("title").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Url(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Field("url").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Description(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Description_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Description(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Description(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.Null(widget.Field("description"));
      Assert.True(ReferenceEquals(widget.Description("description"), widget));
      Assert.Equal("description", widget.Field("description").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.Image(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Image_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteLikeButtonWidget().Image(null));
      Assert.Throws<ArgumentException>(() => new VkontakteLikeButtonWidget().Image(string.Empty));

      var widget = new VkontakteLikeButtonWidget();
      Assert.Null(widget.Field("image"));
      Assert.True(ReferenceEquals(widget.Image("image"), widget));
      Assert.Equal("image", widget.Field("image").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteLikeButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      var html = new VkontakteLikeButtonWidget().ToString();
      Assert.True(html.Contains(@"<div id=""vk_like""></div>"));
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.Widgets.Like(""vk_like"", {});"));

      html = new VkontakteLikeButtonWidget().Layout(VkontakteLikeButtonLayout.Button).Width("width").Title("title").Description("description").Url("url").Image("image").Text("text").Height("height").Verb(1).ToString();
      Assert.True(html.Contains(@"<div id=""vk_like""></div>"));
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.Widgets.Like(""vk_like"", {""type"":""button"",""width"":""width"",""pageTitle"":""title"",""pageDescription"":""description"",""pageUrl"":""url"",""pageImage"":""image"",""text"":""text"",""height"":""height"",""verb"":1});"));
    }
  }
}