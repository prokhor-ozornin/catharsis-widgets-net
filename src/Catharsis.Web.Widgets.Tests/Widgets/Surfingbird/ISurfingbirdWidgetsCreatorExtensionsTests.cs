using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ISurfingbirdWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class ISurfingbirdWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ISurfingbirdWidgetsCreatorExtensions.SurfButton(ISurfingbirdWidgetsCreator, Action{ISurfingbirdSurfButtonWidget})"/> method.</para>
  /// </summary>
  [Fact]
  public void Like_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ISurfingbirdWidgetsCreatorExtensions.SurfButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new SurfingbirdWidgetsCreator().SurfButton(null));

    Assert.Equal(new SurfingbirdWidgetsCreator().SurfButton().ToHtml(), new SurfingbirdWidgetsCreator().SurfButton(_ => { }));
    Assert.Equal(new SurfingbirdWidgetsCreator().SurfButton().Url("url").ToHtml(), new SurfingbirdWidgetsCreator().SurfButton(x => x.Url("url")));
  }
}