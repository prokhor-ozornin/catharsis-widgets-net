using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookVideoWidget"/>.</para>
/// </summary>
public sealed class FacebookVideoWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookVideoWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookVideoWidget();
      widget.GetPropertyValue<string>("IdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookVideoWidget().Id(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new FacebookVideoWidget().Id(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new FacebookVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IFacebookVideoWidget widget) => widget.Id(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookVideoWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new FacebookVideoWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new FacebookVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IFacebookVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookVideoWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new FacebookVideoWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new FacebookVideoWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IFacebookVideoWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookVideoWidget());
      Validate(Attributes.FacebookVideoWidget());
    }

    return;

    static void Validate(IFacebookVideoWidget original)
    {
      var clone = original.Clone<IFacebookVideoWidget>();

      clone.Id.Should().Be(original.Id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookVideoWidget());
      Validate(new FacebookVideoWidget().Id("id").Width("width"));
      Validate(new FacebookVideoWidget().Id("id").Height("height"));
      Validate(new FacebookVideoWidget().Id("width").Height("height"));
      Validate(new FacebookVideoWidget().Id("id").Width("width").Height("height"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://www.facebook.com/video/embed?video_id=id" webkitallowfullscreen="true" width="width"></iframe>""");
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