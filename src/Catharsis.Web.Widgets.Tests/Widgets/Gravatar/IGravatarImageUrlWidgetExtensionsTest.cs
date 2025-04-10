using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
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

    var widget = new GravatarImageUrlWidget();
    widget.Default("url").Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "url"));
    widget.Default(GravatarDefaultImage.Blank).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "blank"));
    widget.Default(GravatarDefaultImage.IdentIcon).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "identicon"));
    widget.Default(GravatarDefaultImage.MonsterId).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "monsterid"));
    widget.Default(GravatarDefaultImage.MysteryMan).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "mm"));
    widget.Default(GravatarDefaultImage.NotFound).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "404"));
    widget.Default(GravatarDefaultImage.Retro).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "retro"));
    widget.Default(GravatarDefaultImage.Wavatar).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("default", "wavatar"));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.Email(IGravatarImageUrlWidget, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Email_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Email(null, "email")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Email(null)).ThrowExactly<ArgumentNullException>().WithParameterName("email");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Email(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("email");

      var widget = new GravatarImageUrlWidget();
      Validate("prokhor.ozornin@yandex.ru", "61b98d241eaa1ce237c979e7a8181d13", widget);
    }

    return;

    static void Validate(string email, string hash, IGravatarImageUrlWidget widget) => widget.Email(email).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashProperty").Should().Be(hash);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IGravatarImageUrlWidgetExtensions.ForceDefault(IGravatarImageUrlWidget)"/> method.</para>
  /// </summary>
  [Fact]
  public void ForceDefault_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.ForceDefault(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new GravatarImageUrlWidget();
      Validate(widget);
    }

    return;

    static void Validate(IGravatarImageUrlWidget widget) => widget.ForceDefault().Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("forcedefault", "y"));
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Size(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new GravatarImageUrlWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short size, IGravatarImageUrlWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersProperty").ToValueTuple().Should().Equal(("size", 1));
  }
}