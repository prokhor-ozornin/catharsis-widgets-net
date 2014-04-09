using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IMailRuFacesWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IMailRuFacesWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Font(IMailRuFacesWidget, MailRuFacesFont)"/> method.</para>
    /// </summary>
    [Fact]
    public void Font_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuFacesWidgetExtensions.Font(null, MailRuFacesFont.Arial));

      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Height(IMailRuFacesWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuFacesWidgetExtensions.Height(null, 0));

      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IMailRuFacesWidgetExtensions.Width(IMailRuFacesWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IMailRuFacesWidgetExtensions.Width(null, 0));

      throw new NotImplementedException();
    }
  }
}