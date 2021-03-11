namespace ListBox
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static int id=100;
        public Car()
        {
            Id = id++;
        }
    }
}