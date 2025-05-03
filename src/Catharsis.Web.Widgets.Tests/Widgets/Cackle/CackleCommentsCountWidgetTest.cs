using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleCommentsCountWidget"/>.</para>
/// </summary>
public sealed class CackleCommentsCountWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
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

      new CackleCommentsCountWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, ICackleCommentsCountWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleCommentsCountWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleCommentsCountWidget());
      Validate(Attributes.CackleCommentsCountWidget());
    }

    return;

    static void Validate(ICackleCommentsCountWidget original)
    {
      var clone = original.Clone<ICackleCommentsCountWidget>();

      clone.GetPropertyValue<string>("AccountProperty").Should().Be(original.GetPropertyValue<string>("AccountProperty"));
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
      Validate(new CackleCommentsCountWidget());
      Validate(new CackleCommentsCountWidget().Account("account"), """{"widget":"CommentCount","id":"account"}""");
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