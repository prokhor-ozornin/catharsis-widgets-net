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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("account");

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostId(null)).ThrowExactly<ArgumentNullException>().WithParameterName("id");
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostId(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("id");

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostUrl(null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostUrl(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("url");

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostTitle(null)).ThrowExactly<ArgumentNullException>().WithParameterName("title");
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostTitle(string.Empty)).ThrowExactly<ArgumentException>().WithParameterName("title");

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
    using (new AssertionScope())
    {
      Validate(new IntenseDebateLinkWidget());
      Validate(new IntenseDebateLinkWidget().Account("account"), """<script type="text/javascript">""", """var idcomments_acct = "account";""", """
                                                                                                                                                var idcomments_post_id = ""
                                                                                                                                                """, """
                                                                                                                                                     var idcomments_post_url = ""
                                                                                                                                                     """, ("""
                                                                                                                                                           var idcomments_post_title = ""
                                                                                                                                                           """));
    }


    Validate(new IntenseDebateLinkWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle"), """<script type="text/javascript">""", """var idcomments_acct = "account";""", """
                                                                                                                                                                                                         var idcomments_post_id = "postId"
                                                                                                                                                                                                         """, """
                                                                                                                                                                                                              var idcomments_post_url = "postUrl"
                                                                                                                                                                                                              """, """
                                                                                                                                                                                                                   var idcomments_post_title = "postTitle"
                                                                                                                                                                                                                  """);
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