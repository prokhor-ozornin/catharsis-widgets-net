using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ISurfingbirdHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class ISurfingbirdHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ISurfingbirdHtmlHelperExtensions.SurfButton(ISurfingbirdHtmlHelper, Action{ISurfingbirdSurfButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISurfingbirdHtmlHelperExtensions.SurfButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdHtmlHelper().SurfButton(null));

      Assert.Equal(new SurfingbirdHtmlHelper().SurfButton().ToHtmlString(), new SurfingbirdHtmlHelper().SurfButton(x => { }));
      Assert.Equal(new SurfingbirdHtmlHelper().SurfButton().Url("url").ToHtmlString(), new SurfingbirdHtmlHelper().SurfButton(x => x.Url("url")));
    }
  }
}