using System;
using System.IO;
using Xunit;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Tests set for class <see cref="GoogleMapWidget"/>.</para>
  /// </summary>
  public sealed class GoogleMapWidgetTests
  {
    /// <summary>
    ///   <para>Performs testing of class constructor(s).</para>
    /// </summary>
    /// <seealso cref="GoogleMapWidget()"/>
    [Fact]
    public void Constructors()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para>Performs testing of <see cref="GoogleMapWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    public void Write_Method()
    {
      Assert.Throws<ArgumentNullException>(() => new GoogleMapWidget().Write(null));

      throw new NotImplementedException();
    }
  }
}