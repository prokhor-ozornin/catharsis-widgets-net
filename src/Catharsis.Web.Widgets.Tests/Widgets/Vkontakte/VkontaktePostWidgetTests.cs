using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontaktePostWidget"/>.</para>
  /// </summary>
  public sealed class VkontaktePostWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="VkontaktePostWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontaktePostWidget();
      Assert.Null(widget.ElementId());
      Assert.Null(widget.Hash());
      Assert.Null(widget.Id());
      Assert.Null(widget.Owner());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePostWidget.ElementId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ElementId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePostWidget().ElementId(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePostWidget().ElementId(string.Empty));

      var widget = new VkontaktePostWidget();
      Assert.Null(widget.ElementId());
      Assert.True(ReferenceEquals(widget.ElementId("elementId"), widget));
      Assert.Equal("elementId", widget.ElementId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePostWidget.Hash(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Hash_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePostWidget().Hash(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePostWidget().Hash(string.Empty));

      var widget = new VkontaktePostWidget();
      Assert.Null(widget.Hash());
      Assert.True(ReferenceEquals(widget.Hash("hash"), widget));
      Assert.Equal("hash", widget.Hash());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePostWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePostWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePostWidget().Id(string.Empty));

      var widget = new VkontaktePostWidget();
      Assert.Null(widget.Id());
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.Equal("id", widget.Id());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePostWidget.Owner(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Owner_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePostWidget().Owner(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePostWidget().Owner(string.Empty));

      var widget = new VkontaktePostWidget();
      Assert.Null(widget.Owner());
      Assert.True(ReferenceEquals(widget.Owner("owner"), widget));
      Assert.Equal("owner", widget.Owner());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePostWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontaktePostWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VkontaktePostWidget().Width(string.Empty));

      var widget = new VkontaktePostWidget();
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontaktePostWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VkontaktePostWidget().ToString());
      Assert.Equal(string.Empty, new VkontaktePostWidget().Owner("owner").Hash("hash").ToString());
      Assert.Equal(string.Empty, new VkontaktePostWidget().Id("id").Owner("owner").ToString());
      Assert.Equal(string.Empty, new VkontaktePostWidget().Id("id").Hash("hash").ToString());
      Assert.Equal(@"<div id=""vk_post_owner_id""></div><script type=""text/javascript"">(function() { window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(""vk_post_owner_id"", owner, id, ""hash"", {}) || setTimeout(arguments.callee, 50); }());</script>", new VkontaktePostWidget().Id("id").Owner("owner").Hash("hash").ToString());
      Assert.Equal(@"<div id=""elementId""></div><script type=""text/javascript"">(function() { window.VK && VK.Widgets && VK.Widgets.Post && VK.Widgets.Post(""elementId"", owner, id, ""hash"", {""width"":""width""}) || setTimeout(arguments.callee, 50); }());</script>", new VkontaktePostWidget().Id("id").Owner("owner").Hash("hash").ElementId("elementId").Width("width").ToString());
    }
  }
}