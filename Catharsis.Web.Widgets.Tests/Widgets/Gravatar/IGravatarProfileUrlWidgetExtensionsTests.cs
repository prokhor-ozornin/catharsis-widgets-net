using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IGravatarProfileUrlWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IGravatarProfileUrlWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Email(IGravatarProfileUrlWidget, string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Email_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarProfileUrlWidgetExtensions.Email(null, "email"));
      Assert.Throws<ArgumentNullException>(() => new GravatarProfileUrlWidget().Email(null));
      Assert.Throws<ArgumentException>(() => new GravatarProfileUrlWidget().Email(string.Empty));

      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Email("prokhor.ozornin@yandex.ru"), widget));
        Assert.Equal("61b98d241eaa1ce237c979e7a8181d13", widget.Field("hash").To<string>());
      });

      Assert.Equal(new GravatarProfileUrlWidget().Email("prokhor.ozornin@yandex.ru").Field("hash").To<string>(), new GravatarProfileUrlWidget().Email(" PROKHOR.OZORNIN@yandex.ru ").Field("hash").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Json(IGravatarProfileUrlWidget, string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Json_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarProfileUrlWidgetExtensions.Json(null));

      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Json(), widget));
        Assert.Equal("json", widget.Field("format").To<string>());
      });
      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.Equal("json", widget.Json("callback").Field("format").To<string>());
        
        var parameters = widget.Field("parameters").To<IDictionary<string, object>>();
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
      Assert.Throws<ArgumentNullException>(() => IGravatarProfileUrlWidgetExtensions.Xml(null));

      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Xml(), widget));
        Assert.Equal("xml", widget.Field("format").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Php(IGravatarProfileUrlWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Php_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarProfileUrlWidgetExtensions.Php(null));

      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Php(), widget));
        Assert.Equal("php", widget.Field("format").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Vcf(IGravatarProfileUrlWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void Vcf_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarProfileUrlWidgetExtensions.Vcf(null));

      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Vcf(), widget));
        Assert.Equal("vcf", widget.Field("format").To<string>());
      });
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarProfileUrlWidgetExtensions.Qr(IGravatarProfileUrlWidget, short?)"/> method.</para>
    /// </summary>
    [Fact]
    public void Qr_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarProfileUrlWidgetExtensions.Qr(null));

      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Qr(), widget));
        Assert.Equal("qr", widget.Field("format").To<string>());
      });
      new GravatarProfileUrlWidget().With(widget =>
      {
        Assert.Equal("qr", widget.Qr(1).Field("format").To<string>());

        var parameters = widget.Field("parameters").To<IDictionary<string, object>>();
        Assert.Equal(1, parameters.Count);
        Assert.Equal("size", parameters.Single().Key);
        Assert.Equal((short) 1, parameters.Single().Value);
      });
    }
  }
}