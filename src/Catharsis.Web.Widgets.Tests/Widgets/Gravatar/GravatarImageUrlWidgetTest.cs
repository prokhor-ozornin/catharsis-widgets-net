using FluentAssertions;
using Xunit;
using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarImageUrlWidget"/>.</para>
/// </summary>
/// <seealso cref="GravatarImageUrlWidget"/>
public sealed class GravatarImageUrlWidgetTest : Test
{
  private IGravatarImageUrlWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public GravatarImageUrlWidgetTest() => Widget = Fixture<IGravatarImageUrlWidget>.Create();

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
      widget.GetPropertyValue<string>("ExtensionValue").Should().BeNull();
      widget.GetPropertyValue<string>("HashValue").Should().BeNull();
      widget.GetPropertyValue<IDictionary<string, object>>("ParametersValue").Should().BeEmpty();
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

      new[] { Fixture<string>.Create() }.ForEach(extension => Test(extension, Widget));
    }

    return;

    static void Test(string extension, IGravatarImageUrlWidget widget) => widget.Extension(extension).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ExtensionValue").Should().Be(extension);
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

      new[] { Fixture<string>.Create() }.ForEach(hash => Test(hash, Widget));
    }

    return;

    static void Test(string hash, IGravatarImageUrlWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashValue").Should().Be(hash);
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

      Test(Fixture<string>.Create(), Fixture<Guid>.Create(), Widget);
    }

    return;

    static void Test(string name, object value, IGravatarImageUrlWidget widget) => widget.Parameter(name, value).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersValue").Should().Contain(name, value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarImageUrlWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new GravatarImageUrlWidget());
      Test(Fixture<GravatarImageUrlWidget>.Create());
    }

    return;

    static void Test(IGravatarImageUrlWidget original)
    {
      var clone = original.Clone<IGravatarImageUrlWidget>();

      clone.GetPropertyValue<string>("ExtensionValue").Should().Be(original.GetPropertyValue<string>("ExtensionValue"));
      clone.GetPropertyValue<string>("HashValue").Should().Be(original.GetPropertyValue<string>("HashValue"));
      clone.GetPropertyValue<IDictionary<string, object>>("ParametersValue").Should().Equal(original.GetPropertyValue<IDictionary<string, object>>("ParametersValue"));
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
      Test(new GravatarImageUrlWidget());
      Test(new GravatarImageUrlWidget().Hash("hash"), "http://www.gravatar.com/avatar/hash");
      Test(new GravatarImageUrlWidget().Hash("hash").Parameter("name", "value"), "http://www.gravatar.com/avatar/hash?name=value");
      Test(new GravatarImageUrlWidget().Hash("hash").Extension("extension").Parameter("first", 1).Parameter("second", 2), "http://www.gravatar.com/avatar/hash.extension?first=1&second=2");
      Test(Fixture<GravatarImageUrlWidget>.Create());
    }

    return;

    static void Test(IGravatarImageUrlWidget widget, params string[] html)
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