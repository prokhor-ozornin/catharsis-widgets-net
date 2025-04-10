using System.Globalization;
using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITwitterTweetButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class ITwitterTweetButtonWidgetExtensionsTest : UnitTest
{
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

      var widget = new TwitterTweetButtonWidget();
      CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(CultureInfo culture, ITwitterTweetButtonWidget widget) => widget.Language(culture).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LanguageProperty").Should().Be(culture.TwoLetterISOLanguageName);
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

      var widget = new TwitterTweetButtonWidget();
      Enum.GetValues<TwitterTweetButtonSize>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(TwitterTweetButtonSize size, ITwitterTweetButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size.ToString().ToLowerInvariant());
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

      var widget = new TwitterTweetButtonWidget();
      Enum.GetValues<TwitterTweetButtonCountBoxPosition>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(TwitterTweetButtonCountBoxPosition position, ITwitterTweetButtonWidget widget) => widget.CounterPosition(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CounterProperty").Should().Be(position.ToString().ToLowerInvariant());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.HashTags(ITwitterTweetButtonWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void HashTags_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.HashTags(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.HashTags(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("tags");

      var widget = new TwitterTweetButtonWidget();
      new[] { Array.Empty<string>(), ["tag"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string[] tags, ITwitterTweetButtonWidget widget) => ITwitterTweetButtonWidgetExtensions.HashTags(widget, tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("TagsProperty").Should().Equal(tags);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITwitterTweetButtonWidgetExtensions.RelatedAccounts(ITwitterTweetButtonWidget, string[])"/> method.</para>
  /// </summary>
  [Fact]
  public void RelatedAccounts_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(null, [])).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(new TwitterTweetButtonWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("accounts");

      var widget = new TwitterTweetButtonWidget();
      new[] { Array.Empty<string>(), ["tag"] }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string[] tags, ITwitterTweetButtonWidget widget) => ITwitterTweetButtonWidgetExtensions.RelatedAccounts(widget, tags).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("AccountsProperty").Should().Equal(tags);
  }
}