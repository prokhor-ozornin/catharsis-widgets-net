using Catharsis.Extensions;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IVkontaktePollWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontaktePollWidgetExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontaktePollWidgetExtensions.Width(IVkontaktePollWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => IVkontaktePollWidgetExtensions.Width(null, 0));

    new VkontaktePollWidget().With(widget =>
    {
      Assert.True(ReferenceEquals(widget.Width(1), widget));
      Assert.Equal("1", widget.Width());
    });
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontaktePollWidgetExtensions.Url(IVkontaktePollWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    throw new NotImplementedException();
  }
}