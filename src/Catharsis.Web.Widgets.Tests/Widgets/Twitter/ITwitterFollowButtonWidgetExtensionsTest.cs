using System.Globalization;
using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterFollowButtonWidgetExtensions"/>.</para>
/// </summary>
/// <seealso cref="ITwitterFollowButtonWidgetExtensions"/>
public sealed class ITwitterFollowButtonWidgetExtensionsTest : Test
{
  private ITwitterFollowButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public ITwitterFollowButtonWidgetExtensionsTest() => Widget = Fixture<ITwitterFollowButtonWidget>.Create();

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

      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(culture => Test(culture, Widget));
    }

    return;

    static void Test(CultureInfo culture, ITwitterFollowButtonWidget widget) => widget.Language(culture).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(culture.TwoLetterISOLanguageName);
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

      Enum.GetValues<TwitterFollowButtonSize>().ForEach(size => Test(size, Widget));
    }

    return;

    static void Test(TwitterFollowButtonSize size, ITwitterFollowButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size.ToString().ToLowerInvariant());
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

      Enum.GetValues<TwitterFollowButtonAlignment>().ForEach(alignment => Test(alignment, Widget));
    }

    return;

    static void Test(TwitterFollowButtonAlignment alignment, ITwitterFollowButtonWidget widget) => widget.Alignment(alignment).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AlignmentValue").Should().Be(alignment.ToString().ToLowerInvariant());
  }
}