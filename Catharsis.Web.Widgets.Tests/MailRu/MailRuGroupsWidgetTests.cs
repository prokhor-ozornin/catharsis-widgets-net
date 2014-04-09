using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuGroupsWidget"/>.</para>
  /// </summary>
  public sealed class MailRuGroupsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="MailRuGroupsWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("backgroundColor"));
      Assert.Null(widget.Field("buttonColor"));
      Assert.Null(widget.Field("domain"));
      Assert.Null(widget.Field("height"));
      Assert.True(widget.Field("subscribers").To<bool>());
      Assert.Null(widget.Field("textColor"));
      Assert.Null(widget.Field("width"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Account(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.BackgroundColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void BackgroundColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().BackgroundColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().BackgroundColor(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("backgroundColor"));
      Assert.True(ReferenceEquals(widget.BackgroundColor("backgroundColor"), widget));
      Assert.Equal("backgroundColor", widget.Field("backgroundColor").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.ButtonColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void ButtonColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().ButtonColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().ButtonColor(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("buttonColor"));
      Assert.True(ReferenceEquals(widget.ButtonColor("buttonColor"), widget));
      Assert.Equal("buttonColor", widget.Field("buttonColor").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Domain(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Domain_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Domain(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Domain(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("domain"));
      Assert.True(ReferenceEquals(widget.Domain("domain"), widget));
      Assert.Equal("domain", widget.Field("domain").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Height(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.Equal("height", widget.Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Subscribers(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Subscribers_Method()
    {
      var widget = new MailRuGroupsWidget();
      Assert.True(widget.Field("subscribers").To<bool>());
      Assert.True(ReferenceEquals(widget.Subscribers(false), widget));
      Assert.False(widget.Field("subscribers").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.TextColor(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void TextColor_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().TextColor(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().TextColor(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("textColor"));
      Assert.True(ReferenceEquals(widget.TextColor("textColor"), widget));
      Assert.Equal("textColor", widget.Field("textColor").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new MailRuGroupsWidget().Width(string.Empty));

      var widget = new MailRuGroupsWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.Equal("width", widget.Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuGroupsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuGroupsWidget().Write(null));

      throw new NotImplementedException();
    }
  }
}