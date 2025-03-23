using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IGravatarImageUrlWidgetExtensions"/>.</para>
/// </summary>
public sealed class IGravatarImageUrlWidgetExtensionsTest : UnitTest
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
    AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Default(null, "url")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => new GravatarImageUrlWidget().Default(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
    AssertionExtensions.Should(() => new GravatarImageUrlWidget().Default(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

    new GravatarImageUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Default("url"), widget));
      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
      Assert.Equal(1, parameters.Count);
      Assert.Equal("default", parameters.Single().Key);
      Assert.Equal("url", parameters.Single().Value);
    });

    new GravatarImageUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Default(GravatarDefaultImage.Blank), widget));
      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
      Assert.Equal(1, parameters.Count);
      Assert.Equal("default", parameters.Single().Key);
      Assert.Equal("blank", parameters.Single().Value);
    });
    new GravatarImageUrlWidget().With(widget => Assert.Equal("identicon", widget.Default(GravatarDefaultImage.IdentIcon).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
    new GravatarImageUrlWidget().With(widget => Assert.Equal("monsterid", widget.Default(GravatarDefaultImage.MonsterId).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
    new GravatarImageUrlWidget().With(widget => Assert.Equal("mm", widget.Default(GravatarDefaultImage.MysteryMan).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
    new GravatarImageUrlWidget().With(widget => Assert.Equal("404", widget.Default(GravatarDefaultImage.NotFound).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
    new GravatarImageUrlWidget().With(widget => Assert.Equal("retro", widget.Default(GravatarDefaultImage.Retro).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
    new GravatarImageUrlWidget().With(widget => Assert.Equal("wavatar", widget.Default(GravatarDefaultImage.Wavatar).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.Email(IGravatarImageUrlWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Email_Method()
  {
    AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Email(null, "email")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => new GravatarImageUrlWidget().Email(null)).ThrowExactly<ArgumentNullException>().WithParameterName("email");
    AssertionExtensions.Should(() => new GravatarImageUrlWidget().Email(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("email");

    new GravatarImageUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Email("prokhor.ozornin@yandex.ru"), widget));
      Assert.Equal("61b98d241eaa1ce237c979e7a8181d13", widget.GetPropertyValue<string>("HashProperty"));
    });

    Assert.Equal(new GravatarImageUrlWidget().Email("prokhor.ozornin@yandex.ru").GetPropertyValue<string>("HashProperty"), new GravatarImageUrlWidget().Email(" PROKHOR.OZORNIN@yandex.ru ").GetPropertyValue<string>("HashProperty"));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.ForceDefault(IGravatarImageUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void ForceDefault_Method()
  {
    AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.ForceDefault(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new GravatarImageUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.ForceDefault(), widget));
      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
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
    AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Rating(null, "rating")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
    AssertionExtensions.Should(() => new GravatarImageUrlWidget().Rating(null)).ThrowExactly<ArgumentNullException>().WithParameterName("rating");
    AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Rating(null, GravatarImageRating.G)).ThrowExactly<ArgumentNullException>().WithParameterName("rating");
    AssertionExtensions.Should(() => new GravatarImageUrlWidget().Rating(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("rating");

    new GravatarImageUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Rating("rating"), widget));
      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
      Assert.Equal(1, parameters.Count);
      Assert.Equal("rating", parameters.Single().Key);
      Assert.Equal("rating", parameters.Single().Value);
    });

    new GravatarImageUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Rating(GravatarImageRating.G), widget));
      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
      Assert.Equal(1, parameters.Count);
      Assert.Equal("rating", parameters.Single().Key);
      Assert.Equal("g", parameters.Single().Value);
    });
    new GravatarImageUrlWidget().With(widget => Assert.Equal("pg", widget.Rating(GravatarImageRating.PG).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
    new GravatarImageUrlWidget().With(widget => Assert.Equal("r", widget.Rating(GravatarImageRating.R).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
    new GravatarImageUrlWidget().With(widget => Assert.Equal("x", widget.Rating(GravatarImageRating.X).GetFieldValue<IDictionary<string, object>>("parameters").Single().Value));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.Size(IGravatarImageUrlWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new GravatarImageUrlWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Size(1), widget));
      var parameters = widget.GetFieldValue<IDictionary<string, object>>("parameters");
      Assert.Equal(1, parameters.Count);
      Assert.Equal("size", parameters.Single().Key);
      Assert.Equal((short) 1, parameters.Single().Value);
    });
  }
}