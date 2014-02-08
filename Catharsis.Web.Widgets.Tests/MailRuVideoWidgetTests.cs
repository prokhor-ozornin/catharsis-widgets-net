﻿using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="MailRuVideoWidget"/>.</para>
  /// </summary>
  public sealed class MailRuVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="MailRuVideoWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new MailRuVideoWidgetTests();
      Assert.True(widget.Field("id") == null);
      Assert.True(widget.Field("height") == null);
      Assert.True(widget.Field("width") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Id(string.Empty));

      var widget = new MailRuVideoWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Width(string.Empty));

      var widget = new MailRuVideoWidget();
      Assert.True(widget.Field("width") == null);
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new MailRuVideoWidget().Height(string.Empty));

      var widget = new MailRuVideoWidget();
      Assert.True(widget.Field("height") == null);
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="MailRuVideoWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new MailRuVideoWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new MailRuVideoWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new MailRuVideoWidget().Id("id").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new MailRuVideoWidget().Id("id").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new MailRuVideoWidget().Height("height").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new MailRuVideoWidget().Id("id").Height("height").Width("width").Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" src=""http://api.video.mail.ru/videos/embed/mail/id"" webkitallowfullscreen=""true"" width=""width""></iframe>");
    }
  }
}