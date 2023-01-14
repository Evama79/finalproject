namespace Ns {
    public class Tests {
        
        static string[] Filter(string[] arr) {
            string[] buffer = new string[arr.Length];
            int i = 0;
            foreach(string item in arr) {
                if(item.Length <= 3) {
                    buffer[i] = item;
                    i++;
                }
            }
            return buffer;
        }
        public static void Main(string[] args) {
            string[] test = {"asd", "sdfg", "qwe", "a143", "ghruaf", "234"};
            List<string> ls = new List<string>();

            foreach(string item in Filter(test)) {
                Console.Write("{0}\t", item);
            }
        }
    }
}