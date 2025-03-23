using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed partial class IWebWidgetsCreatorExtensionsTest
{
  private IWebWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create;

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
    AssertionExtensions.Should(() => Widgets.InlineImage(null)).ThrowExactly<ArgumentNullException>().WithParameterName("builder");

    Assert.NotNull(Widgets.InlineImage());
    Assert.False(ReferenceEquals(Widgets.InlineImage(), Widgets.InlineImage()));
    Assert.Equal(Widgets.InlineImage().ToString(), Widgets.InlineImage().ToString());

    Assert.Equal(Widgets.InlineImage().ToHtml(), Widgets.InlineImage(_ => { }));
    Assert.Equal(Widgets.InlineImage().Contents(Guid.Empty.ToByteArray()).ToHtml(), Widgets.InlineImage(x => x.Contents(Guid.Empty.ToByteArray())));
  }
}