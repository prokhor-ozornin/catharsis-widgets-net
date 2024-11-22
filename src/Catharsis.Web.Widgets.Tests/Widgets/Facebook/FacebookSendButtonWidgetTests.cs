using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookSendButtonWidget"/>.</para>
/// </summary>
public sealed class FacebookSendButtonWidgetTests : ClassTest<FacebookSendButtonWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookSendButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookSendButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookSendButtonWidget>();

    var widget = new FacebookSendButtonWidget();
    widget.Url().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.ColorScheme().Should().BeNull();
    widget.KidsMode().Should().BeNull();
    widget.TrackLabel().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IFacebookSendButtonWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookSendButtonWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IFacebookSendButtonWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().ColorScheme(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, IFacebookSendButtonWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.KidsMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void KidsMode_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookSendButtonWidget widget)
    {
      widget.KidsMode(enabled).Should().BeSameAs(widget);
      widget.KidsMode().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().TrackLabel(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().TrackLabel(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookSendButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string label, IFacebookSendButtonWidget widget)
    {
      widget.TrackLabel(label).Should().BeSameAs(widget);
      widget.TrackLabel().Should().Be(label);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("""<div class="fb-send"></div>""", new FacebookSendButtonWidget().ToString());
    Assert.Equal("""<div class="fb-send" data-colorscheme="dark" data-height="height" data-href="url" data-kid-directed-site="true" data-ref="trackLabel" data-width="width"></div>""", new FacebookSendButtonWidget().Url("url").ColorScheme(FacebookColorScheme.Dark).KidsMode(true).Width("width").Height("height").TrackLabel("trackLabel").ToString());
  }
}