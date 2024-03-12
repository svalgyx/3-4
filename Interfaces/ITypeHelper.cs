namespace HW3_4.Interfaces
{
    public interface ITypeHelper<T>
    {
        T Convert();
        int RandomInt();
        string RandomString();
        bool RandomBool();
        double RandomDouble();
        T RandomValue();
    }
}
