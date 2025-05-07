using System.Globalization;
using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPinterestPinItButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IPinterestPinItButtonWidgetExtensionsTest : Test
{
  private IPinterestPinItButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IPinterestPinItButtonWidgetExtensionsTest() => Widget = Fixture.Create<IPinterestPinItButtonWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.Gray(IPinterestPinItButtonWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Gray_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.Gray(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestPinItButtonWidget widget) => widget.Gray().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("gray");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.Language(IPinterestPinItButtonWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Language((CultureInfo) null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(CultureInfo culture, IPinterestPinItButtonWidget widget) => widget.Language(culture).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(culture.TwoLetterISOLanguageName);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.Red(IPinterestPinItButtonWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Red_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.Red(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;

    static void Validate(IPinterestPinItButtonWidget widget) => widget.Red().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("red");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.White(IPinterestPinItButtonWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void White_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.White(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Validate(Widget);
    }

    return;
 
    static void Validate(IPinterestPinItButtonWidget widget) => widget.White().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be("white");
  }
}