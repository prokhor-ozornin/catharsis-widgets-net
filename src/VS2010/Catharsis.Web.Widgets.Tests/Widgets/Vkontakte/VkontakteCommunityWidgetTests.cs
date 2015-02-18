using System;
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
    /// </summary>
    /// <seealso cref="VkontakteCommunityWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.Account());
      Assert.Null(widget.BackgroundColor());
      Assert.Null(widget.ButtonColor());
      Assert.Null(widget.ElementId());
      Assert.Equal((byte)VkontakteCommunityMode.Participants, widget.Mode());
      Assert.Null(widget.TextColor());
      Assert.Null(widget.Width());
      Assert.Null(widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.BackgroundColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void BackgroundColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().BackgroundColor(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().BackgroundColor(string.Empty));

      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.BackgroundColor());
      Assert.True(ReferenceEquals(widget.BackgroundColor("backgroundColor"), widget));
      Assert.Equal("backgroundColor", widget.BackgroundColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.TextColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().TextColor(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().TextColor(string.Empty));

      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.TextColor());
      Assert.True(ReferenceEquals(widget.TextColor("textColor"), widget));
      Assert.Equal("textColor", widget.TextColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ButtonColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ButtonColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().ButtonColor(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().ButtonColor(string.Empty));

      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.ButtonColor());
      Assert.True(ReferenceEquals(widget.ButtonColor("buttonColor"), widget));
      Assert.Equal("buttonColor", widget.ButtonColor());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ElementId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ElementId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().ElementId(null));
      Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().ElementId(string.Empty));

      var widget = new VkontakteCommunityWidget();
      Assert.Null(widget.ElementId());
      Assert.True(ReferenceEquals(widget.ElementId("elementId"), widget));
      Assert.Equal("elementId", widget.ElementId());
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
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Mode(byte)"/> method.</para>
    /// </summary>
    [Fact]
    public void Mode_Method()
    {
      var widget = new VkontakteCommunityWidget();
      Assert.Equal((byte)VkontakteCommunityMode.Participants, widget.Mode());
      Assert.True(ReferenceEquals(widget.Mode(1), widget));
      Assert.Equal(1, widget.Mode());
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
      Assert.Null(widget.Width());
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Width());
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
      Assert.Null(widget.Height());
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Height());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new VkontakteCommunityWidget().ToString());

      var html = new VkontakteCommunityWidget().Account("account").ToString();
      Assert.True(html.Contains(@"<div id=""vk_groups_account""></div>"));
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.Widgets.Group(""vk_groups_account"", {""mode"":0}, ""account"");"));

      html = new VkontakteCommunityWidget().Account("account").Width("width").Height("height").Mode(VkontakteCommunityMode.News).ElementId("elementId").BackgroundColor("backgroundColor").TextColor("textColor").ButtonColor("buttonColor").ToString();
      Assert.True(html.Contains(@"<div id=""elementId""></div>"));
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"VK.Widgets.Group(""elementId"", {""mode"":2,""wide"":1,""width"":""width"",""height"":""height"",""color1"":""backgroundColor"",""color2"":""textColor"",""color3"":""buttonColor""}, ""account"");"));
    }
  }
}