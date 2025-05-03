using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleCommentsWidget"/>.</para>
/// </summary>
public sealed class CackleCommentsWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleCommentsWidget>();

    using (new AssertionScope())
    {
      var widget = new CackleCommentsWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new CackleCommentsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new CackleCommentsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new CackleCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, ICackleCommentsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleCommentsWidget());
      Validate(Attributes.CackleCommentsWidget());
    }

    return;

    static void Validate(ICackleCommentsWidget original)
    {
      var clone = original.Clone<ICackleCommentsWidget>();

      clone.GetPropertyValue<string>("AccountProperty").Should().Be(original.GetPropertyValue<string>("AccountProperty"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleCommentsWidget());
      Validate(new CackleCommentsWidget().Account("account"), """<div id="mc-container"></div>""");
      Validate(new CackleCommentsWidget().Account("account"), """{"widget":"Comment","id":"account"}""");
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