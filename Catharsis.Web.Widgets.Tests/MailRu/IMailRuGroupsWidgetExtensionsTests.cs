using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IMailRuGroupsWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IMailRuGroupsWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuGroupsWidgetExtensions.Height(IMailRuGroupsWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuGroupsWidgetExtensions.Height(null, 0));

      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuGroupsWidgetExtensions.Width(IMailRuGroupsWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuGroupsWidgetExtensions.Width(null, 0));

      throw new NotImplementedException();
    }
  }
}