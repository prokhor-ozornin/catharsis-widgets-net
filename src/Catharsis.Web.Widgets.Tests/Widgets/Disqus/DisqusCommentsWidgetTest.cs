using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DisqusCommentsWidget"/>.</para>
/// </summary>
public sealed class DisqusCommentsWidgetTest : Test
{
  private IDisqusCommentsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public DisqusCommentsWidgetTest() => Widget = Fixture<IDisqusCommentsWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="DisqusCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(DisqusCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IDisqusCommentsWidget>();

    using (new AssertionScope())
    {
      var widget = new DisqusCommentsWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new DisqusCommentsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new DisqusCommentsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, IDisqusCommentsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusCommentsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new DisqusCommentsWidget());
      Test(Fixture<DisqusCommentsWidget>.Create());
    }

    return;

    static void Test(IDisqusCommentsWidget original)
    {
      var clone = original.Clone<IDisqusCommentsWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DisqusCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new DisqusCommentsWidget());
      Test(new DisqusCommentsWidget().Account("account"), """<div id="disqus_thread"></div>""", """
                                                                                                    var disqus_shortname = "account"
                                                                                                    """);
      Test(Fixture<DisqusCommentsWidget>.Create());
    }

    return;

    static void Test(IDisqusCommentsWidget widget, params string[] html)
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