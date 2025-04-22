using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookInitializationWidget"/>.</para>
/// </summary>
public sealed class FacebookInitializationWidgetTest : UnitTest
{
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
      widget.GetPropertyValue<string>("AppIdProperty").Should().BeNull();
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

      new FacebookInitializationWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IFacebookInitializationWidget widget) => widget.AppId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AppIdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookInitializationWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new FacebookInitializationWidget());
      Validate(new FacebookInitializationWidget().AppId("appId"), """<div id="fb-root"></div>""", "//connect.facebook.net/en_US/all.js#xfbml=1&appId=appId");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

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