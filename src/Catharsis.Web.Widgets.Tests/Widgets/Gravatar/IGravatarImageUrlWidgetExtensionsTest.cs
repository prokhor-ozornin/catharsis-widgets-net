using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IGravatarImageUrlWidgetExtensions"/>.</para>
/// </summary>
public sealed class IGravatarImageUrlWidgetExtensionsTest : Test
{
  private IGravatarImageUrlWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IGravatarImageUrlWidgetExtensionsTest() => Widget = Fixture.Create<IGravatarImageUrlWidget>();

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Default(null, "url")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Default(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Default(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      Validate(GravatarDefaultImage.Blank, "blank", Widget);
      Validate(GravatarDefaultImage.IdentIcon, "identicon", Widget);
      Validate(GravatarDefaultImage.MonsterId, "monsterid", Widget);
      Validate(GravatarDefaultImage.MysteryMan, "mm", Widget);
      Validate(GravatarDefaultImage.NotFound, "404", Widget);
      Validate(GravatarDefaultImage.Retro, "retro", Widget);
      Validate(GravatarDefaultImage.Wavatar, "wavatar", Widget);
    }

    return;

    static void Validate(GravatarDefaultImage image, string value, IGravatarImageUrlWidget widget) => widget.Default(image).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersValue").ToValueTuple().Should().Equal(("default", value));
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

      Validate("prokhor.ozornin@yandex.ru", "61b98d241eaa1ce237c979e7a8181d13", Widget);
    }

    return;

    static void Validate(string email, string hash, IGravatarImageUrlWidget widget) => widget.Email(email).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HashValue").Should().Be(hash);
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

      Validate(Widget);
    }

    return;

    static void Validate(IGravatarImageUrlWidget widget) => widget.ForceDefault().Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersValue").ToValueTuple().Should().Equal(("forcedefault", "y"));
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Rating(null, "rating")).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Rating(null)).ThrowExactly<ArgumentNullException>().WithParameterName("rating");
      AssertionExtensions.Should(() => IGravatarImageUrlWidgetExtensions.Rating(null, GravatarImageRating.G)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => new GravatarImageUrlWidget().Rating(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("rating");

      Enum.GetValues<GravatarImageRating>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(GravatarImageRating rating, IGravatarImageUrlWidget widget) => widget.Rating(rating).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersValue").ToValueTuple().Should().Equal(("rating", rating.ToString().ToLowerInvariant()));
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

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short size, IGravatarImageUrlWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IDictionary<string, object>>("ParametersValue").ToValueTuple().Should().Equal(("size", size));
  }
}