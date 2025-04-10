using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITumblrShareButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ITumblrShareButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrShareButtonWidgetExtensions.Type(ITumblrShareButtonWidget, TumblrShareButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITumblrShareButtonWidgetExtensions.Type(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new TumblrShareButtonWidget();
      Enum.GetValues<TumblrShareButtonType>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(TumblrShareButtonType type, ITumblrShareButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TypeProperty").Should().Be((byte) type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrShareButtonWidgetExtensions.ColorScheme(ITumblrShareButtonWidget, TumblrShareButtonColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITumblrShareButtonWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new TumblrShareButtonWidget();
      Enum.GetValues<TumblrShareButtonColorScheme>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(TumblrShareButtonColorScheme scheme, ITumblrShareButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}