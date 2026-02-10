namespace MyFirstApi3.Entities
{
    public abstract class Device
    {
        public bool IsConnected() => true;

        public abstract string GetBrand();
       
    }
}
