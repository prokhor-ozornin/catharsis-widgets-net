using FluentAssertions;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IWebWidgetsCreatorExtensions"/>.</para>
/// </summary>
/// <seealso cref="IWebWidgetsCreatorExtensions"/>
public sealed partial class IWebWidgetsCreatorExtensionsTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IWebWidgetsCreatorExtensions.LiveJournal(IWebWidgetsCreator)"/> method.</para>
  /// </summary>
  [Fact]
  public void LiveJournal_Method()
  {
    AssertionExtensions.Should(() => IWebWidgetsCreatorExtensions.LiveJournal(null)).ThrowExactly<ArgumentNullException>().WithParameterName("creator");

    Widgets.Create.LiveJournal().Should().BeOfType<LiveJournalWidgetsCreator>().And.BeSameAs(Widgets.Create.LiveJournal());
  }
}