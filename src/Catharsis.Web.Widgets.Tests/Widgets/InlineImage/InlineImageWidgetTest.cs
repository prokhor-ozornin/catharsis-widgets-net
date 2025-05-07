using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="InlineImageWidget"/>.</para>
/// </summary>
public sealed class InlineImageWidgetTest : Test
{
  private IInlineImageWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public InlineImageWidgetTest() => Widget = Fixture.Create<IInlineImageWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="InlineImageWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(InlineImageWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IInlineImageWidget>();

    using (new AssertionScope())
    {
      var widget = new InlineImageWidget();
      widget.GetPropertyValue<byte[]>("ContentsValue").Should().BeNull();
      widget.GetPropertyValue<string>("FormatValue").Should().BeNull();
    }
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
      
      new[] { [], new Random().ByteSequence(16).ToArray() }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(byte[] contents, IInlineImageWidget widget) => widget.Contents(contents).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte[]>("ContentsValue").Should().Equal(contents);
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
      AssertionExtensions.Should(() => new InlineImageWidget().Format(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("format");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string format, IInlineImageWidget widget) => widget.Format(format).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatValue").Should().Be(format);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="InlineImageWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new InlineImageWidget());
      Validate(Fixture.Create<IInlineImageWidget>());
    }

    return;

    static void Validate(IInlineImageWidget original)
    {
      var clone = original.Clone<IInlineImageWidget>();

      clone.GetPropertyValue<byte[]>("ContentsValue").Should().Equal(original.GetPropertyValue<byte[]>("ContentsValue"));
      clone.GetPropertyValue<string>("FormatValue").Should().Be(original.GetPropertyValue<string>("FormatValue"));
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
      Validate(Fixture.Create<IInlineImageWidget>());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      if (html.IsUnset())
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