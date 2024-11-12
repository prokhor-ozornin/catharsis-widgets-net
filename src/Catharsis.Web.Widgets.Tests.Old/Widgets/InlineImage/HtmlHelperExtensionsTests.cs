using System;
using System.Web.Mvc;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="HtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed partial class HtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of following methods :</para>
    ///   <list type="bullet">
    ///     <item><description><see cref="HtmlHelperExtensions.InlineImage(HtmlHelper)"/></description></item>
    ///     <item><description><see cref="HtmlHelperExtensions.InlineImage(HtmlHelper, Action{IInlineImageWidget})"/></description></item>
    ///   </list>
    /// </summary>
    [Fact]
    public void InlineImage_Methods()
    {
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.InlineImage(null));
      Assert.Throws<ArgumentNullException>(() => HtmlHelperExtensions.InlineImage(null, builder => { }));
      Assert.Throws<ArgumentNullException>(() => new MockHtmlHelper().InlineImage(null));

      Assert.NotNull(html.InlineImage());
      Assert.False(ReferenceEquals(html.InlineImage(), html.InlineImage()));
      Assert.Equal(html.InlineImage().ToString(), html.InlineImage().ToString());

      Assert.Equal(new MockHtmlHelper().InlineImage().ToHtmlString(), new MockHtmlHelper().InlineImage(x => { }));
      Assert.Equal(new MockHtmlHelper().InlineImage().Contents(Guid.Empty.ToByteArray()).ToHtmlString(), new MockHtmlHelper().InlineImage(x => x.Contents(Guid.Empty.ToByteArray())));
    }
  }
}