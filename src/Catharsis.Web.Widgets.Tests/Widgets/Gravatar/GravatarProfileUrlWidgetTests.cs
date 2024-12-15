using Catharsis.Commons;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarProfileUrlWidget"/>.</para>
/// </summary>
public sealed class GravatarProfileUrlWidgetTests : ClassTest<GravatarProfileUrlWidget>
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
    widget.Hash().Should().BeNull();
    widget.Format().Should().BeNull();
    widget.GetFieldValue<IDictionary<string, object>>("paramters").Should().BeEmpty();
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
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Hash(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("hash");

      var widget = new GravatarProfileUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string hash, IGravatarProfileUrlWidget widget)
    {
      widget.Hash(hash).Should().BeSameAs(widget);
      widget.Hash().Should().Be(hash);
    }
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
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Format(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("format");

      var widget = new GravatarProfileUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string format, IGravatarProfileUrlWidget widget)
    {
      widget.Format(format).Should().BeSameAs(widget);
      widget.Format().Should().Be(format);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Parameter(string, object)"/> method.</para>
  /// </summary>
  [Fact]
  public void Parameter_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new GravatarProfileUrlWidget().Parameter(null, new object()));
    Assert.Throws<ArgumentNullException>(() => new GravatarProfileUrlWidget().Parameter("name", null));
    Assert.Throws<ArgumentException>(() => new GravatarProfileUrlWidget().Parameter(string.Empty, new object()));

    var widget = new GravatarProfileUrlWidget();
    Assert.False(widget.GetFieldValue<IDictionary<string, object>>("parameters").Any());
    Assert.True(ReferenceEquals(widget.Parameter("name", "value"), widget));
    var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
    Assert.Equal(1, parameters.Count);
    Assert.Equal("value", parameters["name"]);
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