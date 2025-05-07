using AutoFixture;
using Catharsis.Extensions;
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
  public IMailRuFacesWidgetExtensionsTest() => Widget = Fixture.Create<IMailRuFacesWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Font(IMailRuFacesWidget, MailRuFacesFont)"/> method.</para>
  /// </summary>
  [Fact]
  public void Font_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuFacesWidgetExtensions.Font(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      
      Validate(MailRuFacesFont.Arial, "Arial", Widget);
      Validate(MailRuFacesFont.Georgia, "Georgia", Widget);
      Validate(MailRuFacesFont.Tahoma, "Tahoma", Widget);
    }

    return;

    static void Validate(MailRuFacesFont font, string value, IMailRuFacesWidget widget) => widget.Font(font).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("FontValue").Should().Be(value);
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

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short height, IMailRuFacesWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
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

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short width, IMailRuFacesWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }
}