using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookLikeBoxWidget"/>.</para>
/// </summary>
public sealed class FacebookLikeBoxWidgetTest : Test
{
  private IFacebookLikeBoxWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookLikeBoxWidgetTest() => Widget = Fixture<IFacebookLikeBoxWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookLikeBoxWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookLikeBoxWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookLikeBoxWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookLikeBoxWidget();
      widget.GetPropertyValue<bool?>("BorderValue").Should().BeNull();
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("FacesValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("HeaderValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("StreamValue").Should().BeNull();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("WallValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Border(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Border_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookLikeBoxWidget widget) => widget.Border(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("BorderValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string scheme, IFacebookLikeBoxWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Faces(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookLikeBoxWidget widget) => widget.Faces(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("FacesValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Header(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookLikeBoxWidget widget) => widget.Header(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("HeaderValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IFacebookLikeBoxWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Stream(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Stream_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookLikeBoxWidget widget) => widget.Stream(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("StreamValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string url, IFacebookLikeBoxWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Wall(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Wall_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookLikeBoxWidget widget) => widget.Wall(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("WallValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookLikeBoxWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IFacebookLikeBoxWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookLikeBoxWidget());
      Test(Fixture<FacebookLikeBoxWidget>.Create());
    }

    return;

    static void Test(IFacebookLikeBoxWidget original)
    {
      var clone = original.Clone<IFacebookLikeBoxWidget>();

      clone.GetPropertyValue<bool?>("BorderValue").Should().Be(original.GetPropertyValue<bool?>("BorderValue"));
      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
      clone.GetPropertyValue<bool?>("FacesValue").Should().Be(original.GetPropertyValue<bool?>("FacesValue"));
      clone.GetPropertyValue<bool?>("HeaderValue").Should().Be(original.GetPropertyValue<bool?>("HeaderValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<bool?>("StreamValue").Should().Be(original.GetPropertyValue<bool?>("StreamValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<bool?>("WallValue").Should().Be(original.GetPropertyValue<bool?>("WallValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeBoxWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookLikeBoxWidget());
      Test(new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070"), """<div class="fb-like-box" data-href="https://www.facebook.com/pages/Clear-Words/515749945120070"></div>""");
      Test(new FacebookLikeBoxWidget().Url("https://www.facebook.com/pages/Clear-Words/515749945120070").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Wall(true).Header(true).Border(true).Faces(true).Stream(true), """<div class="fb-like-box" data-colorscheme="dark" data-force-wall="true" data-header="true" data-height="height" data-href="https://www.facebook.com/pages/Clear-Words/515749945120070" data-show-border="true" data-show-faces="true" data-stream="true" data-width="width"></div>""");
      Test(Fixture<FacebookLikeBoxWidget>.Create());
    }

    return;

    static void Test(IFacebookLikeBoxWidget widget, params string[] html)
    {
      if (html.IsUnset())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}