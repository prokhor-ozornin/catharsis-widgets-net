using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleLatestCommentsWidget"/>.</para>
/// </summary>
public sealed class CackleLatestCommentsWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleLatestCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleLatestCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleLatestCommentsWidget>();

    using (new AssertionScope())
    {
      var widget = new CackleLatestCommentsWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<short>("AvatarSizeProperty").Should().Be(32);
      widget.GetPropertyValue<byte>("MaxProperty").Should().Be(5);
      widget.GetPropertyValue<int>("TextSizeProperty").Should().Be(150);
      widget.GetPropertyValue<int>("TitleSizeProperty").Should().Be(40);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new CackleLatestCommentsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new CackleLatestCommentsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new CackleLatestCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, ICackleLatestCommentsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.AvatarSize(short)"/> method.</para>
  /// </summary>
  [Fact]
  public void AvatarSize_Method()
  {
    using (new AssertionScope())
    {
      new CackleLatestCommentsWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short size, ICackleLatestCommentsWidget widget) => widget.AvatarSize(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<short>("AvatarSizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Max(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Max_Method()
  {
    using (new AssertionScope())
    {
      new CackleLatestCommentsWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte max, ICackleLatestCommentsWidget widget) => widget.Max(max).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("MaxProperty").Should().Be(max);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TextSize(int)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextSize_Method()
  {
    using (new AssertionScope())
    {
      new CackleLatestCommentsWidget().With(widget => new[] { int.MinValue, int.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(int size, ICackleLatestCommentsWidget widget) => widget.TextSize(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<int>("TextSizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.TitleSize(int)"/> method.</para>
  /// </summary>
  [Fact]
  public void TitleSize_Method()
  {
    using (new AssertionScope())
    {
      new CackleLatestCommentsWidget().With(widget => new[] { int.MinValue, int.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(int size, ICackleLatestCommentsWidget widget) => widget.TitleSize(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<int>("TitleSizeProperty").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleLatestCommentsWidget());
      Validate(Attributes.CackleLatestCommentsWidget());
    }

    return;

    static void Validate(ICackleLatestCommentsWidget original)
    {
      var clone = original.Clone<ICackleLatestCommentsWidget>();

      clone.GetPropertyValue<string>("AccountProperty").Should().Be(original.GetPropertyValue<string>("AccountProperty"));
      clone.GetPropertyValue<short>("AvatarSizeProperty").Should().Be(original.GetPropertyValue<short>("AvatarSizeProperty"));
      clone.GetPropertyValue<byte>("MaxProperty").Should().Be(original.GetPropertyValue<byte>("MaxProperty"));
      clone.GetPropertyValue<int>("TextSizeProperty").Should().Be(original.GetPropertyValue<int>("TextSizeProperty"));
      clone.GetPropertyValue<int>("TitleSizeProperty").Should().Be(original.GetPropertyValue<int>("TitleSizeProperty"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLatestCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleLatestCommentsWidget());
      Validate(new CackleLatestCommentsWidget().Account("account"), """<div id="mc-last"></div>""", """{"widget":"CommentRecent","id":"account","size":5,"avatarSize":32,"textSize":150,"titleSize":40}""");
      Validate(new CackleLatestCommentsWidget().Account("account").Max(1).AvatarSize(2).TextSize(3).TitleSize(4), """<div id="mc-last"></div>""", """{"widget":"CommentRecent","id":"account","size":1,"avatarSize":2,"textSize":3,"titleSize":4}""");
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