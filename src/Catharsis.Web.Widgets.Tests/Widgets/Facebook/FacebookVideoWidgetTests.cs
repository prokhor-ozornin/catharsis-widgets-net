using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="FacebookVideoWidget"/>.</para>
/// </summary>
public sealed class FacebookVideoWidgetTests : ClassTest<FacebookVideoWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookVideoWidget>();

    var widget = new FacebookVideoWidget();
    widget.Id().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookVideoWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new FacebookVideoWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IFacebookVideoWidget widget)
    {
      widget.Id(height).Should().BeSameAs(widget);
      widget.Id().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookVideoWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new FacebookVideoWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IFacebookVideoWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookVideoWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new FacebookVideoWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IFacebookVideoWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new FacebookVideoWidget().ToString());
    Assert.Equal(string.Empty, new FacebookVideoWidget().Id("id").Width("width").ToString());
    Assert.Equal(string.Empty, new FacebookVideoWidget().Id("id").Height("height").ToString());
    Assert.Equal(string.Empty, new FacebookVideoWidget().Id("width").Height("height").ToString());

    Assert.Equal("""<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://www.facebook.com/video/embed?video_id=id" webkitallowfullscreen="true" width="width"></iframe>""", new FacebookVideoWidget().Id("id").Width("width").Height("height").ToString());
  }
}