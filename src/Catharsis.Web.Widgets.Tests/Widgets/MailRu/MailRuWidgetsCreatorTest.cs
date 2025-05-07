using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MailRuWidgetsCreator"/>.</para>
/// </summary>
public sealed class MailRuWidgetsCreatorTest : Test
{
  private IMailRuWidgetsCreator Widgets { get; } = Web.Widgets.Widgets.Create.MailRu();

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
    Widgets.Faces().Should().BeOfType<MailRuFacesWidget>().And.NotBeSameAs(Widgets.Faces());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Groups()"/> method.</para>
  /// </summary>
  [Fact]
  public void Groups_Method()
  {
    Widgets.Groups().Should().BeOfType<MailRuGroupsWidget>().And.NotBeSameAs(Widgets.Groups());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Icq()"/> method.</para>
  /// </summary>
  [Fact]
  public void Icq_Method()
  {
    Widgets.Icq().Should().BeOfType<MailRuIcqWidget>().And.NotBeSameAs(Widgets.Icq());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Widgets.LikeButton().Should().BeOfType<MailRuLikeButtonWidget>().And.NotBeSameAs(Widgets.LikeButton());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Widgets.Video().Should().BeOfType<MailRuVideoWidget>().And.NotBeSameAs(Widgets.Video());
  }
}