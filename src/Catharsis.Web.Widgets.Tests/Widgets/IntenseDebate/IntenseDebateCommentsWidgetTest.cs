using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateCommentsWidget"/>.</para>
/// </summary>
public sealed class IntenseDebateCommentsWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="IntenseDebateCommentsWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(IntenseDebateCommentsWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IIntenseDebateCommentsWidget>();

    using (new AssertionScope())
    {
      var widget = new IntenseDebateCommentsWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<string>("PostIdProperty").Should().BeNull();
      widget.GetPropertyValue<string>("PostUrlProperty").Should().BeNull();
      widget.GetPropertyValue<string>("PostTitleProperty").Should().BeNull();
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new IntenseDebateCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, IIntenseDebateCommentsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
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
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new IntenseDebateCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IIntenseDebateCommentsWidget widget) => widget.PostId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostIdProperty").Should().Be(id);
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
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostUrl(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new IntenseDebateCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IIntenseDebateCommentsWidget widget) => widget.PostUrl(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostUrlProperty").Should().Be(url);
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
      AssertionExtensions.Should(() => new IntenseDebateCommentsWidget().PostTitle(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("title");

      new IntenseDebateCommentsWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string title, IIntenseDebateCommentsWidget widget) => widget.PostTitle(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostTitleProperty").Should().Be(title);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new IntenseDebateCommentsWidget());
      Validate(new IntenseDebateCommentsWidget().Account("account"),
               """<script type="text/javascript">""",
               """var idcomments_acct = "account";""",
               """
               var idcomments_post_id = ""
               """,
               """
               var idcomments_post_url = ""
               """,
               """
               var idcomments_post_title = ""
               """               
        );
      Validate(new IntenseDebateCommentsWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle"),
               """<script type="text/javascript">""",
               """var idcomments_acct = "account";""",
               """
               var idcomments_post_id = "postId"
               """,
               """
               var idcomments_post_url = "postUrl"
               """,
               """
               var idcomments_post_title = "postTitle"
               """
        );

    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      if (html.IsUnset())
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