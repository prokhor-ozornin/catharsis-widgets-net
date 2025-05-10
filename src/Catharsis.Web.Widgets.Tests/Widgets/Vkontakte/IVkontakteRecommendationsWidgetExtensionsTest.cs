using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteRecommendationsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteRecommendationsWidgetExtensionsTest : Test
{
  private IVkontakteRecommendationsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVkontakteRecommendationsWidgetExtensionsTest() => Widget = Fixture.Create<IVkontakteRecommendationsWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteRecommendationsWidgetExtensions.Limit(IVkontakteRecommendationsWidget, VkontakteRecommendationsLimit)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      Enum.GetValues<VkontakteRecommendationsLimit>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(VkontakteRecommendationsLimit limit, IVkontakteRecommendationsWidget widget) => widget.Limit(limit).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LimitValue").Should().Be((byte) limit);
  }
}