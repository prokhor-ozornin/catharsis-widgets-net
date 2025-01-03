using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexAnalyticsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexAnalyticsWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexAnalyticsWidgetExtensions.Language(IYandexAnalyticsWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexAnalyticsWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IYandexAnalyticsWidgetExtensions.Language(new YandexAnalyticsWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

      var widget = new YandexAnalyticsWidget();
      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(CultureInfo culture, IYandexAnalyticsWidget widget)
    {
      widget.Language(culture).Should().BeSameAs(widget);
      widget.Language().Should().Be(culture.TwoLetterISOLanguageName);
    }
  }
}