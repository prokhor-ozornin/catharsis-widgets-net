using System;
using System.IO;
using Catharsis.Commons;
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
      Assert.True(widget.Field("acoount") == null);
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.True(widget.Field("account").To<string>() == "account");
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
      Assert.True(widget.Field("postId") == null);
      Assert.True(ReferenceEquals(widget.PostId("postId"), widget));
      Assert.True(widget.Field("postId").To<string>() == "postId");
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
      Assert.True(widget.Field("postUrl") == null);
      Assert.True(ReferenceEquals(widget.PostUrl("postUrl"), widget));
      Assert.True(widget.Field("postUrl").To<string>() == "postUrl");
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
      Assert.True(widget.Field("postTitle") == null);
      Assert.True(ReferenceEquals(widget.PostTitle("postTitle"), widget));
      Assert.True(widget.Field("postTitle").To<string>() == "postTitle");
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    [Fact]
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new IntenseDebateCommentsWidget().Write(null));

      Assert.True(new StringWriter().With(writer => new IntenseDebateCommentsWidget().Write(writer)).ToString().IsEmpty());

      new StringWriter().With(writer =>
      {
        new IntenseDebateCommentsWidget().Account("account").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"var idcomments_acct = ""account"";"));
        Assert.True(html.Contains(@"var idcomments_post_id = """""));
        Assert.True(html.Contains(@"var idcomments_post_url = """""));
        Assert.True(html.Contains(@"var idcomments_post_title = """""));
      });
      new StringWriter().With(writer =>
      {
        new IntenseDebateCommentsWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle").Write(writer);
        var html = writer.ToString();
        Assert.True(html.Contains(@"<script type=""text/javascript"">"));
        Assert.True(html.Contains(@"var idcomments_acct = ""account"";"));
        Assert.True(html.Contains(@"var idcomments_post_id = ""postId"""));
        Assert.True(html.Contains(@"var idcomments_post_url = ""postUrl"""));
        Assert.True(html.Contains(@"var idcomments_post_title = ""postTitle"""));
      });
    }
  }
}