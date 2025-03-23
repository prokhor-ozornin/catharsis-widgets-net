using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteRecommendationsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteRecommendationsWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteRecommendationsWidgetExtensions.Limit(IVkontakteRecommendationsWidget, VkontakteRecommendationsLimit)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteRecommendationsWidget();
      Enum.GetValues<VkontakteRecommendationsLimit>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteRecommendationsLimit limit, IVkontakteRecommendationsWidget widget)
    {
      widget.Limit(limit).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("LimitProperty").Should().Be((byte) limit);
    }
  }
}