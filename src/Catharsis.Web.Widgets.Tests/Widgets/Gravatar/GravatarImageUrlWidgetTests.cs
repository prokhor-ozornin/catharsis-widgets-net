using Catharsis.Commons;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarImageUrlWidget"/>.</para>
/// </summary>
public sealed class GravatarImageUrlWidgetTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GravatarImageUrlWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GravatarImageUrlWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGravatarImageUrlWidget>();
  
    var widget = new GravatarImageUrlWidget();
    widget.Extension().Should().BeNull();
    widget.Hash().Should().BeNull();
    widget.GetFieldValue<IDictionary<string, object>>("parameters").Should().BeEmpty();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Extension(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Extension_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Extension(null)).ThrowExactly<ArgumentNullException>().WithParameterName("extension");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Extension(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("extension");

      var widget = new GravatarImageUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string extension, IGravatarImageUrlWidget widget)
    {
      widget.Extension(extension).Should().BeSameAs(widget);
      widget.Extension().Should().Be(extension);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Hash(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hash_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Hash(null)).ThrowExactly<ArgumentNullException>().WithParameterName("hash");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Hash(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("hash");

      var widget = new GravatarImageUrlWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string hash, IGravatarImageUrlWidget widget)
    {
      widget.Hash(hash).Should().BeSameAs(widget);
      widget.Hash().Should().Be(hash);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Parameter(string, object)"/> method.</para>
  /// </summary>
  [Fact]
  public void Parameter_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Parameter(null, new object())).ThrowExactly<ArgumentNullException>().WithParameterName("name");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Parameter(string.Empty, new object())).ThrowExactly<ArgumentException>().WithParameterName("name");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Parameter("name", null)).ThrowExactly<ArgumentNullException>().WithParameterName("value");

      var widget = new GravatarImageUrlWidget();
      Validate("id", Guid.NewGuid(), widget);
    }

    return;

    static void Validate(string name, object value, IGravatarImageUrlWidget widget)
    {
      widget.Parameter(name, value).Should().BeSameAs(widget);
      widget.GetFieldValue<IDictionary<string, object>>("parameters").Should().Contain(name, value);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new GravatarImageUrlWidget());
      Validate(new GravatarImageUrlWidget().Hash("hash"), "http://www.gravatar.com/avatar/hash");
      Validate(new GravatarImageUrlWidget().Hash("hash").Parameter("name", "value"), "http://www.gravatar.com/avatar/hash?name=value");
      Validate(new GravatarImageUrlWidget().Hash("hash").Extension("extension").Parameter("first", 1).Parameter("second", 2), "http://www.gravatar.com/avatar/hash.extension?first=1&second=2");
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