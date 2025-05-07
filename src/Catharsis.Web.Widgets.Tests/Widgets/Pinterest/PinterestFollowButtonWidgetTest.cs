using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PinterestFollowButtonWidget"/>.</para>
/// </summary>
public sealed class PinterestFollowButtonWidgetTest : Test
{
  private IPinterestFollowButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public PinterestFollowButtonWidgetTest() => Widget = Fixture.Create<IPinterestFollowButtonWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="PinterestFollowButtonWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(PinterestFollowButtonWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IPinterestFollowButtonWidget>();

    using (new AssertionScope())
    {
      var widget = new PinterestFollowButtonWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("LabelValue").Should().Be("Follow");
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string account, IPinterestFollowButtonWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Label(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Label_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Label(null)).ThrowExactly<ArgumentNullException>().WithParameterName("label");
      AssertionExtensions.Should(() => new PinterestFollowButtonWidget().Label(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("label");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string label, IPinterestFollowButtonWidget widget) => widget.Label(label).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("LabelValue").Should().Be(label);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestFollowButtonWidget());
      Validate(Fixture.Create<IPinterestFollowButtonWidget>());
    }

    return;

    static void Validate(IPinterestFollowButtonWidget original)
    {
      var clone = original.Clone<IPinterestFollowButtonWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("LabelValue").Should().Be(original.GetPropertyValue<string>("LabelValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="PinterestFollowButtonWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new PinterestFollowButtonWidget());
      Validate(new PinterestFollowButtonWidget().Account("account"), """<a data-pin-do="buttonFollow" href="http://www.pinterest.com/account">Follow</a>""");
      Validate(new PinterestFollowButtonWidget().Account("account").Label("label"), """<a data-pin-do="buttonFollow" href="http://www.pinterest.com/account">label</a>""");
      Validate(Fixture.Create<IPinterestFollowButtonWidget>());
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