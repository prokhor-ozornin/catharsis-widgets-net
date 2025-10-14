using System.Globalization;
using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterTweetButtonWidgetExtensions"/>.</para>
/// </summary>
/// <seealso cref="ITwitterTweetButtonWidgetExtensions"/>
public sealed class ITwitterTweetButtonWidgetExtensionsTest : Test
{
  private ITwitterTweetButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public ITwitterTweetButtonWidgetExtensionsTest() => Widget = Fixture<ITwitterTweetButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.Language(ITwitterTweetButtonWidget, CultureInfo)"/> method.</para>
  /// </summary>
  [Fact]
  public void Language_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.Language(null, CultureInfo.InvariantCulture)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.Language(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("culture");

      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(culture => Test(culture, Widget));
    }

    return;

    static void Test(CultureInfo culture, ITwitterTweetButtonWidget widget) => widget.Language(culture).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageValue").Should().Be(culture.TwoLetterISOLanguageName);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.Size(ITwitterTweetButtonWidget, TwitterTweetButtonSize)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.Size(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<TwitterTweetButtonSize>().ForEach(size => Test(size, Widget));
    }

    return;

    static void Test(TwitterTweetButtonSize size, ITwitterTweetButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.CounterPosition(ITwitterTweetButtonWidget, TwitterTweetButtonCountBoxPosition)"/> method.</para>
  /// </summary>
  [Fact]
  public void CounterPosition_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.CounterPosition(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<TwitterTweetButtonCountBoxPosition>().ForEach(position => Test(position, Widget));
    }

    return;

    static void Test(TwitterTweetButtonCountBoxPosition position, ITwitterTweetButtonWidget widget) => widget.CounterPosition(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CounterPositionValue").Should().Be(position.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.HashTags(ITwitterTweetButtonWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void HashTags_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.HashTags(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.HashTags(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("tags");

      new[] { Array.Empty<string>(), [Fixture<string>.Create()] }.ForEach(tags => Test(tags, Widget));
    }

    return;

    static void Test(string[] tags, ITwitterTweetButtonWidget widget) => ITwitterTweetButtonWidgetExtensions.HashTags(widget, tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("TagsValue").Should().Equal(tags);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.RelatedAccounts(ITwitterTweetButtonWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void RelatedAccounts_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("accounts");

      new[] { Array.Empty<string>(), [Fixture<string>.Create()] }.ForEach(tags => Test(tags, Widget));
    }

    return;

    static void Test(string[] tags, ITwitterTweetButtonWidget widget) => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(widget, tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("AccountsValue").Should().Equal(tags);
  }
}