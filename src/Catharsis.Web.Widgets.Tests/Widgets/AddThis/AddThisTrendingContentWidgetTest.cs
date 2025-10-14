using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="AddThisTrendingContentWidget"/>.</para>
/// </summary>
/// <seealso cref="AddThisTrendingContentWidget"/>
public sealed class AddThisTrendingContentWidgetTest : Test
{
  private IAddThisTrendingContentWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public AddThisTrendingContentWidgetTest() => Widget = Fixture<IAddThisTrendingContentWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="AddThisTrendingContentWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(AddThisTrendingContentWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IAddThisTrendingContentWidget>();

    using (new AssertionScope())
    {
      var widget = new AddThisTrendingContentWidget();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisTrendingContentWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new AddThisTrendingContentWidget());
      Test(Fixture<AddThisTrendingContentWidget>.Create());
    }

    return;

    static void Test(IAddThisTrendingContentWidget original)
    {
      var clone = original.Clone<IAddThisTrendingContentWidget>();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AddThisTrendingContentWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new AddThisTrendingContentWidget());
      Test(Fixture<AddThisTrendingContentWidget>.Create());
    }

    return;

    static void Test(IAddThisTrendingContentWidget widget, params string[] html)
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