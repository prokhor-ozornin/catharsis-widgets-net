using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteCommunityWidget"/>.</para>
/// </summary>
public sealed class VkontakteCommunityWidgetTests : ClassTest<VkontakteCommunityWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteCommunityWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteCommunityWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteCommunityWidget>();

    var widget = new VkontakteCommunityWidget();
    widget.Account().Should().BeNull();
    widget.BackgroundColor().Should().BeNull();
    widget.ButtonColor().Should().BeNull();
    widget.ElementId().Should().BeNull();
    widget.Mode().Should().Be((byte) VkontakteCommunityMode.Participants);
    widget.TextColor().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.BackgroundColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BackgroundColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().BackgroundColor(null));
    Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().BackgroundColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IVkontakteCommunityWidget widget)
    {
      widget.BackgroundColor(color).Should().BeSameAs(widget);
      widget.BackgroundColor().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.TextColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().TextColor(null));
    Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().TextColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IVkontakteCommunityWidget widget)
    {
      widget.TextColor(color).Should().BeSameAs(widget);
      widget.TextColor().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ButtonColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ButtonColor_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().ButtonColor(null));
    Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().ButtonColor(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string color, IVkontakteCommunityWidget widget)
    {
      widget.ButtonColor(color).Should().BeSameAs(widget);
      widget.ButtonColor().Should().Be(color);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().ElementId(null));
    Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().ElementId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteCommunityWidget widget)
    {
      widget.ElementId(id).Should().BeSameAs(widget);
      widget.ElementId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IVkontakteCommunityWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Mode(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mode_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(byte mode, IVkontakteCommunityWidget widget)
    {
      widget.Mode(mode).Should().BeSameAs(widget);
      widget.Mode().Should().Be(mode);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontakteCommunityWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteCommunityWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new VkontakteCommunityWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IVkontakteCommunityWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new VkontakteCommunityWidget().ToString());

    var html = new VkontakteCommunityWidget().Account("account").ToString();
    Assert.True(html.Contains("""<div id="vk_groups_account"></div>"""));
    Assert.True(html.Contains("""<script type="text/javascript">"""));
    Assert.True(html.Contains("""VK.Widgets.Group("vk_groups_account", {"mode":0}, "account");"""));

    html = new VkontakteCommunityWidget().Account("account").Width("width").Height("height").Mode(VkontakteCommunityMode.News).ElementId("elementId").BackgroundColor("backgroundColor").TextColor("textColor").ButtonColor("buttonColor").ToString();
    Assert.True(html.Contains("""<div id="elementId"></div>"""));
    Assert.True(html.Contains("""<script type="text/javascript">"""));
    Assert.True(html.Contains("""VK.Widgets.Group("elementId", {"mode":2,"wide":1,"width":"width","height":"height","color1":"backgroundColor","color2":"textColor","color3":"buttonColor"}, "account");"""));
  }
}