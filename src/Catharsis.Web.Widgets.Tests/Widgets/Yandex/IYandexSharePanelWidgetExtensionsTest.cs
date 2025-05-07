using System.Globalization;
using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexSharePanelWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexSharePanelWidgetExtensionsTest : Test
{
  private IYandexSharePanelWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IYandexSharePanelWidgetExtensionsTest() => Widget = Fixture.Create<IYandexSharePanelWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Services(IYandexSharePanelWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Services_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Services(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Services(new YandexSharePanelWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("services");

      new[] { Array.Empty<string>(), ["service"] }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string[] services, IYandexSharePanelWidget widget) => IYandexSharePanelWidgetExtensions.Services(widget, services).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ServicesValue").Should().Equal(services);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Language(IYandexSharePanelWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Language(new YandexSharePanelWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("language");

      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(CultureInfo culture, IYandexSharePanelWidget widget) => widget.Language(culture).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(culture.TwoLetterISOLanguageName);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexSharePanelWidgetExtensions.Layout(IYandexSharePanelWidget, YandexSharePanelLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexSharePanelWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<YandexSharePanelLayout>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(YandexSharePanelLayout layout, IYandexSharePanelWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout.ToString().ToLowerInvariant());
  }
}