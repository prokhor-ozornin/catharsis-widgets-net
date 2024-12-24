using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPinterestPinItButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IPinterestPinItButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.Gray(IPinterestPinItButtonWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Gray_Method()
  {
    AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.Gray(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new PinterestPinItButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Gray(), widget));
      Assert.Equal("gray", widget.Color());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.Language(IPinterestPinItButtonWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => new PinterestPinItButtonWidget().Language((CultureInfo) null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

    new PinterestPinItButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Language(CultureInfo.CurrentCulture), widget));
      Assert.Equal(CultureInfo.CurrentCulture.TwoLetterISOLanguageName, widget.Language());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.Red(IPinterestPinItButtonWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Red_Method()
  {
    AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.Red(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new PinterestPinItButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Red(), widget));
      Assert.Equal("red", widget.Color());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.White(IPinterestPinItButtonWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void White_Method()
  {
    AssertionExtensions.Should(() => IPinterestPinItButtonWidgetExtensions.White(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new PinterestPinItButtonWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.White(), widget));
      Assert.Equal("white", widget.Color());
    });
  }
}