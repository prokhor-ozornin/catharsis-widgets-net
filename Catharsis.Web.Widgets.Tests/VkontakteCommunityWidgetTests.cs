using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VkontakteCommunityWidget"/>.</para>
  /// </summary>
  public sealed class VkontakteCommunityWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="VkontakteCommunityWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.Field("account"));
      Assert.Equal((byte)VkontakteCommunityMode.Participants, widget.Field("mode").To<byte>());
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().Account(string.Empty));

      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Mode(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Mode_Method()
    {
      var widget = new VkontakteCommunityWidget();
      Assert.Equal((byte)VkontakteCommunityMode.Participants, widget.Field("mode").To<byte>());
      Assert.True(ReferenceEquals(widget.Mode(1), widget));
      Assert.Equal(1, widget.Field("mode").To<byte>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().Width(string.Empty));

      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().Height(string.Empty));

      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new VkontakteCommunityWidget().Write(writer)).ToString().IsEmpty());

      new StringWriter().With(writer =>
      {
        new VkontakteCommunityWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_groups""></div>"));
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"VK.Widgets.Group(""vk_groups"", {""mode"":0}, ""account"");"));
      });

      new StringWriter().With(writer =>
      {
        new VkontakteCommunityWidget().Account("account").Width("width").Height("height").Mode(VkontakteCommunityMode.News).Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<div id=""vk_groups""></div>"));
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"VK.Widgets.Group(""vk_groups"", {""mode"":2,""wide"":1,""width"":""width"",""height"":""height""}, ""account"");"));
      });
    }
  }
}