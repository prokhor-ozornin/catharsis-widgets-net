using Catharsis.Extensions;
using Catharsis.Fixture;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IFacebookPostWidgetExtensions"/>.</para>
/// </summary>
public sealed class IFacebookPostWidgetExtensionsTest : Test
{
  private IFacebookPostWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IFacebookPostWidgetExtensionsTest() => Widget = Fixture<IFacebookPostWidget>.Create();

  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookPostWidgetExtensions.Url(IFacebookPostWidget, Uri)"/> method.</para>
  /// </summary>
  [Fact]
  public void Url_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookPostWidgetExtensions.Url(null, "http://localhost".ToUri())).ThrowExactly<ArgumentNullException>().WithParameterName("widget");
      AssertionExtensions.Should(() => IFacebookPostWidgetExtensions.Url(new FacebookPostWidget(), null)).ThrowExactly<ArgumentNullException>().WithParameterName("url");

      new[] { Fixture<Uri>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(Uri url, IFacebookPostWidget widget) => widget.Url(url).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("UrlValue").Should().Be(url.ToString());
  }
  
  /// <summary>
  ///   <para>Performs testing of <see cref="IFacebookPostWidgetExtensions.Width(IFacebookPostWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IFacebookPostWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue, Fixture<short>.Create() }.ForEach(value => Test(value, Widget));
    }

    return;

    static void Test(short width, IFacebookPostWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }
}