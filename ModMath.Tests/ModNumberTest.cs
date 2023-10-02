namespace ModMath.Tests;

using ModNumber;

public class ModNumberTest
{
    [Fact]
    public void Test_ToString_Conversion()
    {
        ModNumber.SetModulus(7);
        ModNumber modNum = new ModNumber(8);

        Assert.Equal(1, modNum);
    }
}