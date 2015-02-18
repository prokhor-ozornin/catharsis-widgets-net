using System;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SoundCloudProfileIconWidget"/>.</para>
  /// </summary>
  public sealed class SoundCloudProfileIconWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="SoundCloudProfileIconWidget()"/>
    [Fact]
    public void Constructors()
    {
      var widget = new SoundCloudProfileIconWidget();
      Assert.Null(widget.Account());
      Assert.Equal("orange_white", widget.Color());
      Assert.Equal((short) SoundCloudProfileIconSize.Size32, widget.Size());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Account(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Account_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SoundCloudProfileIconWidget().Account(null));
      Assert.Throws<ArgumentException>(() => new SoundCloudProfileIconWidget().Account(string.Empty));

      var widget = new SoundCloudProfileIconWidget();
      Assert.Null(widget.Account());
      Assert.True(ReferenceEquals(widget.Account("account"), widget));
      Assert.Equal("account", widget.Account());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Color(string)"/> method.</para>
    /// </summary>
    [Fact]
    public void Color_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new SoundCloudProfileIconWidget().Color(null));
      Assert.Throws<ArgumentException>(() => new SoundCloudProfileIconWidget().Color(string.Empty));

      var widget = new SoundCloudProfileIconWidget();
      Assert.Equal("orange_white", widget.Color());
      Assert.True(ReferenceEquals(widget.Color("color"), widget));
      Assert.Equal("color", widget.Color());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Size(short)"/> method.</para>
    /// </summary>
    [Fact]
    public void Size_Method()
    {
      var widget = new SoundCloudProfileIconWidget();
      Assert.Equal((short) SoundCloudProfileIconSize.Size32, widget.Size());
      Assert.True(ReferenceEquals(widget.Size(1), widget));
      Assert.Equal(1, widget.Size());
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.ToHtmlString()"/> method.</para>
    /// </summary>
    [Fact]
    public void ToHtmlString_Method()
    {
      Assert.Equal(string.Empty, new SoundCloudProfileIconWidget().ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" scrolling=""no"" src=""https://w.soundcloud.com/icon/?url=http://soundcloud.com/account&amp;color=orange_white&amp;size=32"" style=""width: 32px; height: 32px;""></iframe>", new SoundCloudProfileIconWidget().Account("account").ToString());
      Assert.Equal(@"<iframe allowtransparency=""true"" frameborder=""0"" scrolling=""no"" src=""https://w.soundcloud.com/icon/?url=http://soundcloud.com/account&amp;color=color&amp;size=1"" style=""width: 1px; height: 1px;""></iframe>", new SoundCloudProfileIconWidget().Account("account").Color("color").Size(1).ToString());
    }
  }
}