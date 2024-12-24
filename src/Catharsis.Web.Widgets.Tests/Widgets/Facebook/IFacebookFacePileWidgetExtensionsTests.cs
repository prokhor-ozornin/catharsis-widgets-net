using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookFacePileWidgetExtensions"/>.</para>
/// </summary>
public sealed class FacebookFacePileWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Actions(IFacebookFacePileWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.False(new FacebookFacePileWidget().Actions().Any());
    Assert.Equal("actions", new FacebookFacePileWidget().Actions("actions").Actions().Single());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Url(IFacebookFacePileWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.PhotoSize(IFacebookFacePileWidget, FacebookFacePilePhotoSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void PhotoSize_Method()
  {
    AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.PhotoSize(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("large", new FacebookFacePileWidget().PhotoSize(FacebookFacePilePhotoSize.Large).PhotoSize());
    Assert.Equal("medium", new FacebookFacePileWidget().PhotoSize(FacebookFacePilePhotoSize.Medium).PhotoSize());
    Assert.Equal("small", new FacebookFacePileWidget().PhotoSize(FacebookFacePilePhotoSize.Small).PhotoSize());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Width(IFacebookFacePileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookFacePileWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Height(IFacebookFacePileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("1", new FacebookFacePileWidget().Height(1).Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.ColorScheme(IFacebookFacePileWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    Assert.Equal("dark", new FacebookFacePileWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
    Assert.Equal("light", new FacebookFacePileWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
  }
}