using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FacebookInitializationWidget"/>.</para>
/// </summary>
public sealed class FacebookInitializationWidgetTests : ClassTest<FacebookInitializationWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="FacebookInitializationWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(FacebookInitializationWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IFacebookInitializationWidget>();

    var widget = new FacebookInitializationWidget();
    widget.AppId().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookInitializationWidget.AppId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AppId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new FacebookInitializationWidget().AppId(null));
    Assert.Throws<ArgumentException>(() => new FacebookInitializationWidget().AppId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new FacebookInitializationWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IFacebookInitializationWidget widget)
    {
      widget.AppId(id).Should().BeSameAs(widget);
      widget.AppId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FacebookInitializationWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new FacebookInitializationWidget().ToString());

    var html = new FacebookInitializationWidget().AppId("appId").ToString();
    Assert.True(html.Contains("""<div id="fb-root"></div>"""));
    Assert.True(html.Contains("//connect.facebook.net/en_US/all.js#xfbml=1&appId=appId"));
  }
}