using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="AddThisSmartLayersWidget"/>.</para>
/// </summary>
public sealed class AddThisSmartLayersWidgetTest : Test
{
  private IAddThisSmartLayersWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public AddThisSmartLayersWidgetTest() => Widget = Fixture.Create<IAddThisSmartLayersWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="AddThisSmartLayersWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(AddThisSmartLayersWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IAddThisSmartLayersWidget>();

    using (new AssertionScope())
    {
      var widget = new AddThisSmartLayersWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisSmartLayersWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new AddThisSmartLayersWidget());
      Validate(Fixture.Create<IAddThisSmartLayersWidget>());
    }

    return;

    static void Validate(IAddThisSmartLayersWidget original)
    {
      var clone = original.Clone<IAddThisSmartLayersWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisSmartLayersWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new AddThisSmartLayersWidget());
      Validate(Fixture.Create<IAddThisSmartLayersWidget>());
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