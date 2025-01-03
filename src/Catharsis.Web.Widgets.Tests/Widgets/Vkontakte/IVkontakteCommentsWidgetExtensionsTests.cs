using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteCommentsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteCommentsWidgetExtensionsTests : UnitTest
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

      var widget = new VkontakteCommentsWidget();
      Enum.GetValues<VkontakteCommentsLimit>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteCommentsLimit limit, IVkontakteCommentsWidget widget)
    {
      widget.Limit(limit).Should().BeSameAs(widget);
      widget.Limit().Should().Be((byte) limit);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Attach(IVkontakteCommentsWidget, VkontakteCommentsAttach[])"/> method.</para>
  /// </summary>
  [Fact]
  public void Attach_Method()
  {
    AssertionExtensions.Should(() => IVkontakteCommentsWidgetExtensions.Attach(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

    new VkontakteCommentsWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Attach("first", "second"), widget));
      var attach = widget.Attach().ToArray();
      Assert.Equal(2, attach.Count());
      Assert.True(attach.SequenceEqual(["first", "second"]));
    });
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.All).With(widget => Assert.Equal("*", widget.Attach().Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Audio).With(widget => Assert.Equal("audio", widget.Attach().Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Graffiti).With(widget => Assert.Equal("graffiti", widget.Attach().Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Link).With(widget => Assert.Equal("link", widget.Attach().Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Photo).With(widget => Assert.Equal("photo", widget.Attach().Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Video).With(widget => Assert.Equal("video", widget.Attach().Single()));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Width(IVkontakteCommentsWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommentsWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontakteCommentsWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IVkontakteCommentsWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width.ToInvariantString());
    }
  }
}