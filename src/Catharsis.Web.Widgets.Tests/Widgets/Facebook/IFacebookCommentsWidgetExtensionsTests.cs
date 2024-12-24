using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookCommentsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookCommentsWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Url(IFacebookCommentsWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Url(null, "localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Url(new FacebookCommentsWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Width(IFacebookCommentsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookCommentsWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.ColorScheme(IFacebookCommentsWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("dark", new FacebookCommentsWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
    Assert.Equal("light", new FacebookCommentsWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Order(IFacebookCommentsWidget, FacebookCommentsOrder)"/> method.</para>
  /// </summary>
  [Fact]
  public void Order_Method()
  {
    AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Order(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("reverse_time", new FacebookCommentsWidget().Order(FacebookCommentsOrder.ReverseTime).Order());
    Assert.Equal("social", new FacebookCommentsWidget().Order(FacebookCommentsOrder.Social).Order());
    Assert.Equal("time", new FacebookCommentsWidget().Order(FacebookCommentsOrder.Time).Order());
  }
}