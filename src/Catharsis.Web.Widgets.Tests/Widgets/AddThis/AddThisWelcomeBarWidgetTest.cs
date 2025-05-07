using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="AddThisWelcomeBarWidget"/>.</para>
/// </summary>
public sealed class AddThisWelcomeBarWidgetTest : Test
{
  private IAddThisWelcomeBarWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public AddThisWelcomeBarWidgetTest() => Widget = Fixture.Create<IAddThisWelcomeBarWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="AddThisWelcomeBarWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(AddThisWelcomeBarWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IAddThisWelcomeBarWidget>();

    using (new AssertionScope())
    {
      var widget = new AddThisWelcomeBarWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisWelcomeBarWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new AddThisWelcomeBarWidget());
      Validate(Fixture.Create<IAddThisWelcomeBarWidget>());
    }

    return;

    static void Validate(IAddThisWelcomeBarWidget original)
    {
      var clone = original.Clone<IAddThisWelcomeBarWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisWelcomeBarWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new AddThisWelcomeBarWidget());
      Validate(Fixture.Create<IAddThisWelcomeBarWidget>());
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