using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ILiveJournalHtmlHelperExtensions"/>.</para>
  /// </summary>
  public sealed class ILiveJournalHtmlHelperExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="ILiveJournalHtmlHelperExtensions.LikeButton(ILiveJournalHtmlHelper, Action{ILiveJournalLikeButtonWidget}"/> method.</para></summary>
    [Fact]
    public void LikeButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ILiveJournalHtmlHelperExtensions.LikeButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new LiveJournalHtmlHelper().LikeButton(null));

      Assert.Equal(new LiveJournalHtmlHelper().LikeButton().ToHtmlString(), new LiveJournalHtmlHelper().LikeButton(x => { }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ILiveJournalHtmlHelperExtensions.RepostButton(ILiveJournalHtmlHelper, Action{ILiveJournalRepostButtonWidget}"/> method.</para></summary>
    [Fact]
    public void RepostButton_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ILiveJournalHtmlHelperExtensions.RepostButton(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new LiveJournalHtmlHelper().RepostButton(null));

      Assert.Equal(new LiveJournalHtmlHelper().RepostButton().ToHtmlString(), new LiveJournalHtmlHelper().RepostButton(x => { }));
    }
  }
}