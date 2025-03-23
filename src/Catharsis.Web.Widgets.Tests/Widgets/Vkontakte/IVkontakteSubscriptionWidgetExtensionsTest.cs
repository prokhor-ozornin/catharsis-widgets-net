using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteSubscriptionWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteSubscriptionWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteSubscriptionWidgetExtensions.Layout(IVkontakteSubscriptionWidget, VkontakteSubscriptionButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteSubscriptionWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontakteSubscriptionWidget();
      Enum.GetValues<VkontakteSubscriptionButtonLayout>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteSubscriptionButtonLayout layout, IVkontakteSubscriptionWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("LayoutProperty").Should().Be((byte) layout);
    }
  }
}