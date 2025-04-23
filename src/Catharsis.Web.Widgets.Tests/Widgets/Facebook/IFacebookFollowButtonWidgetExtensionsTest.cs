using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookFollowButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookFollowButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Width(IFacebookFollowButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFollowButtonWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short width, IFacebookFollowButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Height(IFacebookFollowButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFollowButtonWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short height, IFacebookFollowButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.ColorScheme(IFacebookFollowButtonWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new FacebookFollowButtonWidget().With(widget => Enum.GetValues<FacebookColorScheme>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(FacebookColorScheme scheme, IFacebookFollowButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Layout(IFacebookFollowButtonWidget, FacebookButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new FacebookFollowButtonWidget();
      Validate(FacebookButtonLayout.BoxCount, "box_count", widget);
      Validate(FacebookButtonLayout.ButtonCount, "button_count", widget);
      Validate(FacebookButtonLayout.Standard, "standard", widget);
    }

    return;

    static void Validate(FacebookButtonLayout layout, string value, IFacebookFollowButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutProperty").Should().Be(value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookFollowButtonWidgetExtensions.Url(IFacebookFollowButtonWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IFacebookFollowButtonWidgetExtensions.Url(new FacebookFollowButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      new FacebookFollowButtonWidget().With(widget => new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(Uri url, IFacebookFollowButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlProperty").Should().Be(url.ToString());
  }
}