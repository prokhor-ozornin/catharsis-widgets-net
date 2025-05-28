using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookFacePileWidget"/>.</para>
/// </summary>
public sealed class FacebookFacePileWidgetTest : Test
{
  private IFacebookFacePileWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookFacePileWidgetTest() => Widget = Fixture<IFacebookFacePileWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookFacePileWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookFacePileWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookFacePileWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      widget.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().BeEmpty();
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<byte?>("MaxRowsValue").Should().BeNull();
      widget.GetPropertyValue<string>("PhotoSizeValue").Should().BeNull();
      widget.GetPropertyValue<string>("UrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Actions(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Actions(null)).ThrowExactly<ArgumentNullException>().WithParameterName("actions");

      new[] { Enumerable.Empty<string>(), [Fixture<string>.Create()] }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(IEnumerable<string> actions, IFacebookFacePileWidget widget) => widget.Actions(actions).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(actions);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string scheme, IFacebookFacePileWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IFacebookFacePileWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.MaxRows(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxRows_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte count, IFacebookFacePileWidget widget) => widget.MaxRows(count).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte?>("MaxRowsValue").Should().Be(count);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.PhotoSize(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PhotoSize_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().PhotoSize(null)).ThrowExactly<ArgumentNullException>().WithParameterName("size");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().PhotoSize(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("size");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string size, IFacebookFacePileWidget widget) => widget.PhotoSize(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PhotoSizeValue").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Url(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Url(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string url, IFacebookFacePileWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookFacePileWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IFacebookFacePileWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookFacePileWidget());
      Test(Fixture<FacebookFacePileWidget>.Create());
    }

    return;

    static void Test(IFacebookFacePileWidget original)
    {
      var clone = original.Clone<IFacebookFacePileWidget>();

      clone.GetPropertyValue<IEnumerable<string>>("ActionsValue").Should().Equal(original.GetPropertyValue<IEnumerable<string>>("ActionsValue"));
      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<byte?>("MaxRowsValue").Should().Be(original.GetPropertyValue<byte?>("MaxRowsValue"));
      clone.GetPropertyValue<string>("PhotoSizeValue").Should().Be(original.GetPropertyValue<string>("PhotoSizeValue"));
      clone.GetPropertyValue<string>("UrlValue").Should().Be(original.GetPropertyValue<string>("UrlValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookFacePileWidget(), """<div class="fb-facepile"></div>""");
      Test(new FacebookFacePileWidget().Url("url").Actions("actions").PhotoSize(FacebookFacePilePhotoSize.Large).Width("width").Height("height").MaxRows(10).ColorScheme(FacebookColorScheme.Dark), """<div class="fb-facepile" data-action="actions" data-colorscheme="dark" data-height="height" data-href="url" data-max-rows="10" data-size="large" data-width="width"></div>""");
      Test(Fixture<FacebookFacePileWidget>.Create());
    }

    return;

    static void Test(IFacebookFacePileWidget widget, params string[] html)
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