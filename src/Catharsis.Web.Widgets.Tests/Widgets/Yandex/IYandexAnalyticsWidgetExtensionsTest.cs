using System.Globalization;
using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexAnalyticsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexAnalyticsWidgetExtensionsTest : Test
{
  private IYandexAnalyticsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IYandexAnalyticsWidgetExtensionsTest() => Widget = Fixture<IYandexAnalyticsWidget>.Create();

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

      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(culture => Test(culture, Widget));
    }

    return;

    static void Test(CultureInfo culture, IYandexAnalyticsWidget widget) => widget.Language(culture).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(culture.TwoLetterISOLanguageName);
  }
}