namespace fundamentals
{
    public class Cat
    {
        public string name;
        public string ownerName;
        private string type;
        public static int legCount = 4;
        
        public Cat()
        {
            this.name = "Catsie";
            this.ownerName = "Ownersie";
            this.type = "yellow";
        }
        
        public string Type
        {
            get { return type; }
            set { type =  value == "yellow" ? value : "non-yellow"; }          
        }

    }

}
