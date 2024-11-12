namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Type of information to display for Vkontakte "Community" widget.</para>
  /// </summary>
  public enum VkontakteCommunityMode : byte
  {
    /// <summary>
    ///   <para>Display community's participants.</para>
    /// </summary>
    Participants = 0,

    /// <summary>
    ///   <para>Display only community's title.</para>
    /// </summary>
    Title = 1,

    /// <summary>
    ///   <para>Display community's news feed (wall).</para>
    /// </summary>
    News = 2
  }
}