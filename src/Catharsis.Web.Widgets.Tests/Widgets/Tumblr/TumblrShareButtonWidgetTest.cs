using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TumblrShareButtonWidget"/>.</para>
/// </summary>
public sealed class TumblrShareButtonWidgetTest : Test
{
  private ITumblrShareButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public TumblrShareButtonWidgetTest() => Widget = Fixture<ITumblrShareButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TumblrShareButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TumblrShareButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITumblrShareButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new TumblrShareButtonWidget();
      widget.GetPropertyValue<byte>("TypeValue").Should().Be((byte) TumblrShareButtonType.First);
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.Type(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte type, ITumblrShareButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TypeValue").Should().Be(type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TumblrShareButtonWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new TumblrShareButtonWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string scheme, ITumblrShareButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new TumblrShareButtonWidget());
      Test(Fixture<TumblrShareButtonWidget>.Create());
    }

    return;

    static void Test(ITumblrShareButtonWidget original)
    {
      var clone = original.Clone<ITumblrShareButtonWidget>();

      clone.GetPropertyValue<byte>("TypeValue").Should().Be(original.GetPropertyValue<byte>("TypeValue"));
      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrShareButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new TumblrShareButtonWidget(), """<a href="http://www.tumblr.com/share" style="display:inline-block; text-indent:-9999px; overflow:hidden; width:80px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_1.png&#39;) top left no-repeat transparent;" title="Share on Tumblr">Share on Tumblr</a>""");
      Test(new TumblrShareButtonWidget().Type(TumblrShareButtonType.Second).ColorScheme(TumblrShareButtonColorScheme.Gray), """<a href="http://www.tumblr.com/share" style="display:inline-block; text-indent:-9999px; overflow:hidden; width:70px; height:20px; background:url(&#39;http://platform.tumblr.com/v1/share_2T.png&#39;) top left no-repeat transparent;" title="Share on Tumblr">Share on Tumblr</a>""");
      Test(Fixture<TumblrShareButtonWidget>.Create());
    }

    return;

    static void Test(ITumblrShareButtonWidget widget, params string[] html)
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