using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="CackleLatestCommentsWidget"/>.</para>
/// </summary>
public sealed class CackleLatestCommentsWidgetTests : ClassTest<CackleLatestCommentsWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleLatestCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleLatestCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleLatestCommentsWidget>();

    var widget = new CackleLatestCommentsWidget();
    widget.Account().Should().BeNull();
    widget.AvatarSize().Should().Be(32);
    widget.Max().Should().Be(5);
    widget.TextSize().Should().Be(150);
    widget.TitleSize().Should().Be(40);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new CackleLatestCommentsWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new CackleLatestCommentsWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new CackleLatestCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, ICackleLatestCommentsWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.AvatarSize(short)"/> method.</para>
  /// </summary>
  [Fact]
  public void AvatarSize_Method()
  {
    using (new AssertionScope())
    {
      var widget = new CackleLatestCommentsWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short size, ICackleLatestCommentsWidget widget)
    {
      widget.AvatarSize(size).Should().BeSameAs(widget);
      widget.AvatarSize().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Max(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Max_Method()
  {
    using (new AssertionScope())
    {
      var widget = new CackleLatestCommentsWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte max, ICackleLatestCommentsWidget widget)
    {
      widget.Max(max).Should().BeSameAs(widget);
      widget.Max().Should().Be(max);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TextSize(int)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextSize_Method()
  {
    using (new AssertionScope())
    {
      var widget = new CackleLatestCommentsWidget();
      new[] { int.MinValue, int.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(int size, ICackleLatestCommentsWidget widget)
    {
      widget.TextSize(size).Should().BeSameAs(widget);
      widget.TextSize().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TitleSize(int)"/> method.</para>
  /// </summary>
  [Fact]
  public void TitleSize_Method()
  {
    using (new AssertionScope())
    {
      var widget = new CackleLatestCommentsWidget();
      new[] { int.MinValue, int.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(int size, ICackleLatestCommentsWidget widget)
    {
      widget.TitleSize(size).Should().BeSameAs(widget);
      widget.TitleSize().Should().Be(size);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new CackleLatestCommentsWidget().ToString());

    var html = new CackleLatestCommentsWidget().Account("account").ToString();
    Assert.True(html.Contains("""<div id="mc-last"></div>"""));
    Assert.True(html.Contains("""{"widget":"CommentRecent","id":"account","size":5,"avatarSize":32,"textSize":150,"titleSize":40}"""));

    html = new CackleLatestCommentsWidget().Account("account").Max(1).AvatarSize(2).TextSize(3).TitleSize(4).ToString();
    Assert.True(html.Contains("""<div id="mc-last"></div>"""));
    Assert.True(html.Contains("""{"widget":"CommentRecent","id":"account","size":1,"avatarSize":2,"textSize":3,"titleSize":4}"""));
  }
}