using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITumblrFollowButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ITumblrFollowButtonWidgetExtensionsTest : Test
{
  private ITumblrFollowButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public ITumblrFollowButtonWidgetExtensionsTest() => Widget = Fixture.Create<ITumblrFollowButtonWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrFollowButtonWidgetExtensions.Type(ITumblrFollowButtonWidget, TumblrFollowButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITumblrFollowButtonWidgetExtensions.Type(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<TumblrFollowButtonType>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(TumblrFollowButtonType type, ITumblrFollowButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TypeValue").Should().Be((byte) type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITumblrFollowButtonWidgetExtensions.ColorScheme(ITumblrFollowButtonWidget, TumblrFollowButtonColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITumblrFollowButtonWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<TumblrFollowButtonColorScheme>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(TumblrFollowButtonColorScheme scheme, ITumblrFollowButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}