using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteCommentsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteCommentsWidgetExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Limit(IVkontakteCommentsWidget, VkontakteCommentsLimit)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommentsWidgetExtensions.Limit(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new VkontakteCommentsWidget().With(widget => Enum.GetValues<VkontakteCommentsLimit>().ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(VkontakteCommentsLimit limit, IVkontakteCommentsWidget widget) => widget.Limit(limit).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LimitProperty").Should().Be((byte) limit);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Attach(IVkontakteCommentsWidget, VkontakteCommentsAttach[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Attach_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommentsWidgetExtensions.Attach(null, null)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontakteCommentsWidget();
      Validate(VkontakteCommentsAttach.All, "*", widget);
      Validate(VkontakteCommentsAttach.Audio, "audio", widget);
      Validate(VkontakteCommentsAttach.Graffiti, "graffiti", widget);
      Validate(VkontakteCommentsAttach.Link, "link", widget);
      Validate(VkontakteCommentsAttach.Photo, "photo", widget);
      Validate(VkontakteCommentsAttach.Video, "video", widget);
    }

    return;

    static void Validate(VkontakteCommentsAttach attach, string value, IVkontakteCommentsWidget widget) => widget.Attach(attach).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("AttachProperty").Should().Equal(value);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Width(IVkontakteCommentsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommentsWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new VkontakteCommentsWidget().With(widget => new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(short width, IVkontakteCommentsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
  }
}