namespace SchoolDataStore.Entities
{
    public class EntittyBase
    {
        private string _id;
        private string _name;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                value = _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
