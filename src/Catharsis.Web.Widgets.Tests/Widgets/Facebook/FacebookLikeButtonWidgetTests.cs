using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookLikeButtonWidget"/>.</para>
/// </summary>
public sealed class FacebookLikeButtonWidgetTests : ClassTest<FacebookLikeButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookLikeButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookLikeButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookLikeButtonWidget>();

    var widget = new FacebookLikeButtonWidget();
    widget.ColorScheme().Should().BeNull();
    widget.Faces().Should().BeNull();
    widget.KidsMode().Should().BeNull();
    widget.Layout().Should().BeNull();
    widget.TrackLabel().Should().BeNull();
    widget.Url().Should().BeNull();
    widget.Verb().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().ColorScheme(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, IFacebookLikeButtonWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Faces(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeButtonWidget widget)
    {
      widget.Faces(enabled).Should().BeSameAs(widget);
      widget.Faces().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.KidsMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void KidsMode_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookLikeButtonWidget widget)
    {
      widget.KidsMode(enabled).Should().BeSameAs(widget);
      widget.KidsMode().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Layout(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Layout(null));
    Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Layout(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string layout, IFacebookLikeButtonWidget widget)
    {
      widget.Layout(layout).Should().BeSameAs(widget);
      widget.Layout().Should().Be(layout);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().TrackLabel(null));
    Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().TrackLabel(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string label, IFacebookLikeButtonWidget widget)
    {
      widget.TrackLabel(label).Should().BeSameAs(widget);
      widget.TrackLabel().Should().Be(label);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IFacebookLikeButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }
    
  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Verb(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Verb_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Verb(null));
    Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Verb(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string verb, IFacebookLikeButtonWidget widget)
    {
      widget.Verb(verb).Should().BeSameAs(widget);
      widget.Verb().Should().Be(verb);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookLikeButtonWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookLikeButtonWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookLikeButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookLikeButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookLikeButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("""<div class="fb-like"></div>""", new FacebookLikeButtonWidget().ToString());
    Assert.Equal("""<div class="fb-like" data-href="url"></div>""", new FacebookLikeButtonWidget().Url("url").ToString());
    Assert.Equal("""<div class="fb-like" data-action="recommend" data-colorscheme="dark" data-href="url" data-kid-directed-site="true" data-layout="box_count" data-ref="trackLabel" data-show-faces="true" data-width="width"></div>""", new FacebookLikeButtonWidget().Verb(FacebookLikeButtonVerb.Recommend).ColorScheme(FacebookColorScheme.Dark).Url("url").KidsMode(true).Layout(FacebookButtonLayout.BoxCount).TrackLabel("trackLabel").Faces(true).Width("width").ToString());
  }
}