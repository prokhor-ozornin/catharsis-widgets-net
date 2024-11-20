using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets;

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

    var widget = new FacebookSendButtonWidget();
    Assert.Null(widget.Url());
    Assert.True(ReferenceEquals(widget.Url("url"), widget));
    Assert.Equal("url", widget.Url());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Width(string.Empty));

    var widget = new FacebookSendButtonWidget();
    Assert.Null(widget.Width());
    Assert.True(ReferenceEquals(widget.Width("width"), widget));
    Assert.Equal("width", widget.Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().Height(string.Empty));

    var widget = new FacebookSendButtonWidget();
    Assert.Null(widget.Height());
    Assert.True(ReferenceEquals(widget.Height("height"), widget));
    Assert.Equal("height", widget.Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().ColorScheme(string.Empty));

    var widget = new FacebookSendButtonWidget();
    Assert.Null(widget.ColorScheme());
    Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
    Assert.Equal("colorScheme", widget.ColorScheme());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.KidsMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void KidsMode_Method()
  {
    var widget = new FacebookSendButtonWidget();
    Assert.Null(widget.KidsMode());
    Assert.True(ReferenceEquals(widget.KidsMode(true), widget));
    Assert.True(widget.KidsMode().Value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookSendButtonWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookSendButtonWidget().TrackLabel(null));
    Assert.Throws<ArgumentException>(() => new FacebookSendButtonWidget().TrackLabel(string.Empty));

    var widget = new FacebookSendButtonWidget();
    Assert.Null(widget.TrackLabel());
    Assert.True(ReferenceEquals(widget.TrackLabel("trackLabel"), widget));
    Assert.Equal("trackLabel", widget.TrackLabel());
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