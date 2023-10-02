namespace ModMath;

struct ModNumber
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
        new ModNumber(left._modValue / right._modValue);

    public static implicit operator int(ModNumber modNumber) => modNumber._modValue;

    public override string ToString() => $"{_modValue}";

    public static void SetModulus(int modulus)
    {
        s_modulus = modulus;
    }
}
