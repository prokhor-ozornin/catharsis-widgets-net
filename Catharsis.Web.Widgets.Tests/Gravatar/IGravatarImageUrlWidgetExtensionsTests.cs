using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IGravatarImageUrlWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IGravatarImageUrlWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of following methods :</para>
    ///   <list type="bullet">
    ///     <item><description><see cref="IGravatarImageUrlWidgetExtensions.Default(IGravatarImageUrlWidget, string)"/></description></item>
    ///     <item><description><see cref="IGravatarImageUrlWidgetExtensions.Default(IGravatarImageUrlWidget, GravatarDefaultImage)"/></description></item>
    ///   </list>
    /// </summary>
    [Fact]
    public void Default_Methods()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarImageUrlWidgetExtensions.Default(null, "url"));
      Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Default(null));
      Assert.Throws<ArgumentNullException>(() => IGravatarImageUrlWidgetExtensions.Default(null, GravatarDefaultImage.NotFound));
      Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Default(string.Empty));

      new GravatarImageUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Default("url"), widget));
        var parameters = widget.Field("parameters").To<Dictionary<string, object>>();
        Assert.Equal(1, parameters.Count);
        Assert.Equal("default", parameters.Single().Key);
        Assert.Equal("url", parameters.Single().Value);
      });

      new GravatarImageUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Default(GravatarDefaultImage.Blank), widget));
        var parameters = widget.Field("parameters").To<Dictionary<string, object>>();
        Assert.Equal(1, parameters.Count);
        Assert.Equal("default", parameters.Single().Key);
        Assert.Equal("blank", parameters.Single().Value);
      });
      new GravatarImageUrlWidget().With(widget => Assert.Equal("identicon", widget.Default(GravatarDefaultImage.IdentIcon).Field("parameters").To<Dictionary<string, object>>().Single().Value));
      new GravatarImageUrlWidget().With(widget => Assert.Equal("monsterid", widget.Default(GravatarDefaultImage.MonsterId).Field("parameters").To<Dictionary<string, object>>().Single().Value));
      new GravatarImageUrlWidget().With(widget => Assert.Equal("mm", widget.Default(GravatarDefaultImage.MysteryMan).Field("parameters").To<Dictionary<string, object>>().Single().Value));
      new GravatarImageUrlWidget().With(widget => Assert.Equal("404", widget.Default(GravatarDefaultImage.NotFound).Field("parameters").To<Dictionary<string, object>>().Single().Value));
      new GravatarImageUrlWidget().With(widget => Assert.Equal("retro", widget.Default(GravatarDefaultImage.Retro).Field("parameters").To<Dictionary<string, object>>().Single().Value));
      new GravatarImageUrlWidget().With(widget => Assert.Equal("wavatar", widget.Default(GravatarDefaultImage.Wavatar).Field("parameters").To<Dictionary<string, object>>().Single().Value));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.Email(IGravatarImageUrlWidget, string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Email_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarImageUrlWidgetExtensions.Email(null, "email"));
      Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Email(null));
      Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Email(string.Empty));

      new GravatarImageUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Email("prokhor.ozornin@yandex.ru"), widget));
        Assert.Equal("61b98d241eaa1ce237c979e7a8181d13", widget.Field("hash").To<string>());
      });

      Assert.Equal(new GravatarImageUrlWidget().Email("prokhor.ozornin@yandex.ru").Field("hash").To<string>(), new GravatarImageUrlWidget().Email(" PROKHOR.OZORNIN@yandex.ru ").Field("hash").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.ForceDefault(IGravatarImageUrlWidget)"/> method.</para>
    /// </summary>
    [Fact]
    public void ForceDefault_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarImageUrlWidgetExtensions.ForceDefault(null));

      new GravatarImageUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.ForceDefault(), widget));
        var parameters = widget.Field("parameters").To<Dictionary<string, object>>();
        Assert.Equal(1, parameters.Count);
        Assert.Equal("forcedefault", parameters.Single().Key);
        Assert.Equal("y", parameters.Single().Value);
      });
    }

    /// <summary>
    ///   <para>Performs testing of following methods :</para>
    ///   <list type="bullet">
    ///     <item><description><see cref="IGravatarImageUrlWidgetExtensions.Rating(IGravatarImageUrlWidget, string)"/></description></item>
    ///     <item><description><see cref="IGravatarImageUrlWidgetExtensions.Rating(IGravatarImageUrlWidget, GravatarImageRating)"/></description></item>
    ///   </list>
    /// </summary>
    [Fact]
    public void Rating_Methods()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarImageUrlWidgetExtensions.Rating(null, "rating"));
      Assert.Throws<ArgumentNullException>(() => new GravatarImageUrlWidget().Rating(null));
      Assert.Throws<ArgumentNullException>(() => IGravatarImageUrlWidgetExtensions.Rating(null, GravatarImageRating.G));
      Assert.Throws<ArgumentException>(() => new GravatarImageUrlWidget().Rating(string.Empty));

      new GravatarImageUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Rating("rating"), widget));
        var parameters = widget.Field("parameters").To<Dictionary<string, object>>();
        Assert.Equal(1, parameters.Count);
        Assert.Equal("rating", parameters.Single().Key);
        Assert.Equal("rating", parameters.Single().Value);
      });

      new GravatarImageUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Rating(GravatarImageRating.G), widget));
        var parameters = widget.Field("parameters").To<Dictionary<string, object>>();
        Assert.Equal(1, parameters.Count);
        Assert.Equal("rating", parameters.Single().Key);
        Assert.Equal("g", parameters.Single().Value);
      });
      new GravatarImageUrlWidget().With(widget => Assert.Equal("pg", widget.Rating(GravatarImageRating.PG).Field("parameters").To<Dictionary<string, object>>().Single().Value));
      new GravatarImageUrlWidget().With(widget => Assert.Equal("r", widget.Rating(GravatarImageRating.R).Field("parameters").To<Dictionary<string, object>>().Single().Value));
      new GravatarImageUrlWidget().With(widget => Assert.Equal("x", widget.Rating(GravatarImageRating.X).Field("parameters").To<Dictionary<string, object>>().Single().Value));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.Size(IGravatarImageUrlWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IGravatarImageUrlWidgetExtensions.Size(null, 0));

      new GravatarImageUrlWidget().With(widget =>
      {
        Assert.True(ReferenceEquals(widget.Size(1), widget));
        var parameters = widget.Field("parameters").To<Dictionary<string, object>>();
        Assert.Equal(1, parameters.Count);
        Assert.Equal("size", parameters.Single().Key);
        Assert.Equal((short) 1, parameters.Single().Value);
      });
    }
  }
}