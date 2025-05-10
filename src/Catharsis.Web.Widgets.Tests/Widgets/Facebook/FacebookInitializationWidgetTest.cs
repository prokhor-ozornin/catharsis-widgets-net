using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookInitializationWidget"/>.</para>
/// </summary>
public sealed class FacebookInitializationWidgetTest : Test
{
  private IFacebookInitializationWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public FacebookInitializationWidgetTest() => Widget = Fixture.Create<IFacebookInitializationWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookInitializationWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookInitializationWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookInitializationWidget>();

    using (new AssertionScope())
    {
      var widget = new FacebookInitializationWidget();
      widget.GetPropertyValue<string>("AppIdValue").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookInitializationWidget.AppId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AppId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new FacebookInitializationWidget().AppId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new FacebookInitializationWidget().AppId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IFacebookInitializationWidget widget) => widget.AppId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AppIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookInitializationWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookInitializationWidget());
      Test(Fixture.Create<FacebookInitializationWidget>());
    }

    return;

    static void Test(IFacebookInitializationWidget original)
    {
      var clone = original.Clone<IFacebookInitializationWidget>();

      clone.GetPropertyValue<string>("AppIdValue").Should().Be(original.GetPropertyValue<string>("AppIdValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookInitializationWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new FacebookInitializationWidget());
      Test(new FacebookInitializationWidget().AppId("appId"), """<div id="fb-root"></div>""", "//connect.facebook.net/en_US/all.js#xfbml=1&appId=appId");
      Test(Fixture.Create<FacebookInitializationWidget>());
    }

    return;

    static void Test(IFacebookInitializationWidget widget, params string[] html)
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