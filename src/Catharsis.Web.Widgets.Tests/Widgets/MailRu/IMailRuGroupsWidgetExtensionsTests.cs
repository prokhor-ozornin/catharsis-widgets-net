using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IMailRuGroupsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IMailRuGroupsWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuGroupsWidgetExtensions.Height(IMailRuGroupsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuGroupsWidgetExtensions.Height(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new MailRuGroupsWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short height, IMailRuGroupsWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuGroupsWidgetExtensions.Width(IMailRuGroupsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuGroupsWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new MailRuGroupsWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IMailRuGroupsWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width.ToInvariantString());
    }
  }
}