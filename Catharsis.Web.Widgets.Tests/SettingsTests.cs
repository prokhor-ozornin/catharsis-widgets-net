using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="Settings"/>.</para>
  /// </summary>
  public sealed class SettingsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="Settings.Global"/> property.</para>
    /// </summary>
    [Fact]
    public void Global_Property()
    {
      Assert.True(Settings.Global != null);
      Assert.True(ReferenceEquals(Settings.Global, Settings.Global));
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="Settings.Local"/> property.</para>
    /// </summary>
    [Fact]
    public void Local_Property()
    {
      Assert.True(Settings.Local != null);
      Assert.True(ReferenceEquals(Settings.Local, Settings.Local));
    }
  }
}