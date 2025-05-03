using Catharsis.Commons;
using FluentAssertions;
using Xunit;
using Catharsis.Extensions;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarImageUrlWidget"/>.</para>
/// </summary>
public sealed class GravatarImageUrlWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GravatarImageUrlWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GravatarImageUrlWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGravatarImageUrlWidget>();

    using (new AssertionScope())
    {
      var widget = new GravatarImageUrlWidget();
      widget.GetPropertyValue<string>("ExtensionProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HashProperty").Should().BeNull();
      widget.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").Should().BeEmpty();
    }
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
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Extension(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("extension");

      new GravatarImageUrlWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string extension, IGravatarImageUrlWidget widget) => widget.Extension(extension).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ExtensionProperty").Should().Be(extension);
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
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Hash(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("hash");

      new GravatarImageUrlWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string hash, IGravatarImageUrlWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashProperty").Should().Be(hash);
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
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Parameter(string.Empty, new object())).ThrowExactly<ArgumentException>().WithMessage("name");

      new GravatarImageUrlWidget().With(widget => Validate("id", Guid.NewGuid(), widget));
    }

    return;

    static void Validate(string name, object value, IGravatarImageUrlWidget widget) => widget.Parameter(name, value).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").Should().Contain(name, value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new GravatarImageUrlWidget());
      Validate(Attributes.GravatarImageUrlWidget());
    }

    return;

    static void Validate(IGravatarImageUrlWidget original)
    {
      var clone = original.Clone<IGravatarImageUrlWidget>();

      clone.Id.Should().Be(original.Id);
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