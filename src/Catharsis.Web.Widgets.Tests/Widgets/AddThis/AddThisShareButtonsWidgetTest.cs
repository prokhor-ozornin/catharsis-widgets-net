using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="AddThisShareButtonsWidget"/>.</para>
/// </summary>
public sealed class AddThisShareButtonsWidgetTest : Test
{
  private IAddThisShareButtonsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public AddThisShareButtonsWidgetTest() => Widget = Fixture.Create<IAddThisShareButtonsWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="AddThisShareButtonsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(AddThisShareButtonsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IAddThisShareButtonsWidget>();

    using (new AssertionScope())
    {
      var widget = new AddThisShareButtonsWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisShareButtonsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new AddThisShareButtonsWidget());
      Validate(Fixture.Create<IAddThisShareButtonsWidget>());
    }

    return;

    static void Validate(IAddThisShareButtonsWidget original)
    {
      var clone = original.Clone<IAddThisShareButtonsWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisShareButtonsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new AddThisShareButtonsWidget());
      Validate(Fixture.Create<IAddThisShareButtonsWidget>());
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
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