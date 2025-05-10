using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SoundCloudProfileIconWidget"/>.</para>
/// </summary>
public sealed class SoundCloudProfileIconWidgetTest : Test
{
  private ISoundCloudProfileIconWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public SoundCloudProfileIconWidgetTest() => Widget = Fixture.Create<ISoundCloudProfileIconWidget>();

  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="SoundCloudProfileIconWidget()"/>
  [Fact]
  public void Constructors()
  {
    typeof(SoundCloudProfileIconWidget).Should().BeDerivedFrom<WebWidget>().And.Implement<ISoundCloudProfileIconWidget>();

    using (new AssertionScope())
    {
      var widget = new SoundCloudProfileIconWidget();
      widget.GetPropertyValue<string>("AccountValue").Should().BeNull();
      widget.GetPropertyValue<string>("ColorValue").Should().Be("orange_white");
      widget.GetPropertyValue<short>("SizeValue").Should().Be((short) SoundCloudProfileIconSize.Size32);
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Account(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Account_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SoundCloudProfileIconWidget().Account(null)).ThrowExactly<ArgumentNullException>().WithParameterName("account");
      AssertionExtensions.Should(() => new SoundCloudProfileIconWidget().Account(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("account");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string account, ISoundCloudProfileIconWidget widget) => widget.Account(account).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("AccountValue").Should().Be(account);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Color(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Color_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => new SoundCloudProfileIconWidget().Color(null)).ThrowExactly<ArgumentNullException>().WithParameterName("color");
      AssertionExtensions.Should(() => new SoundCloudProfileIconWidget().Color(string.Empty)).ThrowExactly<ArgumentException>().WithMessage("color");

      new[] { Fixture.Create<string>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(string color, ISoundCloudProfileIconWidget widget) => widget.Color(color).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("ColorValue").Should().Be(color);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Size(short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Size_Method()
  {
    using (new AssertionScope())
    {
      new[] { short.MinValue, short.MaxValue, Fixture.Create<short>() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short size, ISoundCloudProfileIconWidget widget) => widget.Size(size).Should().BeSameAs(widget).And.Subject.GetPropertyValue<short>("SizeValue").Should().Be(size);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.Clone()"/> method.</para>
  /// </summary>
  [Fact]
  public void Clone_Method()
  {
    using (new AssertionScope())
    {
      Test(new SoundCloudProfileIconWidget());
      Test(Fixture.Create<SoundCloudProfileIconWidget>());
    }

    return;

    static void Test(ISoundCloudProfileIconWidget original)
    {
      var clone = original.Clone<ISoundCloudProfileIconWidget>();

      clone.GetPropertyValue<string>("AccountValue").Should().Be(original.GetPropertyValue<string>("AccountValue"));
      clone.GetPropertyValue<string>("ColorValue").Should().Be(original.GetPropertyValue<string>("ColorValue"));
      clone.GetPropertyValue<short>("SizeValue").Should().Be(original.GetPropertyValue<short>("SizeValue"));
    }
  }
  
  /// <summary>
  ///   <para>Performs testing of <see cref="SoundCloudProfileIconWidget.ToHtml()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToHtml_Method()
  {
    using (new AssertionScope())
    {
      Test(new SoundCloudProfileIconWidget());
      Test(new SoundCloudProfileIconWidget().Account("account"), """<iframe allowtransparency="true" frameborder="0" scrolling="no" src="https://w.soundcloud.com/icon/?url=http://soundcloud.com/account&amp;color=orange_white&amp;size=32" style="width: 32px; height: 32px;"></iframe>""");
      Test(new SoundCloudProfileIconWidget().Account("account").Color("color").Size(1), """<iframe allowtransparency="true" frameborder="0" scrolling="no" src="https://w.soundcloud.com/icon/?url=http://soundcloud.com/account&amp;color=color&amp;size=1" style="width: 1px; height: 1px;"></iframe>""");
      Test(Fixture.Create<SoundCloudProfileIconWidget>());
    }

    return;

    static void Test(ISoundCloudProfileIconWidget widget, params string[] html)
    {
      if (html.IsUnset())
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