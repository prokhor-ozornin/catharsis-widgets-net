using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookSendButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookSendButtonWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.Width(IFacebookSendButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookSendButtonWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.Height(IFacebookSendButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookSendButtonWidget().Height(1).Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.ColorScheme(IFacebookSendButtonWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("dark", new FacebookSendButtonWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
    Assert.Equal("light", new FacebookSendButtonWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
  }
}