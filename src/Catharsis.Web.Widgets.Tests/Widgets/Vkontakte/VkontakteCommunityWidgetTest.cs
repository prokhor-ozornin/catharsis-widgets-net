using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteCommunityWidget"/>.</para>
/// </summary>
public sealed class VkontakteCommunityWidgetTest : Test
{
  private IVkontakteCommunityWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public VkontakteCommunityWidgetTest() => Widget = Fixture.Create<IVkontakteCommunityWidget>();

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
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("BackgroundColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("ButtonColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("ElementIdValue").Should().BeNull();
      widget.GetPropertyValue<byte>("ModeValue").Should().Be((byte) VkontakteCommunityMode.Participants);
      widget.GetPropertyValue<string>("TextColorValue").Should().BeNull();
      widget.GetPropertyValue<string>("WidthValue").Should().BeNull();
      widget.GetPropertyValue<string>("HeightValue").Should().BeNull();
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IVkontakteCommunityWidget widget) => widget.BackgroundColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("BackgroundColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IVkontakteCommunityWidget widget) => widget.TextColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TextColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, IVkontakteCommunityWidget widget) => widget.ButtonColor(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ButtonColorValue").Should().Be(color);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string id, IVkontakteCommunityWidget widget) => widget.ElementId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ElementIdValue").Should().Be(id);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, IVkontakteCommunityWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Mode(byte)"/> method.</para>
  /// </summary>
  [Fact]
  public void Mode_Method()
  {
    using (new AssertionScope())
    {
      new[] { byte.MinValue, byte.MaxValue, Fixture.Create<byte>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(byte mode, IVkontakteCommunityWidget widget) => widget.Mode(mode).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("ModeValue").Should().Be(mode);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string width, IVkontakteCommunityWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width);
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

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string height, IVkontakteCommunityWidget widget) => widget.Height(height).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("HeightValue").Should().Be(height);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteCommunityWidget());
      Test(Fixture.Create<VkontakteCommunityWidget>());
    }

    return;

    static void Test(IVkontakteCommunityWidget original)
    {
      var clone = original.Clone<IVkontakteCommunityWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("BackgroundColorValue").Should().Be(original.GetPropertyValue<string>("BackgroundColorValue"));
      clone.GetPropertyValue<string>("ButtonColorValue").Should().Be(original.GetPropertyValue<string>("ButtonColorValue"));
      clone.GetPropertyValue<string>("ElementIdValue").Should().Be(original.GetPropertyValue<string>("ElementIdValue"));
      clone.GetPropertyValue<string>("HeightValue").Should().Be(original.GetPropertyValue<string>("HeightValue"));
      clone.GetPropertyValue<byte>("ModeValue").Should().Be(original.GetPropertyValue<byte>("ModeValue"));
      clone.GetPropertyValue<string>("TextColorValue").Should().Be(original.GetPropertyValue<string>("TextColorValue"));
      clone.GetPropertyValue<string>("WidthValue").Should().Be(original.GetPropertyValue<string>("WidthValue"));
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteCommunityWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new VkontakteCommunityWidget());
      Test(new VkontakteCommunityWidget(), """<div id="vk_groups_account"></div>""", """<script type="text/javascript">""", """VK.Widgets.Group("vk_groups_account", {"mode":0}, "account");""");
      Test(new VkontakteCommunityWidget().Account("account").Width("width").Height("height").Mode(VkontakteCommunityMode.News).ElementId("elementId").BackgroundColor("backgroundColor").TextColor("textColor").ButtonColor("buttonColor"), """<div id="elementId"></div>""", """<script type="text/javascript">""", """VK.Widgets.Group("elementId", {"mode":2,"wide":1,"width":"width","height":"height","color1":"backgroundColor","color2":"textColor","color3":"buttonColor"}, "account");""");
      Test(Fixture.Create<VkontakteCommunityWidget>());
    }

    return;

    static void Test(IVkontakteCommunityWidget widget, params string[] html)
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