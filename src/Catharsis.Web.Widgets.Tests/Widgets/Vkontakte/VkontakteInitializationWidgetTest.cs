using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteInitializationWidget"/>.</para>
/// </summary>
public sealed class VkontakteInitializationWidgetTest : Test
{
  private IVkontakteInitializationWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteInitializationWidgetTest() => Widget = Fixture<IVkontakteInitializationWidget>.Create();

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
      widget.GetPropertyValue<string>("ApiIdValue").Should().BeNull();
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

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IVkontakteInitializationWidget widget) => widget.ApiId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ApiIdValue").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteInitializationWidget());
      Test(Fixture<VkontakteInitializationWidget>.Create());
    }

    return;

    static void Test(IVkontakteInitializationWidget original)
    {
      var clone = original.Clone<IVkontakteInitializationWidget>();

      clone.GetPropertyValue<string>("ApiIdValue").Should().Be(original.GetPropertyValue<string>("ApiIdValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteInitializationWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteInitializationWidget());
      Test(new VkontakteInitializationWidget().ApiId("id"), """<script type="text/javascript">""", "VK.init({{apiId:id, onlyWidgets:true}});");
      Test(Fixture<VkontakteInitializationWidget>.Create());
    }

    return;

    static void Test(IVkontakteInitializationWidget widget, params string[] html)
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