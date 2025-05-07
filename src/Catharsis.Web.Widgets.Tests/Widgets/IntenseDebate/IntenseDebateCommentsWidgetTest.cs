using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions.Execution;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateCommentsWidget"/>.</para>
/// </summary>
public sealed class IntenseDebateCommentsWidgetTest : Test
{
  private IIntenseDebateCommentsWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IntenseDebateCommentsWidgetTest() => Widget = Fixture.Create<IIntenseDebateCommentsWidget>();

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
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("PostIdValue").Should().BeNull();
      widget.GetPropertyValue<string>("PostUrlValue").Should().BeNull();
      widget.GetPropertyValue<string>("PostTitleValue").Should().BeNull();
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string account, IIntenseDebateCommentsWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string id, IIntenseDebateCommentsWidget widget) => widget.PostId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostIdValue").Should().Be(id);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string url, IIntenseDebateCommentsWidget widget) => widget.PostUrl(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostUrlValue").Should().Be(url);
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

      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(string title, IIntenseDebateCommentsWidget widget) => widget.PostTitle(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostTitleValue").Should().Be(title);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateCommentsWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Validate(new IntenseDebateCommentsWidget());
      Validate(Fixture.Create<IIntenseDebateCommentsWidget>());
    }

    return;

    static void Validate(IIntenseDebateCommentsWidget original)
    {
      var clone = original.Clone<IIntenseDebateCommentsWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("PostIdValue").Should().Be(original.GetPropertyValue<string>("PostIdValue"));
      clone.GetPropertyValue<string>("PostUrlValue").Should().Be(original.GetPropertyValue<string>("PostUrlValue"));
      clone.GetPropertyValue<string>("PostTitleValue").Should().Be(original.GetPropertyValue<string>("PostTitleValue"));
    }
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
      Validate(Fixture.Create<IIntenseDebateCommentsWidget>());
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