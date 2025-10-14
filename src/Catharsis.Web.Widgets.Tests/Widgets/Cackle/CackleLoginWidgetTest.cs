using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="CackleLoginWidget"/>.</para>
/// </summary>
/// <seealso cref="CackleLoginWidget"/>
public sealed class CackleLoginWidgetTest : Test
{
  private ICackleLoginWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public CackleLoginWidgetTest() => Widget = Fixture<ICackleLoginWidget>.Create();

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

      new[] { Fixture<string>.Create() }.ForEach(account => Test(account, Widget));
    }

    return;

    static void Test(string account, ICackleLoginWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CackleLoginWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new CackleLatestCommentsWidget());
      Test(Fixture<CackleLatestCommentsWidget>.Create());
    }

    return;

    static void Test(ICackleLatestCommentsWidget original)
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
      Test(new CackleLoginWidget());
      Test(new CackleLoginWidget().Account("account"), """<div id="mc-login"></div>""", """{"widget":"Login","id":"account"}""");
      Test(Fixture<CackleLoginWidget>.Create());
    }

    return;

    static void Test(ICackleLoginWidget widget, params string[] html)
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