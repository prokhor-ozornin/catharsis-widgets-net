using System;
using System.IO;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SurfingbirdSurfButtonWidget"/>.</para>
  /// </summary>
  public sealed class SurfingbirdSurfButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="SurfingbirdSurfButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(widget.Field("layout").To<string>() == SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant());
      Assert.Null(widget.Field("width"));
      Assert.Null(widget.Field("height"));
      Assert.False(widget.Field("counter").To<bool>());
      Assert.True(widget.Field("label").To<string>() == "Surf");
      Assert.Null(widget.Field("color"));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Url(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.True(ReferenceEquals(widget.Url("url"), widget));
      Assert.True(widget.Field("url").To<string>() == "url");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Layout(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Layout(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Layout(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.True(widget.Field("layout").To<string>() == SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant());
      Assert.True(ReferenceEquals(widget.Layout("layout"), widget));
      Assert.True(widget.Field("layout").To<string>() == "layout");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Width(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Width(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Width(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Field("width"));
      Assert.True(ReferenceEquals(widget.Width("width"), widget));
      Assert.True(widget.Field("width").To<string>() == "width");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Height(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Height(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Height(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Field("height"));
      Assert.True(ReferenceEquals(widget.Height("height"), widget));
      Assert.True(widget.Field("height").To<string>() == "height");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Counter(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Counter_Method()
    {
      var widget = new SurfingbirdSurfButtonWidget();
      Assert.False(widget.Field("counter").To<bool>());
      Assert.True(ReferenceEquals(widget.Counter(), widget));
      Assert.True(widget.Field("counter").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Label(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Label_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Label(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Label(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.True(widget.Field("label").To<string>() == "Surf");
      Assert.True(ReferenceEquals(widget.Label("label"), widget));
      Assert.True(widget.Field("label").To<string>() == "label");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Color(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Color_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Color(null));
      Assert.Throws<ArgumentException>(() => new SurfingbirdSurfButtonWidget().Color(string.Empty));

      var widget = new SurfingbirdSurfButtonWidget();
      Assert.Null(widget.Field("color"));
      Assert.True(ReferenceEquals(widget.Color("color"), widget));
      Assert.True(widget.Field("color").To<string>() == "color");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SurfingbirdSurfButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdSurfButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new SurfingbirdSurfButtonWidget().Write(writer)).ToString() == @"<a class=""surfinbird__like_button"" data-surf-config=""{&quot;layout&quot;:&quot;common-nocount&quot;}"" href=""http://surfingbird.ru/share"" target=""_blank"">Surf</a>");
      Assert.True(new StringWriter().With(writer => new SurfingbirdSurfButtonWidget().Color(SurfingbirdSurfButtonColor.Blue).Counter().Label("Share").Url("url").Layout(SurfingbirdSurfButtonLayout.Common).Width("width").Height("height").Write(writer)).ToString() == @"<a class=""surfinbird__like_button"" data-surf-config=""{&quot;layout&quot;:&quot;common-blue&quot;,&quot;url&quot;:&quot;url&quot;,&quot;width&quot;:&quot;width&quot;,&quot;height&quot;:&quot;height&quot;}"" href=""http://surfingbird.ru/share"" target=""_blank"">Share</a>");
    }
  }
}