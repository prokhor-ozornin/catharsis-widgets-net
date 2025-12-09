using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GravatarProfileUrlWidget"/>.</para>
/// </summary>
/// <seealso cref="GravatarProfileUrlWidget"/>
public sealed class GravatarProfileUrlWidgetTest : Test
{
  private IGravatarProfileUrlWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public GravatarProfileUrlWidgetTest() => Widget = Fixture<IGravatarProfileUrlWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GravatarProfileUrlWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GravatarProfileUrlWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGravatarProfileUrlWidget>();

    using (new AssertionScope())
    {
      var widget = new GravatarProfileUrlWidget();
      widget.GetPropertyValue<string>("HashValue").Should().BeNull();
      widget.GetPropertyValue<string>("FormatValue").Should().BeNull();
      widget.GetPropertyValue<IDictionary<string, object>>("ParametersValue").Should().BeEmpty();
    }
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

      new[] { Fixture<string>.Create() }.ForEach(hash => Test(hash, Widget));
    }

    return;

    static void Test(string hash, IGravatarProfileUrlWidget widget) => widget.Hash(hash).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashValue").Should().Be(hash);
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

      new[] { Fixture<string>.Create() }.ForEach(format => Test(format, Widget));
    }

    return;

    static void Test(string format, IGravatarProfileUrlWidget widget) => widget.Format(format).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatValue").Should().Be(format);
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

      Test(Fixture<string>.Create(), Fixture<Guid>.Create(), Widget);
    }

    return;

    static void Test(string name, object value, IGravatarProfileUrlWidget widget) => widget.Parameter(name, value).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersValue").Should().Contain(name, value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new GravatarProfileUrlWidget());
      Test(Fixture<GravatarProfileUrlWidget>.Create());
    }

    return;

    static void Test(IGravatarProfileUrlWidget original)
    {
      var clone = original.Clone<IGravatarProfileUrlWidget>();

      clone.GetPropertyValue<string>("FormatValue").Should().Be(original.GetPropertyValue<string>("FormatValue"));
      clone.GetPropertyValue<string>("HashValue").Should().Be(original.GetPropertyValue<string>("HashValue"));
      clone.GetPropertyValue<IDictionary<string, object>>("ParametersValue").Should().Equal(original.GetPropertyValue<IDictionary<string, object>>("ParametersValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GravatarProfileUrlWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new GravatarProfileUrlWidget());
      Test(new GravatarProfileUrlWidget().Hash("hash"), "http://www.gravatar.com/hash");
      Test(new GravatarProfileUrlWidget().Hash("hash").Parameter("name", "value"), "http://www.gravatar.com/hash?name=value");
      Test(new GravatarProfileUrlWidget().Hash("hash").Format("format").Parameter("first", 1).Parameter("second", 2), "http://www.gravatar.com/hash.format?first=1&second=2");
      Test(Fixture<GravatarProfileUrlWidget>.Create());
    }

    return;

    static void Test(IGravatarProfileUrlWidget widget, params string[] html)
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