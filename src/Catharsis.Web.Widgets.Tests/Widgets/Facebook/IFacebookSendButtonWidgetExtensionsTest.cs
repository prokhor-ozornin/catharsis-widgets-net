using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookSendButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookSendButtonWidgetExtensionsTest : Test
{
  private IFacebookSendButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IFacebookSendButtonWidgetExtensionsTest() => Widget = Fixture<IFacebookSendButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.Url(IFacebookSendButtonWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.Url(new FacebookSendButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      new[] { Fixture<Uri>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(Uri url, IFacebookSendButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url.ToString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.Width(IFacebookSendButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, IFacebookSendButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.Height(IFacebookSendButtonWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short height, IFacebookSendButtonWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.ColorScheme(IFacebookSendButtonWidget, FacebookColorScheme)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookSendButtonWidgetExtensions.ColorScheme(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<FacebookColorScheme>().ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(FacebookColorScheme scheme, IFacebookSendButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme.ToString().ToLowerInvariant());
  }
}