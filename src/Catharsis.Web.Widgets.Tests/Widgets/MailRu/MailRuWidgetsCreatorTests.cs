using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="MailRuWidgetsCreator"/>.</para>
/// </summary>
public sealed class MailRuWidgetsCreatorTests : ClassTest<MailRuWidgetsCreator>
{
  private readonly IMailRuWidgetsCreator widgets = Widgets.Web.MailRu();

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Faces()"/> method.</para>
  /// </summary>
  [Fact]
  public void Faces_Method()
  {
    Assert.False(ReferenceEquals(widgets.Faces(), widgets.Faces()));
    Assert.True(widgets.Faces() is MailRuFacesWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Groups()"/> method.</para>
  /// </summary>
  [Fact]
  public void Groups_Method()
  {
    Assert.False(ReferenceEquals(widgets.Groups(), widgets.Groups()));
    Assert.True(widgets.Groups() is MailRuGroupsWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Icq()"/> method.</para>
  /// </summary>
  [Fact]
  public void Icq_Method()
  {
    Assert.False(ReferenceEquals(widgets.Icq(), widgets.Icq()));
    Assert.True(widgets.Icq() is MailRuIcqWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.LikeButton(), widgets.LikeButton()));
    Assert.True(widgets.LikeButton() is MailRuLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="MailRuWidgetsCreator.Video()"/> method.</para>
  /// </summary>
  [Fact]
  public void Video_Method()
  {
    Assert.False(ReferenceEquals(widgets.Video(), widgets.Video()));
    Assert.True(widgets.Video() is MailRuVideoWidget);
  }
}