namespace ModMath.Tests;

using ModNumber;

public class ModNumberTest
{
    [Fact]
    public void Test_implicit_int_conversion()
    {
        ModNumber.SetModulus(7);
        ModNumber modNum = new ModNumber(8);

        Assert.Equal(1, modNum);
    }

    [Fact]
    public void Test_to_string_conversion()
    {
        ModNumber.SetModulus(7);
        ModNumber modNum = new ModNumber(8);

        Assert.Equal("1", modNum.ToString());
    }

    [Fact]
    public void Test_divison_with_modulus()
    {
        ModNumber.SetModulus(7);
        ModNumber a = new ModNumber(9);
        ModNumber b = new ModNumber(3);

        Assert.Equal(3, a / b);
    }
}