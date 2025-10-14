using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GoogleAnalyticsWidget"/>.</para>
/// </summary>
/// <seealso cref="GoogleAnalyticsWidget"/>
public sealed class GoogleAnalyticsWidgetTest : Test
{
  private IGoogleAnalyticsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public GoogleAnalyticsWidgetTest() => Widget = Fixture<IGoogleAnalyticsWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="GoogleAnalyticsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(GoogleAnalyticsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IGoogleAnalyticsWidget>();

    using (new AssertionScope())
    {
      var widget = new GoogleAnalyticsWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("DomainValue").Should().BeNull();
    }
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
      AssertionExtensions.Should(() => new GoogleAnalyticsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(account => Test(account, Widget));
    }

    return;

    static void Test(string account, IGoogleAnalyticsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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
      AssertionExtensions.Should(() => new GoogleAnalyticsWidget().Domain(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("domain");

      new[] { Fixture<string>.Create() }.ForEach(domain => Test(domain, Widget));
    }

    return;

    static void Test(string domain, IGoogleAnalyticsWidget widget) => widget.Domain(domain).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("DomainValue").Should().Be(domain);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="GoogleAnalyticsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new GoogleAnalyticsWidget());
      Test(Fixture<GoogleAnalyticsWidget>.Create());
    }

    return;

    static void Test(IGoogleAnalyticsWidget original)
    {
      var clone = original.Clone<IGoogleAnalyticsWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("DomainValue").Should().Be(original.GetPropertyValue<string>("DomainValue"));
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
      Test(new GoogleAnalyticsWidget());
      Test(new GoogleAnalyticsWidget().Account("account"));
      Test(new GoogleAnalyticsWidget().Domain("domain"));
      Test(new GoogleAnalyticsWidget().Account("account").Domain("domain"), "//www.google-analytics.com/analytics.js", """ga("create", "account", "domain");""");
      Test(Fixture<GoogleAnalyticsWidget>.Create());
    }

    return;

    static void Test(IGoogleAnalyticsWidget widget, params string[] html)
    {
      if (html.IsUnset())
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