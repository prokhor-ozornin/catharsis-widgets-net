using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IMailRuLikeButtonWidgetExtensions"/>.</para>
/// </summary>
public sealed class IMailRuLikeButtonWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IMailRuLikeButtonWidgetExtensions.Type(IMailRuLikeButtonWidget, MailRuLikeButtonType)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.Type(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new MailRuLikeButtonWidget();
      Enum.GetValues<MailRuLikeButtonType>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(MailRuLikeButtonType type, IMailRuLikeButtonWidget widget) => widget.Type(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("TypeProperty").Should().Be(type.ToString().ToInvariantString());
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

      var widget = new MailRuLikeButtonWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));

      static void Validate(short size, IMailRuLikeButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size.ToInvariantString());
    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IMailRuLikeButtonWidgetExtensions.Size(null, default(MailRuLikeButtonSize))).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new MailRuLikeButtonWidget();
      Enum.GetValues<MailRuLikeButtonSize>().ForEach(value => Validate(value, widget));

      static void Validate(MailRuLikeButtonSize size, IMailRuLikeButtonWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("SizeProperty").Should().Be(size.ToString().ToLowerInvariant());
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

      var widget = new MailRuLikeButtonWidget();
      Enum.GetValues<MailRuLikeButtonLayout>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(MailRuLikeButtonLayout layout, IMailRuLikeButtonWidget widget) => widget.Layout(layout).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LayoutProperty").Should().Be((byte) layout);
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

      var widget = new MailRuLikeButtonWidget();
      Enum.GetValues<MailRuLikeButtonTextType>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(MailRuLikeButtonTextType type, IMailRuLikeButtonWidget widget) => widget.TextType(type).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("TextTypeProperty").Should().Be((byte) type);
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

      var widget = new MailRuLikeButtonWidget();
      Enum.GetValues<MailRuLikeButtonCounterPosition>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(MailRuLikeButtonCounterPosition position, IMailRuLikeButtonWidget widget) => widget.CounterPosition(position).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("CounterPositionProperty").Should().Be(position.ToString().ToLowerInvariant());
  }
}