using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="FacebookFacePileWidget"/>.</para>
/// </summary>
public sealed class FacebookFacePileWidgetTests : ClassTest<FacebookFacePileWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookFacePileWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookFacePileWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookFacePileWidget>();

    var widget = new FacebookFacePileWidget();
    widget.Actions().Should().BeEmpty();
    widget.ColorScheme().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.MaxRows().Should().BeNull();
    widget.PhotoSize().Should().BeNull();
    widget.Url().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Actions(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().Actions(null));

    var widget = new FacebookFacePileWidget();
    Assert.False(widget.Actions().Any());
    Assert.True(ReferenceEquals(widget.Actions(new[] { "first", "second" }), widget));
    Assert.True(widget.Actions().SequenceEqual(new[] { "first", "second" }));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().ColorScheme(string.Empty));

    var widget = new FacebookFacePileWidget();
    Assert.Null(widget.ColorScheme());
    Assert.True(ReferenceEquals(widget.ColorScheme("colorScheme"), widget));
    Assert.Equal("colorScheme", widget.ColorScheme());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().Height(string.Empty));

    var widget = new FacebookFacePileWidget();
    Assert.Null(widget.Height());
    Assert.True(ReferenceEquals(widget.Height("height"), widget));
    Assert.Equal("height", widget.Height());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.MaxRows(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxRows_Method()
  {
    var widget = new FacebookFacePileWidget();
    Assert.Null(widget.MaxRows());
    Assert.True(ReferenceEquals(widget.MaxRows(1), widget));
    Assert.Equal(1, widget.MaxRows().Value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.PhotoSize(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PhotoSize_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().PhotoSize(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().PhotoSize(string.Empty));

    var widget = new FacebookFacePileWidget();
    Assert.Null(widget.PhotoSize());
    Assert.True(ReferenceEquals(widget.PhotoSize("photoSize"), widget));
    Assert.Equal("photoSize", widget.PhotoSize());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().Url(string.Empty));

    var widget = new FacebookFacePileWidget();
    Assert.Null(widget.Url());
    Assert.True(ReferenceEquals(widget.Url("url"), widget));
    Assert.Equal("url", widget.Url());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().Width(string.Empty));

    var widget = new FacebookFacePileWidget();
    Assert.Null(widget.Width());
    Assert.True(ReferenceEquals(widget.Width("width"), widget));
    Assert.Equal("width", widget.Width());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("""<div class="fb-facepile"></div>""", new FacebookFacePileWidget().ToString());
    Assert.Equal("""<div class="fb-facepile" data-action="actions" data-colorscheme="dark" data-height="height" data-href="url" data-max-rows="10" data-size="large" data-width="width"></div>""", new FacebookFacePileWidget().Url("url").Actions("actions").PhotoSize(FacebookFacePilePhotoSize.Large).Width("width").Height("height").MaxRows(10).ColorScheme(FacebookColorScheme.Dark).ToString());
  }
}