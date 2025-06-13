using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITumblrShareButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ITumblrShareButtonWidgetExtensionsTest : Test
{
  private ITumblrShareButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public ITumblrShareButtonWidgetExtensionsTest() => Widget = Fixture<ITumblrShareButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrShareButtonWidgetExtensions.Type(ITumblrShareButtonWidget, TumblrShareButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITumblrShareButtonWidgetExtensions.Type(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<TumblrShareButtonType>().ForEach(type => Test(type, Widget));
    }

    return;

    static void Test(TumblrShareButtonType type, ITumblrShareButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TypeValue").Should().Be((byte) type);
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

      Enum.GetValues<TumblrShareButtonColorScheme>().ForEach(scheme => Test(scheme, Widget));
    }

    return;

    static void Test(TumblrShareButtonColorScheme scheme, ITumblrShareButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}