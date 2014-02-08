﻿using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuIcqWidget"/>.</para>
  /// </summary>
  public sealed class MailRuIcqWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="MailRuIcqWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuIcqWidget();
      Assert.True(widget.Property("account") == null);
      Assert.True(widget.Property("language") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuIcqWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuIcqWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new MailRuIcqWidget().Account(string.Empty));

      var widget = new MailRuIcqWidget();
      Assert.True(widget.Field("account") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuIcqWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuIcqWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new MailRuIcqWidget().Language(string.Empty));

      var widget = new MailRuIcqWidget();
      Assert.True(widget.Field("language") == null);
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.True(widget.Field("language").To<string>() == "language");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuIcqWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuIcqWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new MailRuIcqWidget().Write(writer)).ToString() == @"<script src=""http://c.icq.com/siteim/icqbar/js/partners/initbar_ru.js"" type=""text/javascript""></script>");
      new StringWriter().With(writer =>
      {
        new MailRuIcqWidget().Account("account").Language("en").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains("window.ICQ = {siteOwner:'account'};"));
        Assert.True(html.Contains(@"<script src=""http://c.icq.com/siteim/icqbar/js/partners/initbar_en.js"" type=""text/javascript""></script>"));
      });
    }
  }
}