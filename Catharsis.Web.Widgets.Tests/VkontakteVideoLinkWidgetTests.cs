using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteVideoLinkWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteVideoLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="VkontakteVideoLinkWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteVideoLinkWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(widget.Field("user") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoLinkWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoLinkWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new VkontakteVideoLinkWidget().Id(string.Empty));

      var widget = new VkontakteVideoLinkWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoLinkWidget.User(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void User_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoLinkWidget().User(null));
      Assert.Throws<ArgumentException>(() => new VkontakteVideoLinkWidget().User(string.Empty));

      var widget = new VkontakteVideoLinkWidget();
      Assert.True(widget.Field("user") == null);
      Assert.True(ReferenceEquals(widget.User("user"), widget));
      Assert.True(widget.Field("user").To<string>() == "user");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteVideoLinkWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteVideoLinkWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new VkontakteVideoLinkWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoLinkWidget().Id("id").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoLinkWidget().User("user").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VkontakteVideoLinkWidget().Id("id").User("user").Write(writer)).ToString() == @"<a href=""http://vk.com/videouser_id""></a>");
    }
  }
}