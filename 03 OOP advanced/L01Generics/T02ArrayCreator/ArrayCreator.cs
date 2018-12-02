public class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        var arrayOfItems = new T[length];

        for (int index = 0; index < length; index++)
        {
            arrayOfItems[index] = item;
        }

        return arrayOfItems;
    }
}
