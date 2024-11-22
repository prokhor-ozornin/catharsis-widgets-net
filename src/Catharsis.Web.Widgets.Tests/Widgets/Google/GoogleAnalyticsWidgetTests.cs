using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleAnalyticsWidget"/>.</para>
/// </summary>
public sealed class GoogleAnalyticsWidgetTests : ClassTest<GoogleAnalyticsWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GoogleAnalyticsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GoogleAnalyticsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGoogleAnalyticsWidget>();

    var widget = new GoogleAnalyticsWidget();
    widget.Account().Should().BeNull();
    widget.Domain().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleAnalyticsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new GoogleAnalyticsWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new GoogleAnalyticsWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new GoogleAnalyticsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IGoogleAnalyticsWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleAnalyticsWidget.Domain(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Domain_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new GoogleAnalyticsWidget().Domain(null));
    Assert.Throws<ArgumentException>(() => new GoogleAnalyticsWidget().Domain(string.Empty));

    using (new AssertionScope())
    {
      var widget = new GoogleAnalyticsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string domain, IGoogleAnalyticsWidget widget)
    {
      widget.Domain(domain).Should().BeSameAs(widget);
      widget.Domain().Should().Be(domain);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleAnalyticsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new GoogleAnalyticsWidget().ToString());
    Assert.Equal(string.Empty, new GoogleAnalyticsWidget().Account("account").ToString());
    Assert.Equal(string.Empty, new GoogleAnalyticsWidget().Domain("domain").ToString());

    var html = new GoogleAnalyticsWidget().Account("account").Domain("domain").ToString();
    Assert.True(html.Contains("//www.google-analytics.com/analytics.js"));
    Assert.True(html.Contains("""ga("create", "account", "domain");"""));
  }
}