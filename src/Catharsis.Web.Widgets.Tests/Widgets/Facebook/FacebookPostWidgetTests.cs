using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="FacebookPostWidget"/>.</para>
/// </summary>
public sealed class FacebookPostWidgetTests : ClassTest<FacebookPostWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookPostWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookPostWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookPostWidget>();

    var widget = new FacebookPostWidget();
    widget.Url().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookPostWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookPostWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new FacebookPostWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookPostWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IFacebookPostWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookPostWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookPostWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookPostWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookPostWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookPostWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookPostWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new FacebookPostWidget().ToString());
    Assert.Equal("""<div class="fb-post" data-href="url" data-width="width"></div>""", new FacebookPostWidget().Url("url").Width("width").ToString());
  }
}