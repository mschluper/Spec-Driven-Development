using Bunit;
using SpecDrivenDevelopment.Components.Pages;

namespace SpecDrivenDevelopment.Tests.Pages
{
    public class HomePageTests : TestContext, IDisposable
    {
        [Fact]
        public void PageHeader_Exists()
        {
            // Act
            var component = RenderComponent<Home>();

            // Assert
            component.WaitForAssertion(() =>
            {
                Assert.Contains("Hello there", component.Find("h1").TextContent);
            });
        }

        public new void Dispose()
        {
            
        }
    }
}