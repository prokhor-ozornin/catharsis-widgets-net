using Catharsis.Commons;
using Xunit;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IYandexMoneyDonateFormWidgetExtensions"/>.</para>
/// </summary>
public sealed class IYandexMoneyDonateFormWidgetExtensionsTest : UnitTest
{
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

      var widget = new YandexMoneyDonateFormWidget();
      new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(Uri url, IYandexMoneyDonateFormWidget widget)
    {
      widget.ProjectSite(url).Should().BeSameAs(widget);
      widget.GetPropertyValue<string>("ProjectSiteProperty").Should().Be(url.ToString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IYandexMoneyDonateFormWidgetExtensions.Sum(IYandexMoneyDonateFormWidget, double)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sum_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IYandexMoneyDonateFormWidgetExtensions.Sum(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new YandexMoneyDonateFormWidget();
      new[] { double.MinValue, double.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(double sum, IYandexMoneyDonateFormWidget widget)
    {
      widget.Sum(sum).Should().BeSameAs(widget);
      widget.GetPropertyValue<decimal>("SumProperty").Should().Be((decimal) sum);
    }
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

      var widget = new YandexMoneyDonateFormWidget();
      Enum.GetValues<YandexMoneyDonateFormText>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(YandexMoneyDonateFormText text, IYandexMoneyDonateFormWidget widget)
    {
      widget.Text(text).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("TextProperty").Should().Be((byte) text);
    }
  }
}