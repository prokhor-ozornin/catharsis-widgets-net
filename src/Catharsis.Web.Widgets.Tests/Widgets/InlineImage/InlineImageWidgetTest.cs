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
public sealed class InlineImageWidgetTest : UnitTest
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
    widget.GetPropertyValue<byte[]>("ContentsProperty").Should().BeNull();
    widget.GetPropertyValue<string>("FormatProperty").Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="InlineImageWidget.Contents(byte[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Contents_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new InlineImageWidget().Contents(null)).ThrowExactly<ArgumentNullException>().WithParameterName("contents");

      var widget = new InlineImageWidget();
      new[] { Array.Empty<byte>(), new Random().ByteSequence(16).ToArray() }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte[] contents, IInlineImageWidget widget)
    {
      widget.Contents(contents).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte[]>("ContentsProperty").Should().Equal(contents);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="InlineImageWidget.Format(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Format_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new InlineImageWidget().Format(null)).ThrowExactly<ArgumentNullException>().WithParameterName("format");
      AssertionExtensions.Should(() => new InlineImageWidget().Format(null)).ThrowExactly<ArgumentException>().WithMessage("format");

      var widget = new InlineImageWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string format, IInlineImageWidget widget)
    {
      widget.Format(format).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("FormatProperty").Should().Be(format);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="InlineImageWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new InlineImageWidget());
      Validate(new InlineImageWidget().Contents(Guid.Empty.ToByteArray()), $"<img src=\"data:image;base64,{Convert.ToBase64String(Guid.Empty.ToByteArray())}\"></img>");
      Validate(new InlineImageWidget().Contents(Guid.Empty.ToByteArray()).Format("jpg"), $"<img src=\"data:jpg;base64,{Convert.ToBase64String(Guid.Empty.ToByteArray())}\"></img>");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}