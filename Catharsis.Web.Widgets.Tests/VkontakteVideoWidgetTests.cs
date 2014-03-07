using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteVideoWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontakteVideoWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.False(widget.Field("hd").To<bool>());
      Assert.Null(widget.Field("user"));
      Assert.Null(widget.Field("hash"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Id(string.Empty));

      var widget = new VkontakteVideoWidget();
      Assert.Null(widget.Field("id"));
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Field("id").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Width(string.Empty));

      var widget = new VkontakteVideoWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Height(string.Empty));

      var widget = new VkontakteVideoWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoWidget.HdQuality(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void HdQuality_Method()
    {
      var widget = new VkontakteVideoWidget();
      Assert.False(widget.Field("hd").To<bool>());
      Assert.True(ReferenceEquals(widget.HdQuality(), widget));
      Assert.True(widget.Field("hd").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoWidget.User(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void User_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().User(null));
      Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().User(string.Empty));

      var widget = new VkontakteVideoWidget();
      Assert.Null(widget.Field("user"));
      Assert.True(ReferenceEquals(widget.User("user"), widget));
      Assert.Equal("user", widget.Field("user").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Hash(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Hash_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Hash(null));
      Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Hash(string.Empty));

      var widget = new VkontakteVideoWidget();
      Assert.Null(widget.Field("hash"));
      Assert.True(ReferenceEquals(widget.Hash("hash"), widget));
      Assert.Equal("hash", widget.Field("hash").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new VkontakteVideoWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoWidget().User("oid").Hash("hash").Width("width").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoWidget().Id("id").Hash("hash").Width("width").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoWidget().Id("id").User("user").Width("width").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Write(writer)).ToString().IsEmpty());

      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=0"" webkitallowfullscreen=""true"" width=""width""></iframe>", new StringWriter().With(writer => new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height").Write(writer)).ToString());
      Assert.Equal(@"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=1"" webkitallowfullscreen=""true"" width=""width""></iframe>", new StringWriter().With(writer => new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height").HdQuality().Write(writer)).ToString());
    }
  }
}