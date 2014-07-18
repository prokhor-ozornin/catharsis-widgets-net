using System;
using System.Threading;
using System.Web;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TwitterFollowButtonWidget"/>.</para>
  /// </summary>
  public sealed class TwitterFollowButtonWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="TwitterFollowButtonWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Account());
      Assert.Null(widget.Language());
      Assert.Null(widget.Size());
      Assert.Null(widget.Alignment());
      Assert.Null(widget.Counter());
      Assert.Null(widget.ScreenName());
      Assert.Null(widget.Suggestions());
      Assert.Null(widget.Width());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Account(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Language(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Language_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Language(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Language(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Language());
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.Equal("language", widget.Language());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Size(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Size(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Size(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Size());
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Size());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Alignment(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Alignment_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Alignment(null));
      Assert.Throws<ArgumentException>(() => new TwitterFollowButtonWidget().Alignment(string.Empty));

      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Alignment());
      Assert.True(ReferenceEquals(widget.Alignment("alignment"), widget));
      Assert.Equal("alignment", widget.Alignment());
    }
    
    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Counter(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Counter_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Counter());
      Assert.True(ReferenceEquals(widget.Counter(true), widget));
      Assert.True(widget.Counter().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ScreenName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ScreenName_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.ScreenName());
      Assert.True(ReferenceEquals(widget.ScreenName(true), widget));
      Assert.True(widget.ScreenName().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Suggestions(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Suggestions_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Suggestions());
      Assert.True(ReferenceEquals(widget.Suggestions(true), widget));
      Assert.True(widget.Suggestions().Value);
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(@"<a class=""twitter-follow-button"" data-lang=""{0}"" href=""https://twitter.com/account""></a>".FormatSelf(HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), new TwitterFollowButtonWidget().Account("account").ToString());
      Assert.Equal(@"<a class=""twitter-follow-button"" data-align=""align"" data-dnt=""true"" data-lang=""en"" data-show-count=""true"" data-show-screen-name=""true"" data-size=""size"" data-width=""width"" href=""https://twitter.com/account""></a>", new TwitterFollowButtonWidget().Account("account").Language("en").Counter(true).Size("size").Width("width").Alignment("align").ScreenName(true).Suggestions(false).ToString());
    }
  }
}