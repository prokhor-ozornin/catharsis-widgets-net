using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
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
    AssertionExtensions.Should(() => IYandexAnalyticsWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => IYandexAnalyticsWidgetExtensions.Language(new YandexAnalyticsWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

    new YandexAnalyticsWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Language(CultureInfo.InvariantCulture), widget));
      Assert.Equal(CultureInfo.InvariantCulture.TwoLetterISOLanguageName, widget.Language());
    });
  }
}