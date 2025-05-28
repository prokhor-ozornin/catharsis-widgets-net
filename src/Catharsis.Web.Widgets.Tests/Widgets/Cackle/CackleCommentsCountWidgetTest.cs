using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleCommentsCountWidget"/>.</para>
/// </summary>
public sealed class CackleCommentsCountWidgetTest : Test
{
  private ICackleCommentsCountWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public CackleCommentsCountWidgetTest() => Widget = Fixture<ICackleCommentsCountWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleCommentsCountWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleCommentsCountWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleCommentsCountWidget>();

    using (new AssertionScope())
    {
      var widget = new CackleCommentsCountWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new CackleCommentsCountWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new CackleCommentsCountWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, ICackleCommentsCountWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new CackleCommentsCountWidget());
      Test(Fixture<CackleCommentsCountWidget>.Create());
    }

    return;

    static void Test(ICackleCommentsCountWidget original)
    {
      var clone = original.Clone<ICackleCommentsCountWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new CackleCommentsCountWidget());
      Test(new CackleCommentsCountWidget().Account("account"), """{"widget":"CommentCount","id":"account"}""");
      Test(Fixture<CackleCommentsCountWidget>.Create());
    }

    return;

    static void Test(ICackleCommentsCountWidget widget, params string[] html)
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