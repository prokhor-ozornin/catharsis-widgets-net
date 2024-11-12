using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IntenseDebateLinkWidget"/>.</para>
  /// </summary>
  public sealed class IntenseDebateLinkWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().Account(string.Empty));

      var widget = new IntenseDebateLinkWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.PostId(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PostId_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().PostId(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().PostId(string.Empty));

      var widget = new IntenseDebateLinkWidget();
      Assert.Null(widget.PostId());
      Assert.True(ReferenceEquals(widget.PostId("postId"), widget));
      Assert.Equal("postId", widget.PostId());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.PostUrl(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PostUrl_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().PostUrl(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().PostUrl(string.Empty));

      var widget = new IntenseDebateLinkWidget();
      Assert.Null(widget.PostUrl());
      Assert.True(ReferenceEquals(widget.PostUrl("postUrl"), widget));
      Assert.Equal("postUrl", widget.PostUrl());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.PostTitle(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void PostTitle_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().PostTitle(null));
      Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().PostTitle(string.Empty));

      var widget = new IntenseDebateLinkWidget();
      Assert.Null(widget.PostTitle());
      Assert.True(ReferenceEquals(widget.PostTitle("postTitle"), widget));
      Assert.Equal("postTitle", widget.PostTitle());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new IntenseDebateLinkWidget().ToString());

      var html = new IntenseDebateLinkWidget().Account("account").ToString();
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"var idcomments_acct = ""account"";"));
      Assert.True(html.Contains(@"var idcomments_post_id = """""));
      Assert.True(html.Contains(@"var idcomments_post_url = """""));
      Assert.True(html.Contains(@"var idcomments_post_title = """""));

      html = new IntenseDebateLinkWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle").ToString();
      Assert.True(html.Contains(@"<script type=""text/javascript"">"));
      Assert.True(html.Contains(@"var idcomments_acct = ""account"";"));
      Assert.True(html.Contains(@"var idcomments_post_id = ""postId"""));
      Assert.True(html.Contains(@"var idcomments_post_url = ""postUrl"""));
      Assert.True(html.Contains(@"var idcomments_post_title = ""postTitle"""));
    }
  }
}