using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SoundCloudProfileIconWidget"/>.</para>
/// </summary>
public sealed class SoundCloudProfileIconWidgetTests : ClassTest<SoundCloudProfileIconWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="SoundCloudProfileIconWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(SoundCloudProfileIconWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ISoundCloudProfileIconWidget>();

    var widget = new SoundCloudProfileIconWidget();
    widget.Account().Should().BeNull();
    widget.Color().Should().Be("orange_white");
    widget.Size().Should().Be((short) SoundCloudProfileIconSize.Size32);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new SoundCloudProfileIconWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new SoundCloudProfileIconWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new SoundCloudProfileIconWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, ISoundCloudProfileIconWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Color(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new SoundCloudProfileIconWidget().Color(null));
    Assert.Throws<ArgumentException>(() => new SoundCloudProfileIconWidget().Color(string.Empty));

    using (new AssertionScope())
    {
      var widget = new SoundCloudProfileIconWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, ISoundCloudProfileIconWidget widget)
    {
      widget.Color(color).Should().BeSameAs(widget);
      widget.Color().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Size(short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      var widget = new SoundCloudProfileIconWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short size, ISoundCloudProfileIconWidget widget)
    {
      widget.Size(size).Should().BeSameAs(widget);
      widget.Size().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new SoundCloudProfileIconWidget());
      Validate(new SoundCloudProfileIconWidget().Account("account"), """<iframe allowtransparency="true" frameborder="0" scrolling="no" src="https://w.soundcloud.com/icon/?url=http://soundcloud.com/account&amp;color=orange_white&amp;size=32" style="width: 32px; height: 32px;"></iframe>""");
      Validate(new SoundCloudProfileIconWidget().Account("account").Color("color").Size(1), """<iframe allowtransparency="true" frameborder="0" scrolling="no" src="https://w.soundcloud.com/icon/?url=http://soundcloud.com/account&amp;color=color&amp;size=1" style="width: 1px; height: 1px;"></iframe>""");
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