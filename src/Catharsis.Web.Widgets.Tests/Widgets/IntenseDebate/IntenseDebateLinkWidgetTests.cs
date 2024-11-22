using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateLinkWidget"/>.</para>
/// </summary>
public sealed class IntenseDebateLinkWidgetTests : ClassTest<IntenseDebateLinkWidget>
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().Account(null));
    Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().Account(string.Empty));

    using (new AssertionScope())
    {
      var widget = new IntenseDebateLinkWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string account, IIntenseDebateLinkWidget widget)
    {
      widget.Account(account).Should().BeSameAs(widget);
      widget.Account().Should().Be(account);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.PostId(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PostId_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().PostId(null));
    Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().PostId(string.Empty));

    using (new AssertionScope())
    {
      var widget = new IntenseDebateLinkWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IIntenseDebateLinkWidget widget)
    {
      widget.PostId(id).Should().BeSameAs(widget);
      widget.PostId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.PostUrl(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PostUrl_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().PostUrl(null));
    Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().PostUrl(string.Empty));

    using (new AssertionScope())
    {
      var widget = new IntenseDebateLinkWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IIntenseDebateLinkWidget widget)
    {
      widget.PostUrl(url).Should().BeSameAs(widget);
      widget.PostUrl().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.PostTitle(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PostTitle_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new IntenseDebateLinkWidget().PostTitle(null));
    Assert.Throws<ArgumentException>(() => new IntenseDebateLinkWidget().PostTitle(string.Empty));

    using (new AssertionScope())
    {
      var widget = new IntenseDebateLinkWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string title, IIntenseDebateLinkWidget widget)
    {
      widget.PostTitle(title).Should().BeSameAs(widget);
      widget.PostTitle().Should().Be(title);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    Assert.Equal(string.Empty, new IntenseDebateLinkWidget().ToString());

    var html = new IntenseDebateLinkWidget().Account("account").ToString();
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

    html = new IntenseDebateLinkWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle").ToString();
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