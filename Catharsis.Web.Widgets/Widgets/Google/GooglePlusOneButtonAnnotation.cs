namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Annotation to display next to the button.</para>
  /// </summary>
  public enum GooglePlusOneButtonAnnotation
  {
    /// <summary>
    ///   <para>Display the number of users who have +1'd the page in a graphic next to the button.</para>
    /// </summary>
    Bubble,

    /// <summary>
    ///   <para>Display profile pictures of connected users who have +1'd the page and a count of users who have +1'd the page.</para>
    /// </summary>
    Inline,
    
    /// <summary>
    ///   <para>Do not render additional annotations.</para>
    /// </summary>
    None
  }
}