using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookFacePileWidgetExtensions"/>.</para>
/// </summary>
public sealed class FacebookFacePileWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Actions(IFacebookFacePileWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFacePileWidget().With(widget => new[] { Array.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string[] actions, IFacebookFacePileWidget widget) => IFacebookFacePileWidgetExtensions.Actions(widget, actions).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ActionsProperty").Should().Equal(actions);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Url(IFacebookFacePileWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Url(new FacebookFacePileWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      new FacebookFacePileWidget().With(widget => new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(Uri url, IFacebookFacePileWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url.ToString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.PhotoSize(IFacebookFacePileWidget, FacebookFacePilePhotoSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void PhotoSize_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.PhotoSize(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFacePileWidget().With(widget => Enum.GetValues<FacebookFacePilePhotoSize>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(FacebookFacePilePhotoSize size, IFacebookFacePileWidget widget) => widget.PhotoSize(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PhotoSizeProperty").Should().Be(size.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Width(IFacebookFacePileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFacePileWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short width, IFacebookFacePileWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.Height(IFacebookFacePileWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFacePileWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short height, IFacebookFacePileWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFacePileWidgetExtensions.ColorScheme(IFacebookFacePileWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFacePileWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFacePileWidget().With(widget => Enum.GetValues<FacebookColorScheme>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(FacebookColorScheme scheme, IFacebookFacePileWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}