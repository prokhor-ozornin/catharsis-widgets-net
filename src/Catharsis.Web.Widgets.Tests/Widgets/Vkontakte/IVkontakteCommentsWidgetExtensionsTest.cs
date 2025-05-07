using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontakteCommentsWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontakteCommentsWidgetExtensionsTest : Test
{
  private IVkontakteCommentsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVkontakteCommentsWidgetExtensionsTest() => Widget = Fixture.Create<IVkontakteCommentsWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontakteCommentsWidgetExtensions.Limit(IVkontakteCommentsWidget, VkontakteCommentsLimit)"/> method.</para>
  /// </summary>
  [Fact]
  public void Limit_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontakteCommentsWidgetExtensions.Limit(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      Enum.GetValues<VkontakteCommentsLimit>().ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(VkontakteCommentsLimit limit, IVkontakteCommentsWidget widget) => widget.Limit(limit).Should().BeSameAs(widget).And.Subject.GetPropertyValue<byte>("LimitValue").Should().Be((byte) limit);
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

      Validate(VkontakteCommentsAttach.All, "*", Widget);
      Validate(VkontakteCommentsAttach.Audio, "audio", Widget);
      Validate(VkontakteCommentsAttach.Graffiti, "graffiti", Widget);
      Validate(VkontakteCommentsAttach.Link, "link", Widget);
      Validate(VkontakteCommentsAttach.Photo, "photo", Widget);
      Validate(VkontakteCommentsAttach.Video, "video", Widget);
    }

    return;

    static void Validate(VkontakteCommentsAttach attach, string value, IVkontakteCommentsWidget widget) => widget.Attach(attach).Should().BeSameAs(widget).And.Subject.GetPropertyValue<IEnumerable<string>>("AttachValue").Should().Equal(value);
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

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short width, IVkontakteCommentsWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }
}