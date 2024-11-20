using Catharsis.Commons;
using FluentAssertions;
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

    var widget = new VkontakteInitializationWidget();
    Assert.Null(widget.ApiId());
    Assert.True(ReferenceEquals(widget.ApiId("apiId"), widget));
    Assert.Equal("apiId", widget.ApiId());
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