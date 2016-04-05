#if DNXCORE50

namespace System.Runtime.Serialization
{
    public class SerializableAttribute : Attribute
    {
    }


    internal interface ISerializable
    {
        void OnDeserialization(object o);
        void GetObjectData(object o1, object o2);

    }

}


#endif