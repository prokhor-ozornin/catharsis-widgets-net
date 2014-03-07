using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="YandexVideoLinkWidget"/>.</para>
  /// </summary>
  public sealed class YandexVideoLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="YandexVideoLinkWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexVideoLinkWidget();
      Assert.Null(widget.Field("id"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoLinkWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoLinkWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new YandexVideoLinkWidget().Id(string.Empty));

      var widget = new YandexVideoLinkWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoLinkWidget.HighQuality(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void HighQuality_Method()
    {
      var widget = new YandexVideoLinkWidget();
      Assert.False(widget.Field("highQuality").To<bool>());
      Assert.True(ReferenceEquals(widget.HighQuality(), widget));
      Assert.True(widget.Field("highQuality").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoLinkWidget.User(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void User_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoLinkWidget().User(null));
      Assert.Throws<ArgumentException>(() => new YandexVideoLinkWidget().User(string.Empty));

      var widget = new YandexVideoLinkWidget();
      Assert.Null(widget.Field("user"));
      Assert.True(ReferenceEquals(widget.User("user"), widget));
      Assert.Equal("user", widget.Field("user").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoLinkWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoLinkWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YandexVideoLinkWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexVideoLinkWidget().Id("id").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexVideoLinkWidget().User("user").Write(writer)).ToString().IsEmpty());
      Assert.Equal(@"<a href=""http://video.yandex.ru/users/user/view/id/#""></a>", new StringWriter().With(writer => new YandexVideoLinkWidget().Id("id").User("user").Write(writer)).ToString());
      Assert.Equal(@"<a href=""http://video.yandex.ru/users/user/view/id/#hq""></a>", new StringWriter().With(writer => new YandexVideoLinkWidget().Id("id").User("user").HighQuality().Write(writer)).ToString());
    }
  }
}