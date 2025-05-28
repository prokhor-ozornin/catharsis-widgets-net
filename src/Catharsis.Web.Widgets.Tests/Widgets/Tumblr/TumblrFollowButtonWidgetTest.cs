using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TumblrFollowButtonWidget"/>.</para>
/// </summary>
public sealed class TumblrFollowButtonWidgetTest : Test
{
  private ITumblrFollowButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public TumblrFollowButtonWidgetTest() => Widget = Fixture<ITumblrFollowButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TumblrFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TumblrFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITumblrFollowButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new TumblrFollowButtonWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<byte>("TypeValue").Should().Be((byte) TumblrFollowButtonType.First);
      widget.GetPropertyValue<string>("ColorSchemeValue").Should().Be(nameof(TumblrFollowButtonColorScheme.Light).ToLowerInvariant());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TumblrFollowButtonWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new TumblrFollowButtonWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, ITumblrFollowButtonWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.Type(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture<byte>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte type, ITumblrFollowButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TypeValue").Should().Be(type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.ColorScheme(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ColorScheme_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new TumblrFollowButtonWidget().ColorScheme(null)).ThrowExactly<ArgumentNullException>().WithParameterName("scheme");
      AssertionExtensions.Should(() => new TumblrFollowButtonWidget().ColorScheme(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("scheme");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string scheme, ITumblrFollowButtonWidget widget) => widget.ColorScheme(scheme).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorSchemeValue").Should().Be(scheme);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new TumblrFollowButtonWidget());
      Test(Fixture<TumblrFollowButtonWidget>.Create());
    }

    return;

    static void Test(ITumblrFollowButtonWidget original)
    {
      var clone = original.Clone<ITumblrFollowButtonWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<byte>("TypeValue").Should().Be(original.GetPropertyValue<byte>("TypeValue"));
      clone.GetPropertyValue<string>("ColorSchemeValue").Should().Be(original.GetPropertyValue<string>("ColorSchemeValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new TumblrFollowButtonWidget());
      Test(new TumblrFollowButtonWidget().Account("account"), """<iframe allowtransparency="true" border="0" class="btn" frameborder="0" height="25" scrolling="no" src="http://platform.tumblr.com/v1/follow_button.html?button_type=1&amp;tumblelog=account&amp;color_scheme=light" width="189"></iframe>""");
      Test(new TumblrFollowButtonWidget().Account("account").Type(TumblrFollowButtonType.Second).ColorScheme(TumblrFollowButtonColorScheme.Dark), """<iframe allowtransparency="true" border="0" class="btn" frameborder="0" height="25" scrolling="no" src="http://platform.tumblr.com/v1/follow_button.html?button_type=2&amp;tumblelog=account&amp;color_scheme=dark" width="113"></iframe>""");
      Test(Fixture<TumblrFollowButtonWidget>.Create());
    }

    return;

    static void Test(ITumblrFollowButtonWidget widget, params string[] html)
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