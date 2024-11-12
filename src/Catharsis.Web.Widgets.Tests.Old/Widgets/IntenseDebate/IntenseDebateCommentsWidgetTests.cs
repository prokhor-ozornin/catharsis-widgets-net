using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IntenseDebateCommentsWidget"/>.</para>
  /// </summary>
  public sealed class IntenseDebateCommentsWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateCommentsWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateCommentsWidget().Account(string.Empty));

      var widget = new IntenseDebateCommentsWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.PostId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PostId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateCommentsWidget().PostId(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateCommentsWidget().PostId(string.Empty));

      var widget = new IntenseDebateCommentsWidget();
      Assert.Null(widget.PostId());
      Assert.True(ReferenceEquals(widget.PostId("postId"), widget));
      Assert.Equal("postId", widget.PostId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.PostUrl(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PostUrl_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateCommentsWidget().PostUrl(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateCommentsWidget().PostUrl(string.Empty));

      var widget = new IntenseDebateCommentsWidget();
      Assert.Null(widget.PostUrl());
      Assert.True(ReferenceEquals(widget.PostUrl("postUrl"), widget));
      Assert.Equal("postUrl", widget.PostUrl());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.PostTitle(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PostTitle_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateCommentsWidget().PostTitle(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateCommentsWidget().PostTitle(string.Empty));

      var widget = new IntenseDebateCommentsWidget();
      Assert.Null(widget.PostTitle());
      Assert.True(ReferenceEquals(widget.PostTitle("postTitle"), widget));
      Assert.Equal("postTitle", widget.PostTitle());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new IntenseDebateCommentsWidget().ToString());

      var html = new IntenseDebateCommentsWidget().Account("account").ToString();
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"var idcomments_acct = ""account"";"));
      Assert.True(html.Contains(@"var idcomments_post_id = """""));
      Assert.True(html.Contains(@"var idcomments_post_url = """""));
      Assert.True(html.Contains(@"var idcomments_post_title = """""));

      html = new IntenseDebateCommentsWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle").ToString();
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"var idcomments_acct = ""account"";"));
      Assert.True(html.Contains(@"var idcomments_post_id = ""postId"""));
      Assert.True(html.Contains(@"var idcomments_post_url = ""postUrl"""));
      Assert.True(html.Contains(@"var idcomments_post_title = ""postTitle"""));
    }
  }
}