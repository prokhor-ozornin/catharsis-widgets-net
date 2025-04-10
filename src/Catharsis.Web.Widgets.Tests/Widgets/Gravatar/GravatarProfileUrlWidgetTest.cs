using Catharsis.Commons;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarProfileUrlWidget"/>.</para>
/// </summary>
public sealed class GravatarProfileUrlWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GravatarProfileUrlWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GravatarProfileUrlWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGravatarProfileUrlWidget>();

    var widget = new GravatarProfileUrlWidget();
    widget.GetPropertyValue<string>("HashProperty").Should().BeNull();
    widget.GetPropertyValue<string>("FormatProperty").Should().BeNull();
    widget.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").Should().BeEmpty();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Hash(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hash_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Hash(null)).ThrowExactly<ArgumentNullException>().WithParameterName("hash");
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Hash(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("hash");

      var widget = new GravatarProfileUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string hash, IGravatarProfileUrlWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashProperty").Should().Be(hash);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Format(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Format_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Format(null)).ThrowExactly<ArgumentNullException>().WithParameterName("format");
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Format(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("format");

      var widget = new GravatarProfileUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string format, IGravatarProfileUrlWidget widget) => widget.Format(format).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatProperty").Should().Be(format);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Parameter(string, object)"/> method.</para>
  /// </summary>
  [Fact]
  public void Parameter_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Parameter(null, new object())).ThrowExactly<ArgumentNullException>().WithParameterName("name");
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Parameter(string.Empty, new object())).ThrowExactly<ArgumentException>().WithMessage("name");
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Parameter("name", null)).ThrowExactly<ArgumentNullException>().WithParameterName("value");

      var widget = new GravatarProfileUrlWidget();
      Validate("id", Guid.NewGuid(), widget);
    }

    return;

    static void Validate(string name, object value, IGravatarProfileUrlWidget widget) => widget.Parameter(name, value).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").Should().Contain(name, value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new GravatarProfileUrlWidget());
      Validate(new GravatarProfileUrlWidget().Hash("hash"), "http://www.gravatar.com/hash");
      Validate(new GravatarProfileUrlWidget().Hash("hash").Parameter("name", "value"), "http://www.gravatar.com/hash?name=value");
      Validate(new GravatarProfileUrlWidget().Hash("hash").Format("format").Parameter("first", 1).Parameter("second", 2), "http://www.gravatar.com/hash.format?first=1&second=2");
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