using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterFollowButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ITwitterFollowButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterFollowButtonWidgetExtensions.Language(ITwitterFollowButtonWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Language(new TwitterFollowButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

      var widget = new TwitterFollowButtonWidget();
      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(CultureInfo culture, ITwitterFollowButtonWidget widget) => widget.Language(culture).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageProperty").Should().Be(culture.TwoLetterISOLanguageName);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterFollowButtonWidgetExtensions.Size(ITwitterFollowButtonWidget, TwitterFollowButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new TwitterFollowButtonWidget();
      Enum.GetValues<TwitterFollowButtonSize>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(TwitterFollowButtonSize size, ITwitterFollowButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterFollowButtonWidgetExtensions.Alignment(ITwitterFollowButtonWidget, TwitterFollowButtonAlignment)"/> method.</para>
  /// </summary>
  [Fact]
  public void Alignment_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterFollowButtonWidgetExtensions.Alignment(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new TwitterFollowButtonWidget();
      Enum.GetValues<TwitterFollowButtonAlignment>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(TwitterFollowButtonAlignment alignment, ITwitterFollowButtonWidget widget) => widget.Alignment(alignment).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AlignmentProperty").Should().Be(alignment.ToString().ToLowerInvariant());
  }
}