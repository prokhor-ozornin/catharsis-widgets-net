using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexVideoWidget"/>.</para>
  /// </summary>
  public sealed class YandexVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YandexVideoWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexVideoWidget();
      Assert.Null(widget.Id());
      Assert.Null(widget.Width());
      Assert.Null(widget.Height());
      Assert.Null(widget.User());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoWidget.User(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void User_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoWidget().User(null));
      Assert.Throws<ArgumentException>(() => new YandexVideoWidget().User(string.Empty));

      var widget = new YandexVideoWidget();
      Assert.Null(widget.User());
      Assert.True(ReferenceEquals(widget.User("user"), widget));
      Assert.Equal("user", widget.User());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new YandexVideoWidget().Id(string.Empty));

      var widget = new YandexVideoWidget();
      Assert.Null(widget.Id());
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Id());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new YandexVideoWidget().Width(string.Empty));

      var widget = new YandexVideoWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new YandexVideoWidget().Height(string.Empty));

      var widget = new YandexVideoWidget();
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new YandexVideoWidget().ToString());
      Assert.Equal(string.Empty, new YandexVideoWidget().Id("id").User("user").Width("width").ToString());
      Assert.Equal(string.Empty, new YandexVideoWidget().Id("id").User("user").Height("height").ToString());
      Assert.Equal(string.Empty, new YandexVideoWidget().Id("id").Width("width").Height("height").ToString());
      Assert.Equal(string.Empty, new YandexVideoWidget().User("user").Width("width").Height("height").ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://video.yandex.ru/iframe/user/id"" webkitallowfullscreen=""true"" width=""width""></iframe>", new YandexVideoWidget().Id("id").Height("height").Width("width").User("user").ToString());
    }
  }
}