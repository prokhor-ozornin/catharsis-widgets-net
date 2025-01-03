using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontaktePollWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontaktePollWidgetExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontaktePollWidgetExtensions.Width(IVkontaktePollWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontaktePollWidgetExtensions.Width(null, default)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      var widget = new VkontaktePollWidget();
      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(short width, IVkontaktePollWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width.ToInvariantString());
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontaktePollWidgetExtensions.Url(IVkontaktePollWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontaktePollWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IVkontaktePollWidgetExtensions.Url(new VkontaktePollWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      var widget = new VkontaktePollWidget();
      new[] { "http://localhost".ToUri() }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(Uri url, IVkontaktePollWidget widget)
    {
      widget.Url(url).Should().BeSameAs(widget);
      widget.Url().Should().Be(url.ToString());
    }
  }
}