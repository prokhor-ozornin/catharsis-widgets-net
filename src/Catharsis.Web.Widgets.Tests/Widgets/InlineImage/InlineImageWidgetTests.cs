using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="InlineImageWidget"/>.</para>
/// </summary>
public sealed class InlineImageWidgetTests
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="InlineImageWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(InlineImageWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IInlineImageWidget>();

    var widget = new InlineImageWidget();
    widget.Contents().Should().BeNull();
    widget.Format().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="InlineImageWidget.Contents(byte[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Contents_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new InlineImageWidget().Contents(null));

    var widget = new InlineImageWidget();
    Assert.Null(widget.Contents());
    Assert.True(ReferenceEquals(widget.Contents(Guid.Empty.ToByteArray()), widget));
    Assert.True(widget.Contents().SequenceEqual(Guid.Empty.ToByteArray()));
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
    Assert.Null(widget.Format());
    Assert.True(ReferenceEquals(widget.Format("format"), widget));
    Assert.Equal("format", widget.Format());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="InlineImageWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new InlineImageWidget().ToString());
    Assert.Equal($"<img src=\"data:image;base64,{Convert.ToBase64String(Guid.Empty.ToByteArray())}\"></img>", new InlineImageWidget().Contents(Guid.Empty.ToByteArray()).ToString());
    Assert.Equal($"<img src=\"data:jpg;base64,{Convert.ToBase64String(Guid.Empty.ToByteArray())}\"></img>", new InlineImageWidget().Contents(Guid.Empty.ToByteArray()).Format("jpg").ToString());
  }
}