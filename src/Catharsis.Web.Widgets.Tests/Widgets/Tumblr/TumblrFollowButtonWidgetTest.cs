using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TumblrFollowButtonWidget"/>.</para>
/// </summary>
public sealed class TumblrFollowButtonWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TumblrFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(TumblrFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ITumblrFollowButtonWidget>();

    var widget = new TumblrFollowButtonWidget();
    widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
    widget.GetPropertyValue<byte>("TypeProperty").Should().Be((byte) TumblrFollowButtonType.First);
    widget.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(TumblrFollowButtonColorScheme.Light.ToString().ToLowerInvariant());
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

      var widget = new TumblrFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, ITumblrFollowButtonWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("AccountProperty").Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TumblrFollowButtonWidget.Type(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      var widget = new TumblrFollowButtonWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte type, ITumblrFollowButtonWidget widget)
    {
      widget.Type(type).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("TypeProperty").Should().Be(type);
    }
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

      var widget = new TumblrFollowButtonWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string scheme, ITumblrFollowButtonWidget widget)
    {
      widget.ColorScheme(scheme).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ColorSchemeProperty").Should().Be(scheme);
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
      Validate(new TumblrFollowButtonWidget());
      Validate(new TumblrFollowButtonWidget().Account("account"), """<iframe allowtransparency="true" border="0" class="btn" frameborder="0" height="25" scrolling="no" src="http://platform.tumblr.com/v1/follow_button.html?button_type=1&amp;tumblelog=account&amp;color_scheme=light" width="189"></iframe>""");
      Validate(new TumblrFollowButtonWidget().Account("account").Type(TumblrFollowButtonType.Second).ColorScheme(TumblrFollowButtonColorScheme.Dark), """<iframe allowtransparency="true" border="0" class="btn" frameborder="0" height="25" scrolling="no" src="http://platform.tumblr.com/v1/follow_button.html?button_type=2&amp;tumblelog=account&amp;color_scheme=dark" width="113"></iframe>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
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