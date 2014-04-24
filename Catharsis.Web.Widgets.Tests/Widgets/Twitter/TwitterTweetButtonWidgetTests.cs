using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TwitterTweetButtonWidget"/>.</para>
  /// </summary>
  public sealed class TwitterTweetButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="TwitterTweetButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("url"));
      Assert.Null(widget.Field("language"));
      Assert.Null(widget.Field("text"));
      Assert.Null(widget.Field("via"));
      Assert.Null(widget.Field("size"));
      Assert.Null(widget.Field("countUrl"));
      Assert.Null(widget.Field("counterPosition"));
      Assert.Null(widget.Field("optOut"));
      Assert.False(widget.Field("tags").To<IEnumerable<string>>().Any());
      Assert.False(widget.Field("accounts").To<IEnumerable<string>>().Any());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Url(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Url_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Url(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Url(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Language(string.Empty));

      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("language"));
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.Equal("language", widget.Field("language").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Text(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Text_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Text(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Text(string.Empty));

      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("text"));
      Assert.True(ReferenceEquals(widget.Text("text"), widget));
      Assert.Equal("text", widget.Field("text").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Via(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Via_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Via(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Via(string.Empty));

      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("via"));
      Assert.True(ReferenceEquals(widget.Via("via"), widget));
      Assert.Equal("via", widget.Field("via").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Size(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().Size(string.Empty));

      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("size"));
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Field("size").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.CountUrl(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void CountUrl_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().CountUrl(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().CountUrl(string.Empty));

      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("countUrl"));
      Assert.True(ReferenceEquals(widget.CountUrl("countUrl"), widget));
      Assert.Equal("countUrl", widget.Field("countUrl").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.CounterPosition(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void CounterPosition_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().CounterPosition(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().CounterPosition(string.Empty));

      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("counterPosition"));
      Assert.True(ReferenceEquals(widget.CounterPosition("counterPosition"), widget));
      Assert.Equal("counterPosition", widget.Field("counterPosition").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.OptOut(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void OptOut_Method()
    {
      var widget = new TwitterTweetButtonWidget();
      Assert.Null(widget.Field("opOut"));
      Assert.True(ReferenceEquals(widget.OptOut(), widget));
      Assert.True(widget.Field("optOut").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.HashTags(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void HashTags_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().HashTags(null));

      var widget = new TwitterTweetButtonWidget();
      Assert.False(widget.Field("tags").To<IEnumerable<string>>().Any());
      var tags = new [] { "first", "second", "third" };
      Assert.True(ReferenceEquals(widget.HashTags(tags), widget));
      Assert.True(widget.Field("tags").To<IEnumerable<string>>().SequenceEqual(tags));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/> method.</para>
    /// </summary>
    [Fact]
    public void RelatedAccounts_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().RelatedAccounts(null));

      var widget = new TwitterTweetButtonWidget();
      Assert.False(widget.Field("accounts").To<IEnumerable<string>>().Any());
      var accounts = new[] { "first", "second", "third" };
      Assert.True(ReferenceEquals(widget.RelatedAccounts(accounts), widget));
      Assert.True(widget.Field("accounts").To<IEnumerable<string>>().SequenceEqual(accounts));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<a class=""twitter-share-button"" data-lang=""{0}"" href=""https://twitter.com/share""></a>".FormatSelf(HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), new TwitterTweetButtonWidget().ToString());
      Assert.Equal(@"<a class=""twitter-hashtag-button"" data-count=""counterPosition"" data-counturl=""countUrl"" data-dnt=""true"" data-hashtags=""tags"" data-lang=""en"" data-related=""related"" data-size=""size"" data-text=""text"" data-url=""url"" data-via=""via"" href=""https://twitter.com/share""></a>", new TwitterTweetButtonWidget().Language("en").Url("url").Via("via").Text("text").RelatedAccounts("related").CounterPosition("counterPosition").CountUrl("countUrl").HashTags("tags").Size("size").OptOut().ToString());
    }
  }
}