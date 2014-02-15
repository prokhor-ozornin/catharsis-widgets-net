using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexLikeButtonWidget"/>.</para>
  /// </summary>
  public sealed class YandexLikeButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="YandexLikeButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexLikeButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("title"));
      Assert.True(widget.Field("size").To<string>() == YandexLikeButtonSize.Large.ToString().ToLowerInvariant());
      Assert.True(widget.Field("layout").To<string>() == YandexLikeButtonLayout.Button.ToString().ToLowerInvariant());
      Assert.Null(widget.Field("text"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Url(string.Empty));

      var widget = new YandexLikeButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.True(widget.Field("url").To<string>() == "url");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Title(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Title_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Title(null));
      Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Title(string.Empty));

      var widget = new YandexLikeButtonWidget();
      Assert.Null(widget.Field("title"));
      Assert.True(ReferenceEquals(widget.Title("title"), widget));
      Assert.True(widget.Field("title").To<string>() == "title");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Size(null));
      Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Size(string.Empty));

      var widget = new YandexLikeButtonWidget();
      Assert.True(widget.Field("size").To<string>() == YandexLikeButtonSize.Large.ToString().ToLowerInvariant());
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.True(widget.Field("size").To<string>() == "size");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Layout(string.Empty));

      var widget = new YandexLikeButtonWidget();
      Assert.True(widget.Field("layout").To<string>() == YandexLikeButtonLayout.Button.ToString().ToLowerInvariant());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.True(widget.Field("layout").To<string>() == "layout");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Text(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Text(null));
      Assert.Throws<ArgumentException>(() => new YandexLikeButtonWidget().Text(string.Empty));

      var widget = new YandexLikeButtonWidget();
      Assert.Null(widget.Field("text"));
      Assert.True(ReferenceEquals(widget.Text("text"), widget));
      Assert.True(widget.Field("text").To<string>() == "text");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexLikeButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YandexLikeButtonWidget().Write(writer)).ToString().Contains(@"<a name=""ya-share"" size=""large"" type=""button""></a>"));
      Assert.True(new StringWriter().With(writer => new YandexLikeButtonWidget().Layout("icon").Size("small").Text("text").Url("url").Title("title").Write(writer)).ToString().Contains(@"<a name=""ya-share"" share_text=""text"" share_title=""title"" share_url=""url"" size=""small"" type=""icon""></a>"));
    }
  }
}