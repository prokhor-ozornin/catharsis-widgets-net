using System;
using System.Globalization;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IPinterestPinItButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IPinterestPinItButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IPinterestPinItButtonWidgetExtensions.Gray(IPinterestPinItButtonWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Gray_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IPinterestPinItButtonWidgetExtensions.Gray(null));

      new PinterestPinItButtonWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => IPinterestPinItButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture));
      Assert.Throws<ArgumentNullException>(() => new PinterestPinItButtonWidget().Language((CultureInfo) null));

      new PinterestPinItButtonWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => IPinterestPinItButtonWidgetExtensions.Red(null));

      new PinterestPinItButtonWidget().Do(widget =>
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
      Assert.Throws<ArgumentNullException>(() => IPinterestPinItButtonWidgetExtensions.White(null));

      new PinterestPinItButtonWidget().Do(widget =>
      {
        Assert.True(ReferenceEquals(widget.White(), widget));
        Assert.Equal("white", widget.Color());
      });
    }
  }
}