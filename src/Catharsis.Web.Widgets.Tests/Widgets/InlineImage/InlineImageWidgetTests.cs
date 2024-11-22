using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="InlineImageWidget"/>.</para>
/// </summary>
public sealed class InlineImageWidgetTests : ClassTest<InlineImageWidget>
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

    using (new AssertionScope())
    {
      var widget = new InlineImageWidget();
      new[] { Array.Empty<byte>(), new Random().ByteSequence(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte[] contents, IInlineImageWidget widget)
    {
      widget.Contents(contents).Should().BeSameAs(widget);
      widget.Contents().Should().Equal(contents);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="InlineImageWidget.Format(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Format_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new InlineImageWidget().Format(null));
    Assert.Throws<ArgumentException>(() => new InlineImageWidget().Format(string.Empty));

    using (new AssertionScope())
    {
      var widget = new InlineImageWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string format, IInlineImageWidget widget)
    {
      widget.Format(format).Should().BeSameAs(widget);
      widget.Format().Should().Be(format);
    }
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