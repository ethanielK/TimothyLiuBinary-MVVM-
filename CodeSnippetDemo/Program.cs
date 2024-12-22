namespace CodeSnippetDemo
{
    internal class Program
    {
        // prop
        public string Level { get; set; }

        // propfull
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // propdp

        private int myVar;

        // propn

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set
        //    {
        //        myVar = value;
        //        this.RaisePropertyChanged("MyProperty");
        //    }
        //}


        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                
            }
        }
    }
}
