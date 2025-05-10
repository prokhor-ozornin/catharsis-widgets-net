using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteSubscriptionWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteSubscriptionWidgetExtensionsTest : Test
{
  private IVkontakteSubscriptionWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVkontakteSubscriptionWidgetExtensionsTest() => Widget = Fixture.Create<IVkontakteSubscriptionWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteSubscriptionWidgetExtensions.Layout(IVkontakteSubscriptionWidget, VkontakteSubscriptionButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteSubscriptionWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<VkontakteSubscriptionButtonLayout>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(VkontakteSubscriptionButtonLayout layout, IVkontakteSubscriptionWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LayoutValue").Should().Be((byte) layout);
  }
}