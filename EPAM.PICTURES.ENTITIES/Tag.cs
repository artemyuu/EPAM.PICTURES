namespace EPAM.PICTURES.ENTITIES
{
    public class Tag
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public Tag(int id, string title)
        {
            Id = id;
            Title = title;
        }

    }
}
