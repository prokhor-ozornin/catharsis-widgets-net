using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Test set for class <see cref="IVkontakteLikeButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteLikeButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteLikeButtonWidgetExtensions.Verb(IVkontakteLikeButtonWidget, VkontakteLikeButtonVerb)"/> method.</para>
    /// </summary>
    [Fact]
    public void Verb_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteLikeButtonWidgetExtensions.Verb(null, VkontakteLikeButtonVerb.Interest));

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
      Assert.Throws<ArgumentNullException>(() => IVkontakteLikeButtonWidgetExtensions.Width(null, 0));

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
      Assert.Throws<ArgumentNullException>(() => IVkontakteLikeButtonWidgetExtensions.Width(null, 0));

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
      Assert.Throws<ArgumentNullException>(() => IVkontakteLikeButtonWidgetExtensions.Height(null, 0));

      new VkontakteLikeButtonWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Height(1), widget));
        Assert.Equal("1", widget.Height());
      });
    }
  }
}