using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IGravatarProfileUrlWidgetExtensions"/>.</para>
/// </summary>
public sealed class IGravatarProfileUrlWidgetExtensionsTest : Test
{
  private IGravatarProfileUrlWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IGravatarProfileUrlWidgetExtensionsTest() => Widget = Fixture<IGravatarProfileUrlWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Email(IGravatarProfileUrlWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Email_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Email(null, "email")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Email(null)).ThrowExactly<ArgumentNullException>().WithParameterName("email");
      AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Email(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("email");

      Test("prokhor.ozornin@yandex.ru", "61b98d241eaa1ce237c979e7a8181d13", Widget);
    }

    return;

    static void Test(string email, string hash, IGravatarProfileUrlWidget widget) => widget.Email(email).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashValue").Should().Be(hash);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Json(IGravatarProfileUrlWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Json_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Json(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string callback, IGravatarProfileUrlWidget widget)
    {
      widget.Json(callback).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("FormatValue").Should().Be("json");
      widget.GetPropertyValue<IDictionary<string, object>>("ParametersValue").ToValueTuple().Should().Equal(("callback", callback));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Xml(IGravatarProfileUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Xml_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Xml(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(Widget);
    }

    return;

    static void Test(IGravatarProfileUrlWidget widget) => widget.Xml().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatValue").Should().Be("xml");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Php(IGravatarProfileUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Php_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Php(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(Widget);
    }

    return;

    static void Test(IGravatarProfileUrlWidget widget) => widget.Php().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatValue").Should().Be("php");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Vcf(IGravatarProfileUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Vcf_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Vcf(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(Widget);
    }

    return;

    static void Test(IGravatarProfileUrlWidget widget) => widget.Vcf().Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatValue").Should().Be("vcf");
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Qr(IGravatarProfileUrlWidget, short?)"/> method.</para>
  /// </summary>
  [Fact]
  public void Qr_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Qr(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short? size, IGravatarProfileUrlWidget widget) => widget.Qr(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FormatValue").Should().Be("qr").And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersValue").ToValueTuple().Should().Equal(("size", size));
  }
}