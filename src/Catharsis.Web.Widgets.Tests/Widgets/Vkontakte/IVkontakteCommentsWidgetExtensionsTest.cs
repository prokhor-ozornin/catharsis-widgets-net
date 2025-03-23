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

      var widget = new VkontakteCommentsWidget();
      Enum.GetValues<VkontakteCommentsLimit>().ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(VkontakteCommentsLimit limit, IVkontakteCommentsWidget widget)
    {
      widget.Limit(limit).Should().BeSameAs(widget);
      widget.GetPropertyValue<byte>("LimitProperty").Should().Be((byte) limit);
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
      var attach = widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").ToArray();
      Assert.Equal(2, attach.Count());
      Assert.True(attach.SequenceEqual(["first", "second"]));
    });
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.All).With(widget => Assert.Equal("*", widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Audio).With(widget => Assert.Equal("audio", widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Graffiti).With(widget => Assert.Equal("graffiti", widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Link).With(widget => Assert.Equal("link", widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Photo).With(widget => Assert.Equal("photo", widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Single()));
    new VkontakteCommentsWidget().Attach(VkontakteCommentsAttach.Video).With(widget => Assert.Equal("video", widget.GetPropertyValue<IEnumerable<string>>("AttachProperty").Single()));
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
      widget.GetPropertyValue<string>("WidthProperty").Should().Be(width.ToInvariantString());
    }
  }
}