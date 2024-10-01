namespace ConsoleApp13
{
    class Video
    {
        public string title;
        public string author;
        // The type of video only have Education, Entertainment, Music and other.
        private string type;

        public Video(string title, string author, string type)
        {
            this.title = title;
            this.author = author;
            Type = type;
        }

        public string Type
        {
            get { return type; }
            set 
            { 
                if (value == "Education" || type == "Entertainment" || value == "Music" || value == "Other")
                {
                    type = value;
                }
                else
                {
                    type = "Other";
                }
            }
        }
    }
}
