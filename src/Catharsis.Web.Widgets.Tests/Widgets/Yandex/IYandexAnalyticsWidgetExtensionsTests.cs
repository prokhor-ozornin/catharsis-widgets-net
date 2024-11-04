using System;
using System.Globalization;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IYandexAnalyticsWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IYandexAnalyticsWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IYandexAnalyticsWidgetExtensions.Language(IYandexAnalyticsWidget, CultureInfo})"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IYandexAnalyticsWidgetExtensions.Language(null, CultureInfo.InvariantCulture));
      Assert.Throws<ArgumentNullException>(() => IYandexAnalyticsWidgetExtensions.Language(new YandexAnalyticsWidget(), null));

      new YandexAnalyticsWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.Language(CultureInfo.InvariantCulture), widget));
        Assert.Equal(CultureInfo.InvariantCulture.TwoLetterISOLanguageName, widget.Language());
      });
    }
  }
}