using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleAnalyticsWidget"/>.</para>
/// </summary>
public sealed class GoogleAnalyticsWidgetTests : UnitTest
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GoogleAnalyticsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new GoogleAnalyticsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new GoogleAnalyticsWidget().Domain(null)).ThrowExactly<ArgumentNullException>().WithParameterName("domain");
      AssertionExtensions.Should(() => new GoogleAnalyticsWidget().Domain(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("domain");

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
    using (new AssertionScope())
    {
      Validate(new GoogleAnalyticsWidget());
      Validate(new GoogleAnalyticsWidget().Account("account"));
      Validate(new GoogleAnalyticsWidget().Domain("domain"));
      Validate(new GoogleAnalyticsWidget().Account("account").Domain("domain"), "//www.google-analytics.com/analytics.js", """ga("create", "account", "domain");""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}