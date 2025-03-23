using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookLikeBoxWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookLikeBoxWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeBoxWidgetExtensions.Width(IFacebookLikeBoxWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeBoxWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookLikeBoxWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IFacebookLikeBoxWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeBoxWidgetExtensions.Height(IFacebookLikeBoxWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeBoxWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookLikeBoxWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short height, IFacebookLikeBoxWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("HeightProperty").Should().Be(height.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeBoxWidgetExtensions.ColorScheme(IFacebookLikeBoxWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeBoxWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookLikeBoxWidget();
      Enum.GetValues<FacebookColorScheme>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(FacebookColorScheme scheme, IFacebookLikeBoxWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme.ToString().ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeBoxWidgetExtensions.Url(IFacebookLikeBoxWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeBoxWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IFacebookLikeBoxWidgetExtensions.Url(new FacebookLikeBoxWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      var widget = new FacebookLikeBoxWidget();
      new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(Uri url, IFacebookLikeBoxWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("UrlProperty").Should().Be(url.ToString());
    }
  }
}