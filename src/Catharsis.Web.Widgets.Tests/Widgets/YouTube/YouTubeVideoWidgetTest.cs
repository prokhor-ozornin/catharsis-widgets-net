using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="YouTubeVideoWidget"/>.</para>
/// </summary>
/// <seealso cref="YouTubeVideoWidget"/>
public sealed class YouTubeVideoWidgetTest : Test
{
  private IYouTubeVideoWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public YouTubeVideoWidgetTest() => Widget = Fixture<IYouTubeVideoWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="YouTubeVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(YouTubeVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IYouTubeVideoWidget>();

    using (new AssertionScope())
    {
      var widget = new YouTubeVideoWidget();
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<bool>("PrivateModeValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("SecureModeValue").Should().BeFalse();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YouTubeVideoWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new YouTubeVideoWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IYouTubeVideoWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YouTubeVideoWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new YouTubeVideoWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { Fixture<string>.Create() }.ForEach(width => Test(width, Widget));
    }

    return;

    static void Test(string width, IYouTubeVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new YouTubeVideoWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new YouTubeVideoWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { Fixture<string>.Create() }.ForEach(height => Test(height, Widget));
    }

    return;

    static void Test(string height, IYouTubeVideoWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.PrivateMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void PrivateMode_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYouTubeVideoWidget widget) => widget.PrivateMode(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("PrivateModeValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.SecureMode(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void SecureMode_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(enabled => Test(enabled, Widget));
    }

    return;

    static void Test(bool enabled, IYouTubeVideoWidget widget) => widget.SecureMode(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("SecureModeValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new YouTubeVideoWidget());
      Test(Fixture<YouTubeVideoWidget>.Create());
    }

    return;

    static void Test(IYouTubeVideoWidget original)
    {
      var clone = original.Clone<IYouTubeVideoWidget>();

      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<bool>("PrivateModeValue").Should().Be(original.GetPropertyValue<bool>("PrivateModeValue"));
      clone.GetPropertyValue<bool>("SecureModeValue").Should().Be(original.GetPropertyValue<bool>("SecureModeValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="YouTubeVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new YouTubeVideoWidget());
      Test(new YouTubeVideoWidget().Id("id").Height("height"));
      Test(new YouTubeVideoWidget().Id("id").Width("width"));
      Test(new YouTubeVideoWidget().Height("height").Width("width"));
      Test(new YouTubeVideoWidget().Id("id").Height("height").Width("width"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://www.youtube.com/embed/id" webkitallowfullscreen="true" width="width"></iframe>""");
      Test(new YouTubeVideoWidget().Id("id").Height("height").Width("width").PrivateMode(true).SecureMode(true), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="https://www.youtube-nocookie.com/embed/id" webkitallowfullscreen="true" width="width"></iframe>""");
      Test(Fixture<YouTubeVideoWidget>.Create());
    }

    return;

    static void Test(IYouTubeVideoWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

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