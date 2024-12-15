using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostId(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("id");

      var widget = new IntenseDebateCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IIntenseDebateCommentsWidget widget)
    {
      widget.PostId(id).Should().BeSameAs(widget);
      widget.PostId().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.PostUrl(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PostUrl_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostUrl(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostUrl(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("url");

      var widget = new IntenseDebateCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string url, IIntenseDebateCommentsWidget widget)
    {
      widget.PostUrl(url).Should().BeSameAs(widget);
      widget.PostUrl().Should().Be(url);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.PostTitle(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PostTitle_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostTitle(null)).ThrowExactly<ArgumentNullException>().WithParameterName("title");
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostTitle(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("title");

      var widget = new IntenseDebateCommentsWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string title, IIntenseDebateCommentsWidget widget)
    {
      widget.PostTitle(title).Should().BeSameAs(widget);
      widget.PostTitle().Should().Be(title);
    }
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

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}