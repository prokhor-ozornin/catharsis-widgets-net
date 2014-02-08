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
    ///   <para>Performs testing of <see cref="ISurfingbirdHtmlHelperExtensions.Surf(ISurfingbirdHtmlHelper, Action{ISurfingbirdSurfButtonWidget})"/> method.</para>
    /// </summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ISurfingbirdHtmlHelperExtensions.Surf(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new SurfingbirdHtmlHelper().Surf(null));

      Assert.True(new SurfingbirdHtmlHelper().Surf(x => { }) == new SurfingbirdHtmlHelper().Surf().ToHtmlString());
      Assert.True(new SurfingbirdHtmlHelper().Surf(x => x.Url("url")) == new SurfingbirdHtmlHelper().Surf().Url("url").ToHtmlString());
    }
  }
}