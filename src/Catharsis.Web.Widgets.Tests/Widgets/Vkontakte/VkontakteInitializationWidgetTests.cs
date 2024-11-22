using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteInitializationWidget"/>.</para>
/// </summary>
public sealed class VkontakteInitializationWidgetTests : ClassTest<VkontakteInitializationWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteInitializationWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteInitializationWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteInitializationWidget>();
    
    var widget = new VkontakteInitializationWidget();
    widget.ApiId().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.ApiId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ApiId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteInitializationWidget().ApiId(null));
    Assert.Throws<ArgumentException>(() => new VkontakteInitializationWidget().ApiId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteInitializationWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteInitializationWidget widget)
    {
      widget.ApiId(id).Should().BeSameAs(widget);
      widget.ApiId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new VkontakteInitializationWidget().ToString());

    var html = new VkontakteInitializationWidget().ApiId("id").ToString();
    Assert.True(html.Contains("""<script type="text/javascript">"""));
    Assert.True(html.Contains("VK.init({{apiId:id, onlyWidgets:true}});"));
  }
}