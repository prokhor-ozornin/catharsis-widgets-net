using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

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

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      new[] { Enumerable.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(IEnumerable<string> actions, IFacebookFacePileWidget widget)
    {
      widget.Actions(actions).Should().BeSameAs(widget);
      widget.Actions().Should().Equal(actions);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().ColorScheme(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, IFacebookFacePileWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IFacebookFacePileWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.MaxRows(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxRows_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte count, IFacebookFacePileWidget widget)
    {
      widget.MaxRows(count).Should().BeSameAs(widget);
      widget.MaxRows().Should().Be(count);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.PhotoSize(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PhotoSize_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().PhotoSize(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().PhotoSize(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string size, IFacebookFacePileWidget widget)
    {
      widget.PhotoSize(size).Should().BeSameAs(widget);
      widget.PhotoSize().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Url(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().Url(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().Url(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IFacebookFacePileWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookFacePileWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookFacePileWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookFacePileWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookFacePileWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookFacePileWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
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