using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookLikeButtonWidgetExtensions"/></para>
/// </summary>
/// <seealso cref="IFacebookLikeButtonWidgetExtensions"/>
public sealed class IFacebookLikeButtonWidgetExtensionsTest : Test
{
  private IFacebookLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IFacebookLikeButtonWidgetExtensionsTest() => Widget = Fixture<IFacebookLikeButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Layout(IFacebookLikeButtonWidget, FacebookButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(FacebookButtonLayout.BoxCount, "box_count", Widget);
      Test(FacebookButtonLayout.ButtonCount, "button_count", Widget);
      Test(FacebookButtonLayout.Standard, "standard", Widget);
    }

    return;

    static void Test(FacebookButtonLayout layout, string value, IFacebookLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Url(IFacebookLikeButtonWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeButtonWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IFacebookLikeButtonWidgetExtensions.Url(new FacebookLikeButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      new[] { Fixture<Uri>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(Uri url, IFacebookLikeButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url.ToString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Width(IFacebookLikeButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(short width, IFacebookLikeButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.Verb(IFacebookLikeButtonWidget, FacebookLikeButtonVerb)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeButtonWidgetExtensions.Verb(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<FacebookLikeButtonVerb>().ForEach(verb => Test(verb, Widget));
    }

    return;

    static void Test(FacebookLikeButtonVerb verb, IFacebookLikeButtonWidget widget) => widget.Verb(verb).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("VerbValue").Should().Be(verb.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookLikeButtonWidgetExtensions.ColorScheme(IFacebookLikeButtonWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookLikeButtonWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<FacebookColorScheme>().ForEach(scheme => Test(scheme, Widget));
    }

    return;

    static void Test(FacebookColorScheme scheme, IFacebookLikeButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}