using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookFollowButtonWidget"/>.</para>
/// </summary>
public sealed class FacebookFollowButtonWidgetTest : Test
{
  private IFacebookFollowButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookFollowButtonWidgetTest() => Widget = Fixture<IFacebookFollowButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookFollowButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookFollowButtonWidget();
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("FacesValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<bool?>("KidsModeValue").Should().BeNull();
      widget.GetPropertyValue<string>("LayoutValue").Should().BeNull();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string scheme, IFacebookFollowButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Faces(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookFollowButtonWidget widget) => widget.Faces(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("FacesValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IFacebookFollowButtonWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.KidsMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void KidsMode_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(bool enabled, IFacebookFollowButtonWidget widget) => widget.KidsMode(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool?>("KidsModeValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Layout(null)).ThrowExactly<ArgumentNullException>().WithParameterName("layout");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Layout(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("layout");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string layout, IFacebookFollowButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LayoutValue").Should().Be(layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string url, IFacebookFollowButtonWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookFollowButtonWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IFacebookFollowButtonWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookFollowButtonWidget());
      Test(Fixture<FacebookFollowButtonWidget>.Create());
    }

    return;

    static void Test(IFacebookFollowButtonWidget original)
    {
      var clone = original.Clone<IFacebookFollowButtonWidget>();

      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
      clone.GetPropertyValue<bool?>("FacesValue").Should().Be(original.GetPropertyValue<bool?>("FacesValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<bool?>("KidsModeValue").Should().Be(original.GetPropertyValue<bool?>("KidsModeValue"));
      clone.GetPropertyValue<string>("LayoutValue").Should().Be(original.GetPropertyValue<string>("LayoutValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookFollowButtonWidget());
      Test(new FacebookFollowButtonWidget().Url("url"), """<div class="fb-follow" data-href="url"></div>""");
      Test(new FacebookFollowButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).KidsMode(true).Layout(FacebookButtonLayout.BoxCount).Faces(true).Width("width").Height("height"), """<div class="fb-follow" data-colorscheme="dark" data-height="height" data-href="url" data-kid-directed-site="true" data-layout="box_count" data-show-faces="true" data-width="width"></div>""");
      Test(Fixture<FacebookFollowButtonWidget>.Create());
    }

    return;

    static void Test(IFacebookFollowButtonWidget widget, params string[] html)
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