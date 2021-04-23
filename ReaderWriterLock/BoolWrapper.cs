namespace ReaderWriterLock
{
    public class BoolWrapper
    {
        public bool Value;

        public BoolWrapper(bool value)
        {
            Value = value;
        }
        
        public static BoolWrapper True = new BoolWrapper(true);
        public static BoolWrapper False = new BoolWrapper(false);

    }
}