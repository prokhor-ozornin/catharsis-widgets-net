using Xunit;
using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexMoneyDonateFormWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexMoneyDonateFormWidgetExtensionsTest : Test
{
  private IYandexMoneyDonateFormWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IYandexMoneyDonateFormWidgetExtensionsTest() => Widget = Fixture<IYandexMoneyDonateFormWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyDonateFormWidgetExtensions.ProjectSite(IYandexMoneyDonateFormWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void ProjectSite_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyDonateFormWidgetExtensions.ProjectSite(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IYandexMoneyDonateFormWidgetExtensions.ProjectSite(new YandexMoneyDonateFormWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      new[] { Fixture<Uri>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(Uri url, IYandexMoneyDonateFormWidget widget) => widget.ProjectSite(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ProjectSiteValue").Should().Be(url.ToString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyDonateFormWidgetExtensions.Sum(IYandexMoneyDonateFormWidget, double)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyDonateFormWidgetExtensions.Sum(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { double.NegativeZero, Fixture<double>.Create() }.ForEach(sum => Test(sum, Widget));
    }

    return;

    static void Test(double sum, IYandexMoneyDonateFormWidget widget) => widget.Sum(sum).Should().BeSameAs(widget).And.Subject.GetPropertyValue<decimal>("SumValue").Should().Be((decimal) sum);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyDonateFormWidgetExtensions.Text(IYandexMoneyDonateFormWidget, YandexMoneyDonateFormText)"/></para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyDonateFormWidgetExtensions.Text(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<YandexMoneyDonateFormText>().ForEach(text => Test(text, Widget));
    }

    return;

    static void Test(YandexMoneyDonateFormText text, IYandexMoneyDonateFormWidget widget) => widget.Text(text).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextValue").Should().Be((byte) text);
  }
}