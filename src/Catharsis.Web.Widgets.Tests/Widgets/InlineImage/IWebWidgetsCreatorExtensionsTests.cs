using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTests
{
  private readonly IWebWidgetsCreator widgets = Widgets.Create;

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IWebWidgetsCreatorExtensions.InlineImage(IWebWidgetsCreator)"/></description></item>
  ///     <item><description><see cref="IWebWidgetsCreatorExtensions.InlineImage(IWebWidgetsCreator, Action{IInlineImageWidget})"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void InlineImage_Methods()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.InlineImage(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.InlineImage(null, _ => { })).ThrowExactly<ArgumentNullException>().WithParameterName("creator");
    AssertionExtensions.Should(() => widgets.InlineImage(null)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

    Assert.NotNull(widgets.InlineImage());
    Assert.False(ReferenceEquals(widgets.InlineImage(), widgets.InlineImage()));
    Assert.Equal(widgets.InlineImage().ToString(), widgets.InlineImage().ToString());

    Assert.Equal(widgets.InlineImage().ToHtml(), widgets.InlineImage(_ => { }));
    Assert.Equal(widgets.InlineImage().Contents(Guid.Empty.ToByteArray()).ToHtml(), widgets.InlineImage(x => x.Contents(Guid.Empty.ToByteArray())));
  }
}