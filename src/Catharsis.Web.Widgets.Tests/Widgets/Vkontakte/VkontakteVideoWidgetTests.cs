using Catharsis.Commons;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="VkontakteVideoWidget"/>.</para>
/// </summary>
public sealed class VkontakteVideoWidgetTests : ClassTest<VkontakteVideoWidget>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="VkontakteVideoWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(VkontakteVideoWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<IVkontakteVideoWidget>();

    var widget = new VkontakteVideoWidget();
    widget.Id().Should().BeNull();
    widget.Width().Should().BeNull();
    widget.Height().Should().BeNull();
    widget.Hd().Should().BeFalse();
    widget.User().Should().BeNull();
    widget.Hash().Should().BeNull();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Id(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Id(null));
    Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Id(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string id, IVkontakteVideoWidget widget)
    {
      widget.Id(id).Should().BeSameAs(widget);
      widget.Id().Should().Be(id);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Width(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Width(null));
    Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Width(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string width, IVkontakteVideoWidget widget)
    {
      widget.Width(width).Should().BeSameAs(widget);
      widget.Width().Should().Be(width);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Height(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Height_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Height(null));
    Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Height(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string height, IVkontakteVideoWidget widget)
    {
      widget.Height(height).Should().BeSameAs(widget);
      widget.Height().Should().Be(height);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Hd(bool)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hd_Method()
  {
    using (new AssertionScope())
    {
      var widget = new VkontakteVideoWidget();
      new[] { false, true }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(bool hd, IVkontakteVideoWidget widget)
    {
      widget.Hd(hd).Should().BeSameAs(widget);
      widget.Hd().Should().Be(hd);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.User(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void User_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().User(null));
    Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().User(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string user, IVkontakteVideoWidget widget)
    {
      widget.User(user).Should().BeSameAs(widget);
      widget.User().Should().Be(user);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.Hash(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Hash_Method()
  {
    Assert.Throws<ArgumentNullException>(() => new VkontakteVideoWidget().Hash(null));
    Assert.Throws<ArgumentException>(() => new VkontakteVideoWidget().Hash(string.Empty));

    using (new AssertionScope())
    {
      var widget = new VkontakteVideoWidget();
      new[] { new Random().AlphaDigits(16) }.ForEach(value => Validate(value, widget));
    }

    return;

    static void Validate(string hash, IVkontakteVideoWidget widget)
    {
      widget.Hash(hash).Should().BeSameAs(widget);
      widget.Hash().Should().Be(hash);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="VkontakteVideoWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Validate(new VkontakteVideoWidget());
      Validate(new VkontakteVideoWidget().User("oid").Hash("hash").Width("width").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").Hash("hash").Width("width").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Width("width").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Height("height"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width"));
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height"), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=0" webkitallowfullscreen="true" width="width"></iframe>""");
      Validate(new VkontakteVideoWidget().Id("id").User("user").Hash("hash").Width("width").Height("height").Hd(true), """<iframe allowfullscreen="true" frameborder="0" height="height" mozallowfullscreen="true" src="http://vk.com/video_ext.php?oid=user&amp;id=id&amp;hash=hash&amp;hd=1" webkitallowfullscreen="true" width="width"></iframe>""");
    }

    return;

    static void Validate(IWebWidget widget, params string[] html)
    {
      widget.ToHtml().Should().NotBeSameAs(widget.ToHtml());

      if (html.IsEmpty())
      {
        widget.ToHtml().Should().BeEmpty();
      }
      else
      {
        widget.ToHtml().Should().ContainAll(html);
      }
    }
  }
}