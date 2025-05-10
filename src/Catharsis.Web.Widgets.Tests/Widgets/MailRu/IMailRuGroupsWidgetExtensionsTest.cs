using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IMailRuGroupsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IMailRuGroupsWidgetExtensionsTest : Test
{
  private IMailRuGroupsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IMailRuGroupsWidgetExtensionsTest() => Widget = Fixture.Create<IMailRuGroupsWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuGroupsWidgetExtensions.Height(IMailRuGroupsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuGroupsWidgetExtensions.Height(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture.Create<short>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short height, IMailRuGroupsWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuGroupsWidgetExtensions.Width(IMailRuGroupsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuGroupsWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture.Create<short>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, IMailRuGroupsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }
}