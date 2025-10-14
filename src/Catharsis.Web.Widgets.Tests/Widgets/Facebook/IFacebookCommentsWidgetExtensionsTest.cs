using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookCommentsWidgetExtensions"/>.</para>
/// </summary>
/// <seealso cref="IFacebookCommentsWidgetExtensions"/>
public sealed class IFacebookCommentsWidgetExtensionsTest : Test
{
  private IFacebookCommentsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IFacebookCommentsWidgetExtensionsTest() => Widget = Fixture<IFacebookCommentsWidget>.Create();

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

      new[] { Fixture<Uri>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(Uri url, IFacebookCommentsWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url.ToString());
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

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(short width, IFacebookCommentsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
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

      Enum.GetValues<FacebookColorScheme>().ForEach(scheme => Test(scheme, Widget));
    }

    return;

    static void Test(FacebookColorScheme scheme, IFacebookCommentsWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme.ToString().ToLowerInvariant());
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

      Test(FacebookCommentsOrder.ReverseTime, "reverse_time", Widget);
      Test(FacebookCommentsOrder.Time, "time", Widget);
      Test(FacebookCommentsOrder.Social, "social", Widget);
    }

    return;

    static void Test(FacebookCommentsOrder order, string value, IFacebookCommentsWidget widget) => widget.Order(order).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("OrderValue").Should().Be(value);
  }
}