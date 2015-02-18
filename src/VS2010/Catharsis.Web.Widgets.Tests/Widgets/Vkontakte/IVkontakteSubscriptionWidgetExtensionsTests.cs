using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontakteSubscriptionWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteSubscriptionWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteSubscriptionWidgetExtensions.Layout(IVkontakteSubscriptionWidget, VkontakteSubscriptionButtonLayout)"/> method.</para>
    /// </summary>
    [Fact]
    public void Layout_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteSubscriptionWidgetExtensions.Layout(null, VkontakteSubscriptionButtonLayout.Button));

      new VkontakteSubscriptionWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Layout(VkontakteSubscriptionButtonLayout.Button), widget));
        Assert.Equal(0, widget.Layout());
      });
      new VkontakteSubscriptionWidget().Do(widget => Assert.Equal(1, widget.Layout(VkontakteSubscriptionButtonLayout.LightButton).Layout()));
      new VkontakteSubscriptionWidget().Do(widget => Assert.Equal(2, widget.Layout(VkontakteSubscriptionButtonLayout.Link).Layout()));
    }
  }
}