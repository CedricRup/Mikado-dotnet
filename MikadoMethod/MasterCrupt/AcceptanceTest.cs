using Xunit;

namespace MasterCrupt
{
    
    public class AcceptanceTest
    {
        [Fact]
        public void TestSecret()
        {
            UI ui = new UI();
            Assert.Equal("Leeted: S3cr3t", ui.EncryptMessage("Secret"));
        }
    }
}
