namespace blackJack
{
    public  class  Card
    {
        private string name;

        private int value;

        public Card(string namePlace, int valuePlace)
        {
            name = namePlace;
            value = valuePlace;
        }

        public int getValue()
        {
            return value;
        }

        public string getName()
        {
            return name;
        }
        



    }
}