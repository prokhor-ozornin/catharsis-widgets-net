using System;
using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="IFacebookSendButtonWidgetExtensions"/>.</para>
  /// </summary>
  public sealed class IFacebookSendButtonWidgetExtensionsTests
  {
    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.Width(IFacebookSendButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Width_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookSendButtonWidgetExtensions.Width(null, 0));

      Assert.Equal("1", new FacebookSendButtonWidget().Width(1).Field("width").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.Height(IFacebookSendButtonWidget, short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Height_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookSendButtonWidgetExtensions.Height(null, 0));

      Assert.Equal("1", new FacebookSendButtonWidget().Height(1).Field("height").To<string>());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="IFacebookSendButtonWidgetExtensions.ColorScheme(IFacebookSendButtonWidget, FacebookColorScheme)"/> method.</para>
    /// </summary>
    [Fact]
    public void ColorScheme_Method()
    {
      Assert.Throws<ArgumentNullException>(() => IFacebookSendButtonWidgetExtensions.ColorScheme(null, FacebookColorScheme.Dark));

      Assert.Equal("dark", new FacebookSendButtonWidget().ColorScheme(FacebookColorScheme.Dark).Field("colorScheme").To<string>());
      Assert.Equal("light", new FacebookSendButtonWidget().ColorScheme(FacebookColorScheme.Light).Field("colorScheme").To<string>());
    }
  }
}