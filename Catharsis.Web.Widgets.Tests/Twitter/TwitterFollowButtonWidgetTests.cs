using System;
using System.IO;
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
      Assert.Null(widget.Field("account"));
      Assert.Null(widget.Field("language"));
      Assert.Null(widget.Field("size"));
      Assert.Null(widget.Field("alignment"));
      Assert.Null(widget.Field("count"));
      Assert.Null(widget.Field("screenName"));
      Assert.Null(widget.Field("optOut"));
      Assert.Null(widget.Field("width"));
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
      Assert.Null(widget.Field("account"));
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Field("account").To<string>());
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
      Assert.Null(widget.Field("language"));
      Assert.True(ReferenceEquals(widget.Language("language"), widget));
      Assert.Equal("language", widget.Field("language").To<string>());
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
      Assert.Null(widget.Field("size"));
      Assert.True(ReferenceEquals(widget.Size("size"), widget));
      Assert.Equal("size", widget.Field("size").To<string>());
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
      Assert.Null(widget.Field("alignment"));
      Assert.True(ReferenceEquals(widget.Alignment("alignment"), widget));
      Assert.Equal("alignment", widget.Field("alignment").To<string>());
    }
    
    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Count(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void Count_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Field("count"));
      Assert.True(ReferenceEquals(widget.Count(), widget));
      Assert.True(widget.Field("count").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.ScreenName(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void ScreenName_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Field("screenName"));
      Assert.True(ReferenceEquals(widget.ScreenName(), widget));
      Assert.True(widget.Field("screenName").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.OptOut(bool)"/> method.</para>
    /// </summary>
    [Fact]
    public void OptOut_Method()
    {
      var widget = new TwitterFollowButtonWidget();
      Assert.Null(widget.Field("optOut"));
      Assert.True(ReferenceEquals(widget.OptOut(), widget));
      Assert.True(widget.Field("optOut").To<bool>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="TwitterFollowButtonWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new TwitterFollowButtonWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new TwitterFollowButtonWidget().Account("account").Write(writer)).ToString() == @"<a class=""twitter-follow-button"" data-lang=""{0}"" href=""https://twitter.com/account""></a>".FormatSelf(HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName));
      Assert.Equal(@"<a class=""twitter-follow-button"" data-align=""align"" data-dnt=""true"" data-lang=""en"" data-show-count=""true"" data-show-screen-name=""true"" data-size=""size"" data-width=""width"" href=""https://twitter.com/account""></a>", new StringWriter().With(writer => new TwitterFollowButtonWidget().Account("account").Language("en").Count().Size("size").Width("width").Alignment("align").ScreenName().OptOut().Write(writer)).ToString());
    }
  }
}