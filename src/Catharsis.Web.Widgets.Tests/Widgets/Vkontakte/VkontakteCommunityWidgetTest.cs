using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteCommunityWidget"/>.</para>
/// </summary>
public sealed class VkontakteCommunityWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteCommunityWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteCommunityWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteCommunityWidget>();

    using (new AssertionScope())
    {
      var widget = new VkontakteCommunityWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<string>("BackgroundColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ButtonColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("ElementIdProperty").Should().BeNull();
      widget.GetPropertyValue<byte>("ModeProperty").Should().Be((byte) VkontakteCommunityMode.Participants);
      widget.GetPropertyValue<string>("TextColorProperty").Should().BeNull();
      widget.GetPropertyValue<string>("WidthProperty").Should().BeNull();
      widget.GetPropertyValue<string>("HeightProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.BackgroundColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BackgroundColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().BackgroundColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().BackgroundColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new VkontakteCommunityWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IVkontakteCommunityWidget widget) => widget.BackgroundColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BackgroundColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.TextColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().TextColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().TextColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new VkontakteCommunityWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IVkontakteCommunityWidget widget) => widget.TextColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ButtonColor(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ButtonColor_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().ButtonColor(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().ButtonColor(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new VkontakteCommunityWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string color, IVkontakteCommunityWidget widget) => widget.ButtonColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ButtonColorProperty").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ElementId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ElementId_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().ElementId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().ElementId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new VkontakteCommunityWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IVkontakteCommunityWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdProperty").Should().Be(id);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new VkontakteCommunityWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, IVkontakteCommunityWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Mode(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mode_Method()
  {
    using (new AssertionScope())
    {
      new VkontakteCommunityWidget().With(widget => new[] { byte.MinValue, byte.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(byte mode, IVkontakteCommunityWidget widget) => widget.Mode(mode).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("ModeProperty").Should().Be(mode);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().Width(null)).ThrowExactly<ArgumentNullException>().WithParameterName("width");
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().Width(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("width");

      new VkontakteCommunityWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string width, IVkontakteCommunityWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().Height(null)).ThrowExactly<ArgumentNullException>().WithParameterName("height");
      AssertionExtensions.Should(() => new VkontakteCommunityWidget().Height(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("height");

      new VkontakteCommunityWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string height, IVkontakteCommunityWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightProperty").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteCommunityWidget());
      Validate(new VkontakteCommunityWidget(), """<div id="vk_groups_account"></div>""", """<script type="text/javascript">""", """VK.Widgets.Group("vk_groups_account", {"mode":0}, "account");""");
      Validate(new VkontakteCommunityWidget().Account("account").Width("width").Height("height").Mode(VkontakteCommunityMode.News).ElementId("elementId").BackgroundColor("backgroundColor").TextColor("textColor").ButtonColor("buttonColor"), """<div id="elementId"></div>""", """<script type="text/javascript">""", """VK.Widgets.Group("elementId", {"mode":2,"wide":1,"width":"width","height":"height","color1":"backgroundColor","color2":"textColor","color3":"buttonColor"}, "account");""");
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