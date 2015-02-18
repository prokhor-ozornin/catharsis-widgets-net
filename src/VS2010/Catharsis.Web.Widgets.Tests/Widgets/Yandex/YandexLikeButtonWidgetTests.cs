using System;
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
    /// </summary>
    /// <seealso cref="YandexLikeButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexLikeButtonWidget();
      Assert.Null(widget.Url());
      Assert.Null(widget.Title());
      Assert.Equal(YandexLikeButtonSize.Large.ToString().ToLowerInvariant(), widget.Size());
      Assert.Equal(YandexLikeButtonLayout.Button.ToString().ToLowerInvariant(), widget.Layout());
      Assert.Null(widget.Text());
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
      Assert.Null(widget.Url());
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.Equal("url", widget.Url());
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
      Assert.Null(widget.Title());
      Assert.True(ReferenceEquals(widget.Title("title"), widget));
      Assert.Equal("title", widget.Title());
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
      Assert.Equal(YandexLikeButtonSize.Large.ToString().ToLowerInvariant(), widget.Size());
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Size());
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
      Assert.Equal("button", widget.Layout());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.Equal("layout", widget.Layout());
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
      Assert.Null(widget.Text());
      Assert.True(ReferenceEquals(widget.Text("text"), widget));
      Assert.Equal("text", widget.Text());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexLikeButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.True(new YandexLikeButtonWidget().ToString().Contains(@"<a name=""ya-share"" size=""large"" type=""button""></a>"));
      Assert.True(new YandexLikeButtonWidget().Layout("icon").Size("small").Text("text").Url("url").Title("title").ToString().Contains(@"<a name=""ya-share"" share_text=""text"" share_title=""title"" share_url=""url"" size=""small"" type=""icon""></a>"));
    }
  }
}