using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="AddThisFollowButtonsWidget"/>.</para>
/// </summary>
public sealed class AddThisFollowButtonsWidgetTest : Test
{
  private IAddThisFollowButtonsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public AddThisFollowButtonsWidgetTest() => Widget = Fixture<IAddThisFollowButtonsWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="AddThisFollowButtonsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(AddThisFollowButtonsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IAddThisFollowButtonsWidget>();

    using (new AssertionScope())
    {
      var widget = new AddThisFollowButtonsWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisFollowButtonsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new AddThisFollowButtonsWidget());
      Test(Fixture<AddThisFollowButtonsWidget>.Create());
    }

    return;

    static void Test(IAddThisFollowButtonsWidget original)
    {
      var clone = original.Clone<IAddThisFollowButtonsWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisFollowButtonsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new AddThisFollowButtonsWidget());
      Test(Fixture<AddThisFollowButtonsWidget>.Create());
    }

    return;

    static void Test(IAddThisFollowButtonsWidget widget, params string[] html)
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