namespace custom_indexers
{
    public class store_index
    {
        // global declaration

        private string[] vegetables = new string[2];

        // creating custom indexer method, to get and set the value

        public string this[int index] 
        {
            // get the value at the index 
            get { return vegetables[index]; }

            // set the value at the index 
            set { vegetables[index] = value; }
        }
            
    }
}