﻿using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VimeoVideoLinkWidget"/>.</para>
  /// </summary>
  public sealed class VimeoVideoLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="VimeoVideoLinkWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new VimeoVideoLinkWidget();
      Assert.True(widget.Field("id") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoLinkWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VimeoVideoWidget().Id(null));
      Assert.Throws<ArgumentException>(() => new VimeoVideoWidget().Id(string.Empty));

      var widget = new VimeoVideoWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="VimeoVideoLinkWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new VimeoVideoLinkWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new VimeoVideoLinkWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new VimeoVideoLinkWidget().Id("id").Write(writer)).ToString() == @"<a href=""https://vimeo.com/id""></a>");
    }
  }
}