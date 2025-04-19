using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IInlineImageExtensions"/>.</para>
/// </summary>
public sealed class IInlineImageExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IInlineImageExtensions.Jpg(IInlineImageWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Jpg_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IInlineImageExtensions.Jpg(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new InlineImageWidget().With(Validate);
    }

    return;

    static void Validate(IInlineImageWidget widget) => widget.Jpg().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatProperty").Should().Be("jpg");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IInlineImageExtensions.Png(IInlineImageWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Png_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IInlineImageExtensions.Png(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new InlineImageWidget().With(Validate);
    }

    return;

    static void Validate(IInlineImageWidget widget) => widget.Png().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatProperty").Should().Be("png");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IInlineImageExtensions.Gif(IInlineImageWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Gif_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IInlineImageExtensions.Gif(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new InlineImageWidget().With(Validate);
    }

    return;

    static void Validate(IInlineImageWidget widget) => widget.Gif().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatProperty").Should().Be("gif");
  }
}