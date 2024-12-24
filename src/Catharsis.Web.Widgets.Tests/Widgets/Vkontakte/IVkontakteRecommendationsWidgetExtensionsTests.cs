using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteRecommendationsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteRecommendationsWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteRecommendationsWidgetExtensions.Limit(IVkontakteRecommendationsWidget, VkontakteRecommendationsLimit)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    AssertionExtensions.Should(() => IVkontakteRecommendationsWidgetExtensions.Limit(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteRecommendationsWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Limit(VkontakteRecommendationsLimit.Five), widget));
      Assert.Equal(5, widget.Limit().Value);
    });
    new VkontakteRecommendationsWidget().With(widget => Assert.Equal(10, widget.Limit(VkontakteRecommendationsLimit.Ten).Limit().Value));
    new VkontakteRecommendationsWidget().With(widget => Assert.Equal(3, widget.Limit(VkontakteRecommendationsLimit.Three).Limit().Value));
  }
}