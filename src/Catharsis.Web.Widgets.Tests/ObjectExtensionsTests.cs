using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ObjectExtensions"/>.</para>
/// </summary>
public sealed class ObjectExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ObjectExtensions.Json(object)"/> method.</para>
  /// </summary>
  [Fact(Skip = "To be implemented")]
  public void Json_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ((object) null).Json());

    throw new NotImplementedException();
  }
}