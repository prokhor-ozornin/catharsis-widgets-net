﻿using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="RuTubeVideoWidget"/>.</para>
  /// 
  /// </summary>
  public sealed class RuTubeVideoWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="RuTubeVideoWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new RuTubeVideoLinkWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(widget.Field("width") == null);
      Assert.True(widget.Field("height") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Id(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Id_Method()
    {
      var widget = new RuTubeVideoWidget();
      Assert.True(widget.Field("id") == null);
      Assert.True(ReferenceEquals(widget.Id("id"), widget));
      Assert.True(widget.Field("id").To<string>() == "id");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new RuTubeVideoWidget().Width(string.Empty));

      var widget = new RuTubeVideoWidget();
      Assert.True(widget.Field("width") == null);
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new RuTubeVideoWidget().Height(string.Empty));

      var widget = new RuTubeVideoWidget();
      Assert.True(widget.Field("height") == null);
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="RuTubeVideoWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new RuTubeVideoWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new RuTubeVideoWidget().Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new RuTubeVideoWidget().Id("id").Height("height").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new RuTubeVideoWidget().Id("id").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new RuTubeVideoWidget().Height("height").Width("width").Write(writer)).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new RuTubeVideoWidget().Id("id").Height("height").Width("width").Write(writer)).ToString() == @"<iframe allowfullscreen=""true"" frameborder=""0"" height=""height"" mozallowfullscreen=""true"" scrolling=""no"" src=""http://rutube.ru/embed/id"" webkitallowfullscreen=""true"" width=""width""></iframe>");
    }
  }
}