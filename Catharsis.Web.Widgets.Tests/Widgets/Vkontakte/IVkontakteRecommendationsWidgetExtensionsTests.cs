using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IVkontakteRecommendationsWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IVkontakteRecommendationsWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IVkontakteRecommendationsWidgetExtensions.Limit(IVkontakteRecommendationsWidget, VkontakteRecommendationsLimit)"/> method.</para>
    /// </summary>
    [Fact]
    public void Limit_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IVkontakteRecommendationsWidgetExtensions.Limit(null, VkontakteRecommendationsLimit.Five));

      new VkontakteRecommendationsWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Limit(VkontakteRecommendationsLimit.Five), widget));
        Assert.Equal(5, widget.Limit().Value);
      });
      new VkontakteRecommendationsWidget().With(widget => Assert.Equal(10, widget.Limit(VkontakteRecommendationsLimit.Ten).Limit().Value));
      new VkontakteRecommendationsWidget().With(widget => Assert.Equal(3, widget.Limit(VkontakteRecommendationsLimit.Three).Limit().Value));
    }
  }
}