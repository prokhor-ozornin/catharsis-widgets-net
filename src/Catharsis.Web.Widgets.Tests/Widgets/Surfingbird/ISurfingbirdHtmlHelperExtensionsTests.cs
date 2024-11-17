using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="ISurfingbirdWidgetCreatorExtensions"/>.</para>
/// </summary>
public sealed class SurfingbirdWidgetCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdWidgetCreatorExtensions.SurfButton(ISurfingbirdWidgetCreator, Action{ISurfingbirdSurfButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Like_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ISurfingbirdWidgetCreatorExtensions.SurfButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new SurfingbirdWidgetCreator().SurfButton(null));

    Assert.Equal(new SurfingbirdWidgetCreator().SurfButton().ToHtml(), new SurfingbirdWidgetCreator().SurfButton(_ => { }));
    Assert.Equal(new SurfingbirdWidgetCreator().SurfButton().Url("url").ToHtml(), new SurfingbirdWidgetCreator().SurfButton(x => x.Url("url")));
  }
}