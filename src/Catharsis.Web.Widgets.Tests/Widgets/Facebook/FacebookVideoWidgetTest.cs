using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookVideoWidget"/>.</para>
/// </summary>
public sealed class FacebookVideoWidgetTest : Test
{
  private IFacebookVideoWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookVideoWidgetTest() => Widget = Fixture<IFacebookVideoWidget>.Create();

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
      widget.GetPropertyValue<string>("IdValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IFacebookVideoWidget widget) => widget.Id(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(height);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IFacebookVideoWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
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

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IFacebookVideoWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookVideoWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookVideoWidget());
      Test(Fixture<FacebookVideoWidget>.Create());
    }

    return;

    static void Test(IFacebookVideoWidget original)
    {
      var clone = original.Clone<IFacebookVideoWidget>();

      clone.GetPropertyValue<string>("IdValue").Should().Be(original.GetPropertyValue<string>("IdValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
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
      Test(new FacebookVideoWidget());
      Test(new FacebookVideoWidget().Id("id").Width("width"));
      Test(new FacebookVideoWidget().Id("id").Height("height"));
      Test(new FacebookVideoWidget().Id("width").Height("height"));
      Test(new FacebookVideoWidget().Id("id").Width("width").Height("height"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://www.facebook.com/video/embed?video_id=id" webkitallowfullscreen="true" width="width"></iframe>""");
      Test(Fixture<FacebookVideoWidget>.Create());
    }

    return;

    static void Test(IFacebookVideoWidget widget, params string[] html)
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