using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="FacebookActivityFeedWidget"/>.</para>
/// </summary>
public sealed class FacebookActivityFeedWidgetTests : ClassTest<FacebookActivityFeedWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookActivityFeedWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookActivityFeedWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookActivityFeedWidget>();

    var widget = new FacebookActivityFeedWidget();
    widget.Actions().Should().BeEmpty();
    widget.AppId().Should().BeNull();
    widget.ColorScheme().Should().BeNull();
    widget.Domain().Should().BeNull();
    widget.Header().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.LinkTarget().Should().BeNull();
    widget.MaxAge().Should().BeNull();
    widget.Recommendations().Should().BeNull();
    widget.TrackLabel().Should().BeNull();
    widget.Width().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Actions(IEnumerable{string})"/> method.</para>
  /// </summary>
  [Fact]
  public void Actions_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Actions(null));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { Enumerable.Empty<string>(), ["action"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(IEnumerable<string> actions, IFacebookActivityFeedWidget widget)
    {
      widget.Actions(actions).Should().BeSameAs(widget);
      widget.Actions().Should().Equal(actions);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.AppId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AppId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().AppId(null));
    Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().AppId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IFacebookActivityFeedWidget widget)
    {
      widget.AppId(id).Should().BeSameAs(widget);
      widget.AppId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().ColorScheme(null));
    Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().ColorScheme(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, IFacebookActivityFeedWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.ColorScheme().Should().Be(scheme);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Domain(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Domain_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Domain(null));
    Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().Domain(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IFacebookActivityFeedWidget widget)
    {
      widget.Domain(id).Should().BeSameAs(widget);
      widget.Domain().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Header(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Header_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookActivityFeedWidget widget)
    {
      widget.Header(enabled).Should().BeSameAs(widget);
      widget.Header().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IFacebookActivityFeedWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.LinkTarget(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkTarget_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().LinkTarget(null));
    Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().LinkTarget(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string target, IFacebookActivityFeedWidget widget)
    {
      widget.LinkTarget(target).Should().BeSameAs(widget);
      widget.LinkTarget().Should().Be(target);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.MaxAge(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void MaxAge_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte max, IFacebookActivityFeedWidget widget)
    {
      widget.MaxAge(max).Should().BeSameAs(widget);
      widget.MaxAge().Should().Be(max);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Recommendations(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Recommendations_Method()
  {
    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool enabled, IFacebookActivityFeedWidget widget)
    {
      widget.Recommendations(enabled).Should().BeSameAs(widget);
      widget.Recommendations().Should().Be(enabled);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.TrackLabel(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TrackLabel_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().TrackLabel(null));
    Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().TrackLabel(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string label, IFacebookActivityFeedWidget widget)
    {
      widget.TrackLabel(label).Should().BeSameAs(widget);
      widget.TrackLabel().Should().Be(label);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookActivityFeedWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookActivityFeedWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookActivityFeedWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookActivityFeedWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookActivityFeedWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal("""<div class="fb-activity"></div>""", new FacebookActivityFeedWidget().ToString());
    Assert.Equal("""<div class="fb-activity" data-action="actions" data-app-id="appId" data-colorscheme="dark" data-header="true" data-height="height" data-linktarget="linkTarget" data-max-age="1" data-recommendations="true" data-ref="trackLabel" data-site="domain" data-width="width"></div>""", new FacebookActivityFeedWidget().Domain("domain").AppId("appId").Actions("actions").Width("width").Height("height").ColorScheme(FacebookColorScheme.Dark).Header(true).LinkTarget("linkTarget").MaxAge(1).Recommendations(true).TrackLabel("trackLabel").ToString());
  }
}