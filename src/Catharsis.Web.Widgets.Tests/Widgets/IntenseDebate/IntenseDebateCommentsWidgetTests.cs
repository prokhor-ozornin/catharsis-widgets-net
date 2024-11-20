using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateCommentsWidget"/>.</para>
/// </summary>
public sealed class IntenseDebateCommentsWidgetTests : ClassTest<IntenseDebateCommentsWidget>
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new IntenseDebateCommentsWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new IntenseDebateCommentsWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new IntenseDebateCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IIntenseDebateCommentsWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
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
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new IntenseDebateCommentsWidget().ToString());

    var html = new IntenseDebateCommentsWidget().Account("account").ToString();
    Assert.True(html.Contains("""<script type="text/javascript">"""));
    Assert.True(html.Contains("""var idcomments_acct = "account";"""));
    Assert.True(html.Contains("""
                              var idcomments_post_id = ""
                              """));
    Assert.True(html.Contains("""
                              var idcomments_post_url = ""
                              """));
    Assert.True(html.Contains("""
                              var idcomments_post_title = ""
                              """));

    html = new IntenseDebateCommentsWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle").ToString();
    Assert.True(html.Contains("""<script type="text/javascript">"""));
    Assert.True(html.Contains("""var idcomments_acct = "account";"""));
    Assert.True(html.Contains("""
                              var idcomments_post_id = "postId"
                              """));
    Assert.True(html.Contains("""
                              var idcomments_post_url = "postUrl"
                              """));
    Assert.True(html.Contains("""
                              var idcomments_post_title = "postTitle"
                              """));
  }
}