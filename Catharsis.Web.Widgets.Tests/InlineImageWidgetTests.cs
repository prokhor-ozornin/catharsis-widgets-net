using System;
using System.IO;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="InlineImageWidget"/>.</para>
  /// </summary>
  public sealed class InlineImageWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    ///   <seealso cref="InlineImageWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new InlineImageWidget();
      Assert.True(widget.Field("contents") == null);
      Assert.True(widget.Field("format") == null);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="InlineImageWidget.Contents(byte[])"/> method.</para>
    /// </summary>
    [Fact]
    public void Contents_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new InlineImageWidget().Contents(null));

      var widget = new InlineImageWidget();
      Assert.True(widget.Field("contents") == null);
      Assert.True(ReferenceEquals(widget.Contents(Guid.Empty.ToByteArray()), widget));
      Assert.True(widget.Field("contents").To<byte[]>().SequenceEqual(Guid.Empty.ToByteArray()));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="InlineImageWidget.Format(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Format_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new InlineImageWidget().Format(null));
      Assert.Throws<ArgumentException>(() => new InlineImageWidget().Format(string.Empty));

      var widget = new InlineImageWidget();
      Assert.True(widget.Field("format") == null);
      Assert.True(ReferenceEquals(widget.Format("format"), widget));
      Assert.True(widget.Field("format").To<string>() == "format");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="InlineImageWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new InlineImageWidget().Write(null));

      Assert.True(new StringWriter().With(new InlineImageWidget().Write).ToString().IsEmpty());
      Assert.True(new StringWriter().With(writer => new InlineImageWidget().Contents(Guid.Empty.ToByteArray()).Write(writer)).ToString() == @"<img src=""data:image;base64,{0}""></img>".FormatValue(System.Convert.ToBase64String(Guid.Empty.ToByteArray())));
      Assert.True(new StringWriter().With(writer => new InlineImageWidget().Contents(Guid.Empty.ToByteArray()).Format("jpg").Write(writer)).ToString() == @"<img src=""data:jpg;base64,{0}""></img>".FormatValue(System.Convert.ToBase64String(Guid.Empty.ToByteArray())));
    }
  }
}