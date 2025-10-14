using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IMailRuLikeButtonWidgetExtensions"/>.</para>
/// </summary>
/// <seealso cref="IMailRuLikeButtonWidgetExtensions"/>
public sealed class IMailRuLikeButtonWidgetExtensionsTest : Test
{
  private IMailRuLikeButtonWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IMailRuLikeButtonWidgetExtensionsTest() => Widget = Fixture<IMailRuLikeButtonWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.Type(IMailRuLikeButtonWidget, MailRuLikeButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.Type(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Test(MailRuLikeButtonType.MailRu, "mm", Widget);
      Test(MailRuLikeButtonType.Odnoklassniki, "ok", Widget);
      Test(MailRuLikeButtonType.All, "combo", Widget);
    }

    return;

    static void Test(MailRuLikeButtonType type, string value, IMailRuLikeButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TypeValue").Should().Be(value);
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IMailRuLikeButtonWidgetExtensions.Size(IMailRuLikeButtonWidget, short)"/></description></item>
  ///     <item><description><see cref="IMailRuLikeButtonWidgetExtensions.Size(IMailRuLikeButtonWidget, MailRuLikeButtonSize)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Size_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.Size(null, short.MaxValue)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(size => Test(size, Widget));

      static void Test(short size, IMailRuLikeButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(size.ToInvariantString());
    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.Size(null, default(MailRuLikeButtonSize))).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<MailRuLikeButtonSize>().ForEach(size => Test(size, Widget));

      static void Test(MailRuLikeButtonSize size, IMailRuLikeButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeValue").Should().Be(((short) size).ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.Layout(IMailRuLikeButtonWidget, MailRuLikeButtonLayout)"/> method.</para>
  /// </summary>
  [Fact]
  public void Layout_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.Layout(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<MailRuLikeButtonLayout>().ForEach(layout => Test(layout, Widget));
    }

    return;

    static void Test(MailRuLikeButtonLayout layout, IMailRuLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LayoutValue").Should().Be((byte) layout);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.TextType(IMailRuLikeButtonWidget, MailRuLikeButtonTextType)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextType_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.TextType(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<MailRuLikeButtonTextType>().ForEach(type => Test(type, Widget));
    }

    return;

    static void Test(MailRuLikeButtonTextType type, IMailRuLikeButtonWidget widget) => widget.TextType(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextTypeValue").Should().Be((byte) type);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.CounterPosition(IMailRuLikeButtonWidget, MailRuLikeButtonCounterPosition)"/> method.</para>
  /// </summary>
  [Fact]
  public void CounterPosition_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.CounterPosition(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<MailRuLikeButtonCounterPosition>().ForEach(position => Test(position, Widget));
    }

    return;

    static void Test(MailRuLikeButtonCounterPosition position, IMailRuLikeButtonWidget widget) => widget.CounterPosition(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CounterPositionValue").Should().Be(position.ToString().ToLowerInvariant());
  }
}