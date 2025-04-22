using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateLinkWidget"/>.</para>
/// </summary>
public sealed class IntenseDebateLinkWidgetTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="IntenseDebateLinkWidgetTest()"/>
  [Fact]
  public void Constructors()
  {
    typeof(IntenseDebateLinkWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IIntenseDebateLinkWidget>();

    using (new AssertionScope())
    {
      var widget = new IntenseDebateLinkWidget();
      widget.GetPropertyValue<string>("AccountProperty").Should().BeNull();
      widget.GetPropertyValue<string>("PostIdProperty").Should().Be(SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant());
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
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new IntenseDebateLinkWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string account, IIntenseDebateLinkWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountProperty").Should().Be(account);
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
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostId(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("id");

      new IntenseDebateLinkWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string id, IIntenseDebateLinkWidget widget) => widget.PostId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostIdProperty").Should().Be(id);
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
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostUrl(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("url");

      new IntenseDebateLinkWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string url, IIntenseDebateLinkWidget widget) => widget.PostUrl(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostUrlProperty").Should().Be(url);
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
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().PostTitle(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("title");

      new IntenseDebateLinkWidget().With(widget => new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget)));
    }

    return;

    static void Validate(string title, IIntenseDebateLinkWidget widget) => widget.PostTitle(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostTitleProperty").Should().Be(title);
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