
namespace FillR
{
    public static class FillR
    {
        public static T Fill<T>(this T item)
        {
            return item;
        }

        public static T Fill<T>()
        {
            return default(T);
        }
    }
}
