using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IMailRuFacesWidgetExtensions"/>.</para>
/// </summary>
public sealed class IMailRuFacesWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Font(IMailRuFacesWidget, MailRuFacesFont)"/> method.</para>
  /// </summary>
  [Fact]
  public void Font_Method()
  {
    AssertionExtensions.Should(() => IMailRuFacesWidgetExtensions.Font(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new MailRuFacesWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Font(MailRuFacesFont.Tahoma), widget));
      Assert.Equal("Tahoma", widget.Font());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Height(IMailRuFacesWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IMailRuFacesWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new MailRuFacesWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Height(1), widget));
      Assert.Equal("1", widget.Height());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Width(IMailRuFacesWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IMailRuFacesWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new MailRuFacesWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Width(1), widget));
      Assert.Equal("1", widget.Width());
    });
  }
}