using AutoFixture;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IVkontaktePostWidgetExtensions"/>.</para>
/// </summary>
public sealed class IVkontaktePostWidgetExtensionsTest : Test
{
  private IVkontaktePostWidget Widget { get; }

  /// <summary>
  ///   <para>Test constructor.</para>
  /// </summary>
  public IVkontaktePostWidgetExtensionsTest() => Widget = Fixture.Create<IVkontaktePostWidget>();

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontaktePostWidgetExtensions.Id(IVkontaktePostWidget, long)"/> method.</para>
  /// </summary>
  [Fact]
  public void Id_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontaktePostWidgetExtensions.Id(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { long.MinValue, long.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(long id, IVkontaktePostWidget widget) => widget.Id(id).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("IdValue").Should().Be(id.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontaktePostWidgetExtensions.Owner(IVkontaktePostWidget, long)"/> method.</para>
  /// </summary>
  [Fact]
  public void Owner_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontaktePostWidgetExtensions.Owner(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { long.MinValue, long.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(long owner, IVkontaktePostWidget widget) => widget.Owner(owner).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("OwnerValue").Should().Be(owner.ToInvariantString());
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IVkontaktePostWidgetExtensions.Width(IVkontaktePostWidget, short)"/> method.</para>
  /// </summary>
  [Fact]
  public void Width()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IVkontaktePostWidgetExtensions.Width(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("widget");

      new[] { short.MinValue, short.MaxValue }.ForEach(value => Validate(value, Widget));
    }

    return;

    static void Validate(short width, IVkontaktePostWidget widget) => widget.Width(width).Should().BeSameAs(widget).And.Subject.GetPropertyValue<string>("WidthValue").Should().Be(width.ToInvariantString());
  }
}