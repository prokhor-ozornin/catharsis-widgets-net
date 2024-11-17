using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookFacePileWidgetExtensions"/>.</para>
/// </summary>
public sealed class FacebookFacePileWidgetExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Actions(IFacebookFacepileWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookFacePileWidgetExtensions.Actions(null));

    Assert.False(new FacebookFacepileWidget().Actions().Any());
    Assert.Equal("actions", new FacebookFacepileWidget().Actions("actions").Actions().Single());
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
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.PhotoSize(IFacebookFacepileWidget, FacebookFacePilePhotoSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void PhotoSize_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookFacePileWidgetExtensions.PhotoSize(null, FacebookFacePilePhotoSize.Large));

    Assert.Equal("large", new FacebookFacepileWidget().PhotoSize(FacebookFacePilePhotoSize.Large).PhotoSize());
    Assert.Equal("medium", new FacebookFacepileWidget().PhotoSize(FacebookFacePilePhotoSize.Medium).PhotoSize());
    Assert.Equal("small", new FacebookFacepileWidget().PhotoSize(FacebookFacePilePhotoSize.Small).PhotoSize());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Width(IFacebookFacepileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookFacePileWidgetExtensions.Width(null, 0));

    Assert.Equal("1", new FacebookFacepileWidget().Width(1).Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Height(IFacebookFacepileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookFacePileWidgetExtensions.Height(null, 0));

    Assert.Equal("1", new FacebookFacepileWidget().Height(1).Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.ColorScheme(IFacebookFacepileWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IFacebookFacePileWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

    Assert.Equal("dark", new FacebookFacepileWidget().ColorScheme(FacebookColorScheme.Dark).ColorScheme());
    Assert.Equal("light", new FacebookFacepileWidget().ColorScheme(FacebookColorScheme.Light).ColorScheme());
  }
}