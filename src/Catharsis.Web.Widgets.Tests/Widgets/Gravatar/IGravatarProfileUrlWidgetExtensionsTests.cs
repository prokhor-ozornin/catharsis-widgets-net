using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IGravatarProfileUrlWidgetExtensions"/>.</para>
/// </summary>
public sealed class IGravatarProfileUrlWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Email(IGravatarProfileUrlWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Email_Method()
  {
    AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Email(null, "email")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Email(null)).ThrowExactly<ArgumentNullException>().WithParameterName("email");
    AssertionExtensions.Should(() => new GravatarProfileUrlWidget().Email(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("email");

    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Email("prokhor.ozornin@yandex.ru"), widget));
      Assert.Equal("61b98d241eaa1ce237c979e7a8181d13", widget.Hash());
    });

    Assert.Equal(new GravatarProfileUrlWidget().Email("prokhor.ozornin@yandex.ru").Hash(), new GravatarProfileUrlWidget().Email(" PROKHOR.OZORNIN@yandex.ru ").Hash());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Json(IGravatarProfileUrlWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Json_Method()
  {
    AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Json(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Json(), widget));
      Assert.Equal("json", widget.Format());
    });
    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.Equal("json", widget.Json("callback").Format());
        
      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
      Assert.Equal(1, parameters.Count);
      Assert.Equal("callback", parameters.Single().Key);
      Assert.Equal("callback", parameters.Single().Value);
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Xml(IGravatarProfileUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Xml_Method()
  {
    AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Xml(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Xml(), widget));
      Assert.Equal("xml", widget.Format());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Php(IGravatarProfileUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Php_Method()
  {
    AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Php(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Php(), widget));
      Assert.Equal("php", widget.Format());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Vcf(IGravatarProfileUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void Vcf_Method()
  {
    AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Vcf(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Vcf(), widget));
      Assert.Equal("vcf", widget.Format());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Qr(IGravatarProfileUrlWidget, short?)"/> method.</para>
  /// </summary>
  [Fact]
  public void Qr_Method()
  {
    AssertionExtensions.Should(() => IGravatarProfileUrlWidgetExtensions.Qr(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Qr(), widget));
      Assert.Equal("qr", widget.Format());
    });
    new GravatarProfileUrlWidget().With(widget =>
    {
      Assert.Equal("qr", widget.Qr(1).Format());

      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
      Assert.Equal(1, parameters.Count);
      Assert.Equal("size", parameters.Single().Key);
      Assert.Equal((short) 1, parameters.Single().Value);
    });
  }
}