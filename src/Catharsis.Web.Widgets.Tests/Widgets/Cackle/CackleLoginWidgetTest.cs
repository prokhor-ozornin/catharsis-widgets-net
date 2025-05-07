using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleLoginWidget"/>.</para>
/// </summary>
public sealed class CackleLoginWidgetTest : Test
{
  private ICackleLoginWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public CackleLoginWidgetTest() => Widget = Fixture.Create<ICackleLoginWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="CackleLoginWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(CackleLoginWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ICackleLoginWidget>();

    using (new AssertionScope())
    {
      var widget = new CackleLoginWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new CackleLoginWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new CackleLoginWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string account, ICackleLoginWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleLatestCommentsWidget());
      Validate(Fixture.Create<ICackleLatestCommentsWidget>());
    }

    return;

    static void Validate(ICackleLatestCommentsWidget original)
    {
      var clone = original.Clone<ICackleLatestCommentsWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<short>("AvatarSizeValue").Should().Be(original.GetPropertyValue<short>("AvatarSizeValue"));
      clone.GetPropertyValue<byte>("MaxValue").Should().Be(original.GetPropertyValue<byte>("MaxValue"));
      clone.GetPropertyValue<int>("TextSizeValue").Should().Be(original.GetPropertyValue<int>("TextSizeValue"));
      clone.GetPropertyValue<int>("TitleSizeValue").Should().Be(original.GetPropertyValue<int>("TitleSizeValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new CackleLoginWidget());
      Validate(new CackleLoginWidget().Account("account"), """<div id="mc-login"></div>""", """{"widget":"Login","id":"account"}""");
      Validate(Fixture.Create<ICackleLoginWidget>());
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