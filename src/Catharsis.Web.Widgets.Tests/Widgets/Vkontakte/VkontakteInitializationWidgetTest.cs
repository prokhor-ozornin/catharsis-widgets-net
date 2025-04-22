using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteInitializationWidget"/>.</para>
/// </summary>
public sealed class VkontakteInitializationWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteInitializationWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteInitializationWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteInitializationWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteInitializationWidget();
      widget.GetPropertyValue<string>("ApiIdProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.ApiId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ApiId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteInitializationWidget().ApiId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteInitializationWidget().ApiId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new VkontakteInitializationWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IVkontakteInitializationWidget widget) => widget.ApiId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ApiIdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteInitializationWidget());
      Validate(new VkontakteInitializationWidget().ApiId("id"), """<script type="text/javascript">""", "VK.init({{apiId:id, onlyWidgets:true}});");
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