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
    ///   <para>Performs testing of <see cref="ILiveJournalHtmlHelperExtensions.Like(ILiveJournalHtmlHelper, Action{ILiveJournalLikeButtonWidget}"/> method.</para></summary>
    [Fact]
    public void Like_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ILiveJournalHtmlHelperExtensions.Like(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new LiveJournalHtmlHelper().Like(null));

      Assert.Equal(new LiveJournalHtmlHelper().Like().ToHtmlString(), new LiveJournalHtmlHelper().Like(x => { }));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="ILiveJournalHtmlHelperExtensions.Repost(ILiveJournalHtmlHelper, Action{ILiveJournalRepostButtonWidget}"/> method.</para></summary>
    [Fact]
    public void Repost_Method()
    {
      Assert.Throws<ArgumentNullException>(() => ILiveJournalHtmlHelperExtensions.Repost(null, widget => { }));
      Assert.Throws<ArgumentNullException>(() => new LiveJournalHtmlHelper().Repost(null));

      Assert.Equal(new LiveJournalHtmlHelper().Repost().ToHtmlString(), new LiveJournalHtmlHelper().Repost(x => { }));
    }
  }
}