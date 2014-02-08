﻿using System;
using System.Collections.Generic;
using System.IO;
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
    ///   <seealso cref="TwitterTweetButtonWidget()"/>
    /// </summary>
    [Fact]
    public void Constructors()
    {
      var widget = new TwitterTweetButtonWidget();
      Assert.True(widget.Field("url") == null);
      Assert.True(widget.Field("language") == null);
      Assert.True(widget.Field("text") == null);
      Assert.True(widget.Field("via") == null);
      Assert.True(widget.Field("size") == null);
      Assert.True(widget.Field("countUrl") == null);
      Assert.True(widget.Field("countPosition") == null);
      Assert.True(widget.Field("optOut") == null);
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
      Assert.True(widget.Field("account") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
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
      Assert.True(widget.Field("language") == null);
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.True(widget.Field("language").To<string>() == "language");
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
      Assert.True(widget.Field("text") == null);
      Assert.True(ReferenceEquals(widget.Text("text"), widget));
      Assert.True(widget.Field("text").To<string>() == "text");
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
      Assert.True(widget.Field("via") == null);
      Assert.True(ReferenceEquals(widget.Via("via"), widget));
      Assert.True(widget.Field("via").To<string>() == "via");
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
      Assert.True(widget.Field("size") == null);
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.True(widget.Field("size").To<string>() == "size");
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
      Assert.True(widget.Field("countUrl") == null);
      Assert.True(ReferenceEquals(widget.CountUrl("countUrl"), widget));
      Assert.True(widget.Field("countUrl").To<string>() == "countUrl");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.CountPosition(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void CountPosition_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().CountPosition(null));
      Assert.Throws<ArgumentException>(() => new TwitterTweetButtonWidget().CountPosition(string.Empty));

      var widget = new TwitterTweetButtonWidget();
      Assert.True(widget.Field("countPosition") == null);
      Assert.True(ReferenceEquals(widget.CountPosition("countPosition"), widget));
      Assert.True(widget.Field("countPosition").To<string>() == "countPosition");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.OptOut(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void OptOut_Method()
    {
      var widget = new TwitterTweetButtonWidget();
      Assert.True(widget.Field("opOut") == null);
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
    ///   <para>Performs testing of <see cref="TwitterTweetButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterTweetButtonWidget().Write(null));

      Assert.Equal(@"<a class=""twitter-share-button"" data-lang=""{0}"" href=""https://twitter.com/share""></a>".FormatValue(HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), new StringWriter().With(writer => new TwitterTweetButtonWidget().Write(writer)).ToString());
      Assert.True(new StringWriter().With(writer => new TwitterTweetButtonWidget().Write(writer)).ToString() == @"<a class=""twitter-share-button"" data-lang=""{0}"" href=""https://twitter.com/share""></a>".FormatValue(HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName));
      //Assert.True(new StringWriter().With(writer => new TwitterTweetButtonWidget().Language("en").Url("url").Via("via").Text("text").RelatedAccounts("related").CountPosition("count").CountUrl("countUrl").HashTags("tags").Size("size").OptOut().Write(writer)).ToString() == @"<a href=""https://twitter.com/share"" class=""twitter-hashtag-button"" data-lang=""en"" data-url=""url"" data-via=""via"" data-text=""text"" data-related=""relatedAccounts"" data-count=""countPosition"" data-counturl=""countUrl"" data-hashtags=""tags"" data-size=""size"" data-dnt=""true""></a>");
    }
  }
}