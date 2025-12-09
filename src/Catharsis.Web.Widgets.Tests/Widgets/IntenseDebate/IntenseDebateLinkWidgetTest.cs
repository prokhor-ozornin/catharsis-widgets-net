using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IntenseDebateLinkWidget"/>.</para>
/// </summary>
/// <seealso cref="IntenseDebateLinkWidget"/>
public sealed class IntenseDebateLinkWidgetTest : Test
{
  private IIntenseDebateLinkWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IntenseDebateLinkWidgetTest() => Widget = Fixture<IIntenseDebateLinkWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="IntenseDebateLinkWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(IntenseDebateLinkWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IIntenseDebateLinkWidget>();

    using (new AssertionScope())
    {
      var widget = new IntenseDebateLinkWidget();
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
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new IntenseDebateLinkWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture<string>.Create() }.ForEach(account => Test(account, Widget));
    }

    return;

    static void Test(string account, IIntenseDebateLinkWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
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

      new[] { Fixture<string>.Create() }.ForEach(id => Test(id, Widget));
    }

    return;

    static void Test(string id, IIntenseDebateLinkWidget widget) => widget.PostId(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostIdValue").Should().Be(id);
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

      new[] { Fixture<string>.Create() }.ForEach(url => Test(url, Widget));
    }

    return;

    static void Test(string url, IIntenseDebateLinkWidget widget) => widget.PostUrl(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostUrlValue").Should().Be(url);
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

      new[] { Fixture<string>.Create() }.ForEach(title => Test(title, Widget));
    }

    return;

    static void Test(string title, IIntenseDebateLinkWidget widget) => widget.PostTitle(title).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("PostTitleValue").Should().Be(title);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IntenseDebateLinkWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new IntenseDebateLinkWidget());
      Test(Fixture<IntenseDebateLinkWidget>.Create());
    }

    return;

    static void Test(IIntenseDebateLinkWidget original)
    {
      var clone = original.Clone<IIntenseDebateLinkWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("PostIdValue").Should().Be(original.GetPropertyValue<string>("PostIdValue"));
      clone.GetPropertyValue<string>("PostUrlValue").Should().Be(original.GetPropertyValue<string>("PostUrlValue"));
      clone.GetPropertyValue<string>("PostTitleValue").Should().Be(original.GetPropertyValue<string>("PostTitleValue"));
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
      Test(new IntenseDebateLinkWidget());
      Test(new IntenseDebateLinkWidget().Account("account"), """<script type="text/javascript">""", """var idcomments_acct = "account";""", """
                                                                                                                                                var idcomments_post_id = ""
                                                                                                                                                """, """
                                                                                                                                                     var idcomments_post_url = ""
                                                                                                                                                     """, ("""
                                                                                                                                                           var idcomments_post_title = ""
                                                                                                                                                           """));
      Test(Fixture<IntenseDebateLinkWidget>.Create());
    }


    Test(new IntenseDebateLinkWidget().Account("account").PostId("postId").PostUrl("postUrl").PostTitle("postTitle"), """<script type="text/javascript">""", """var idcomments_acct = "account";""", """
                                                                                                                                                                                                         var idcomments_post_id = "postId"
                                                                                                                                                                                                         """, """
                                                                                                                                                                                                              var idcomments_post_url = "postUrl"
                                                                                                                                                                                                              """, """
                                                                                                                                                                                                                   var idcomments_post_title = "postTitle"
                                                                                                                                                                                                                  """);
    return;

    static void Test(IIntenseDebateLinkWidget widget, params string[] html)
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