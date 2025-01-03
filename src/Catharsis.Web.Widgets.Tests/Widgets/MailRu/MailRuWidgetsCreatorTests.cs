using Catharsis.Commons;
using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuWidgetsCreator"/>.</para>
/// </summary>
public sealed class MailRuWidgetsCreatorTests : ClassTest<MailRuWidgetsCreator>
{
  private readonly IMailRuWidgetsCreator widgets = Widgets.Create.MailRu();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="MailRuWidgetsCreator()"/>
  [Fact]
  public void Constructors()
  {
    typeof(MailRuWidgetsCreator).Should().BeDerivedFrom<object>().And.Implement<IMailRuWidgetsCreator>();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Faces()"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    widgets.Faces().Should().BeOfType<MailRuFacesWidget>().And.NotBeSameAs(widgets.Faces());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Groups()"/> method.</para>
  /// </summary>
  [Fact]
  public void Groups_Method()
  {
    widgets.Groups().Should().BeOfType<MailRuGroupsWidget>().And.NotBeSameAs(widgets.Groups());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Icq()"/> method.</para>
  /// </summary>
  [Fact]
  public void Icq_Method()
  {
    widgets.Icq().Should().BeOfType<MailRuIcqWidget>().And.NotBeSameAs(widgets.Icq());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    widgets.LikeButton().Should().BeOfType<MailRuLikeButtonWidget>().And.NotBeSameAs(widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    widgets.Video().Should().BeOfType<MailRuVideoWidget>().And.NotBeSameAs(widgets.Video());
  }
}