using System;
using System.IO;
using Catharsis.Commons;
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
    ///   <seealso cref="YandexVideoWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new YandexVideoWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(widget.Field("width") == null);
      Assert.True(widget.Field("height") == null);
      Assert.True(widget.Field("user") == null);
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
      Assert.True(widget.Field("user").To<string>() == null);
      Assert.True(ReferenceEquals(widget.User("user"), widget));
      Assert.True(widget.Field("user").To<string>() == "user");
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
      Assert.True(widget.Field("id").To<string>() == null);
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
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
      Assert.True(widget.Field("width").To<string>() == null);
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
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
      Assert.True(widget.Field("height").To<string>() == null);
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="YandexVideoWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new YandexVideoWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new YandexVideoWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexVideoWidget().Id("id").User("user").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexVideoWidget().Id("id").User("user").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexVideoWidget().Id("id").Width("width").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexVideoWidget().User("user").Width("width").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new YandexVideoWidget().Id("id").Height("height").Width("width").User("user").Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://video.yandex.ru/iframe/user/id"" webkitallowfullscreen=""true"" width=""width""></iframe>");
    }
  }
}