using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookCommentsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookCommentsWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Url(IFacebookCommentsWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Url(new FacebookCommentsWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      new FacebookCommentsWidget().With(widget => new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(Uri url, IFacebookCommentsWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url.ToString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Width(IFacebookCommentsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookCommentsWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short width, IFacebookCommentsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.ColorScheme(IFacebookCommentsWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookCommentsWidget().With(widget => Enum.GetValues<FacebookColorScheme>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(FacebookColorScheme scheme, IFacebookCommentsWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookCommentsWidgetExtensions.Order(IFacebookCommentsWidget, FacebookCommentsOrder)"/> method.</para>
  /// </summary>
  [Fact]
  public void Order_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookCommentsWidgetExtensions.Order(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookCommentsWidget();
      Validate(FacebookCommentsOrder.ReverseTime, "reverse_time", widget);
      Validate(FacebookCommentsOrder.Time, "time", widget);
      Validate(FacebookCommentsOrder.Social, "social", widget);
    }

    return;

    static void Validate(FacebookCommentsOrder order, string value, IFacebookCommentsWidget widget) => widget.Order(order).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("OrderProperty").Should().Be(value);
  }
}