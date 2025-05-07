using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VimeoVideoWidget"/>.</para>
/// </summary>
public sealed class VimeoVideoWidgetTest : Test
{
  private IVimeoVideoWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VimeoVideoWidgetTest() => Widget = Fixture.Create<IVimeoVideoWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VimeoVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VimeoVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVimeoVideoWidget>();

    using (new AssertionScope())
    {
      var widget = new VimeoVideoWidget();
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
      widget.GetPropertyValue<bool>("AutoPlayValue").Should().BeFalse();
      widget.GetPropertyValue<bool>("LoopValue").Should().BeFalse();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VimeoVideoWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VimeoVideoWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string id, IVimeoVideoWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VimeoVideoWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VimeoVideoWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string width, IVimeoVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VimeoVideoWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new VimeoVideoWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string height, IVimeoVideoWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.AutoPlay(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void AutoPlay_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IVimeoVideoWidget widget) => widget.AutoPlay(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("AutoPlayValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Loop(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Loop_Method()
  {
    using (new AssertionScope())
    {
      new[] { false, true }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(bool enabled, IVimeoVideoWidget widget) => widget.Loop(enabled).Should().BeSameAs(widget).And.Subject.GetPropertyValue<bool>("LoopValue").Should().Be(enabled);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VimeoVideoWidget());
      Validate(Fixture.Create<IVimeoVideoWidget>());
    }

    return;

    static void Validate(IVimeoVideoWidget original)
    {
      var clone = original.Clone<IVimeoVideoWidget>();

      clone.GetPropertyValue<bool>("AutoPlayValue").Should().Be(original.GetPropertyValue<bool>("AutoPlayValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<bool>("LoopValue").Should().Be(original.GetPropertyValue<bool>("LoopValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VimeoVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VimeoVideoWidget());
      Validate(new VimeoVideoWidget().Id("id").Height("height"));
      Validate(new VimeoVideoWidget().Id("id").Width("width"));
      Validate(new VimeoVideoWidget().Height("height").Width("width"));
      Validate(new VimeoVideoWidget().Id("id").Height("height").Width("width"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="https://player.vimeo.com/video/id?badge=0" webkitallowfullscreen="true" width="width"></iframe>""");
      Validate(new VimeoVideoWidget().Id("id").Height("height").Width("width").AutoPlay(true).Loop(true), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="https://player.vimeo.com/video/id?badge=0&amp;autoplay=1&amp;loop=1" webkitallowfullscreen="true" width="width"></iframe>""");
      Validate(Fixture.Create<IVimeoVideoWidget>());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
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