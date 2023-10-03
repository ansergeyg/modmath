namespace ModMath.ModNumber;
public struct ModNumber
{
    private int _originValue;
    private int _modValue;
    private static int s_modulus = 5;

    public ModNumber(int value)
    {
        _originValue = value;
        _modValue = _originValue % s_modulus;
    }

    public static ModNumber operator +(ModNumber left, ModNumber right) =>
        new ModNumber(left._modValue + right._modValue % s_modulus);

    public static ModNumber operator -(ModNumber left, ModNumber right) =>
        new ModNumber(left._modValue - right._modValue % s_modulus);

    public static ModNumber operator *(ModNumber left, ModNumber right) =>
        new ModNumber(left._modValue * right._modValue % s_modulus);

    public static ModNumber operator /(ModNumber left, ModNumber right) =>
        new ModNumber(left._modValue * GetModInverse(right._modValue) % s_modulus);

    public static implicit operator int(ModNumber modNumber) => modNumber._modValue;

    public override string ToString() => $"{_modValue}";

    private static ModNumber BinaryPow(int baseNumber, int power)
    {
        ModNumber modResult = new ModNumber(1);
        ModNumber modBase = new ModNumber(baseNumber);

        while (power > 0)
        {
            if (power % 2 == 1)
            {
                modResult *= modBase;
            }

            modBase *= modBase;
            power >>= 1;
        }

        return modResult;
    }

    private static ModNumber GetModInverse(int number)
    {
        return BinaryPow(number, s_modulus - 2);
    }

    public static void SetModulus(int modulus)
    {
        s_modulus = modulus;
    }
}

