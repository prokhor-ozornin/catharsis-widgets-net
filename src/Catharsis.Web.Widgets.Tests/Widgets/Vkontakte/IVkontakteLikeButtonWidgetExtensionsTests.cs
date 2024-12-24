using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Test set for class <see cref="IVkontakteLikeButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteLikeButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Verb(IVkontakteLikeButtonWidget, VkontakteLikeButtonVerb)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Verb(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteLikeButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Verb(VkontakteLikeButtonVerb.Like), widget));
      Assert.Equal(0, widget.Verb().Value);
    });
    new VkontakteLikeButtonWidget().With(widget => Assert.Equal(1, widget.Verb(VkontakteLikeButtonVerb.Interest).Verb().Value));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Layout(IVkontakteLikeButtonWidget, VkontakteLikeButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteLikeButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Layout(VkontakteLikeButtonLayout.Button), widget));
      Assert.Equal("button", widget.Layout());
    });
    new VkontakteLikeButtonWidget().With(widget => Assert.Equal("full", widget.Layout(VkontakteLikeButtonLayout.Full).Layout()));
    new VkontakteLikeButtonWidget().With(widget => Assert.Equal("mini", widget.Layout(VkontakteLikeButtonLayout.Mini).Layout()));
    new VkontakteLikeButtonWidget().With(widget => Assert.Equal("vertical", widget.Layout(VkontakteLikeButtonLayout.Vertical).Layout()));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Width(IVkontakteLikeButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteLikeButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Width(1), widget));
      Assert.Equal("1", widget.Width());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Height(IVkontakteLikeButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IVkontakteLikeButtonWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteLikeButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Height(1), widget));
      Assert.Equal("1", widget.Height());
    });
  }
}