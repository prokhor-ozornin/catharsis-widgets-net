using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IMailRuFacesWidgetExtensions"/>.</para>
/// </summary>
public sealed class IMailRuFacesWidgetExtensionsTest : Test
{
  private IMailRuFacesWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IMailRuFacesWidgetExtensionsTest() => Widget = Fixture<IMailRuFacesWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Font(IMailRuFacesWidget, MailRuFacesFont)"/> method.</para>
  /// </summary>
  [Fact]
  public void Font_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuFacesWidgetExtensions.Font(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      
      Test(MailRuFacesFont.Arial, "Arial", Widget);
      Test(MailRuFacesFont.Georgia, "Georgia", Widget);
      Test(MailRuFacesFont.Tahoma, "Tahoma", Widget);
    }

    return;

    static void Test(MailRuFacesFont font, string value, IMailRuFacesWidget widget) => widget.Font(font).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FontValue").Should().Be(value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Height(IMailRuFacesWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuFacesWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short height, IMailRuFacesWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Width(IMailRuFacesWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuFacesWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, IMailRuFacesWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }
}