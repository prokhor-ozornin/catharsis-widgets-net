using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Test set for class <see cref="IVkontakteLikeButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteLikeButtonWidgetExtensionsTest : Test
{
  private IVkontakteLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVkontakteLikeButtonWidgetExtensionsTest() => Widget = Fixture<IVkontakteLikeButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Verb(IVkontakteLikeButtonWidget, VkontakteLikeButtonVerb)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Verb(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<VkontakteLikeButtonVerb>().ForEach(verb => Test(verb, Widget));
    }

    return;

    static void Test(VkontakteLikeButtonVerb verb, IVkontakteLikeButtonWidget widget) => widget.Verb(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("VerbValue").Should().Be((byte) verb);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Layout(IVkontakteLikeButtonWidget, VkontakteLikeButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<VkontakteLikeButtonLayout>().ForEach(layout => Test(layout, Widget));
    }

    return;

    static void Test(VkontakteLikeButtonLayout layout, IVkontakteLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Width(IVkontakteLikeButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(short width, IVkontakteLikeButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Height(IVkontakteLikeButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(height => Test(height, Widget));
    }

    return;

    static void Test(short height, IVkontakteLikeButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
  }
}