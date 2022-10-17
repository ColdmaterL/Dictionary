
namespace TestProj4Dictionary{
    class Program{
        static void Main(string[] args){
            string fileName;
            Dictionary<string, int> candidateDic = new Dictionary<string, int>();

            System.Console.Write("Enter file name: "); 
            fileName = Console.ReadLine()!;
            try{
                using(StreamReader sr = new StreamReader(fileName)){
                    while(!sr.EndOfStream){
                        string[] candidateAndVote = sr.ReadLine()!.Split(',');
                        if(!candidateDic.ContainsKey(candidateAndVote[0])){ // Doesn't have the key
                            candidateDic.Add(candidateAndVote[0], int.Parse(candidateAndVote[1]));
                        }
                        else{   // The key exits
                            candidateDic[candidateAndVote[0]] = candidateDic[candidateAndVote[0]] + int.Parse(candidateAndVote[1]); // Sum the votes in the key
                        }
                    }
                }
                foreach(KeyValuePair<string, int> item in candidateDic){
                    System.Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch(Exception e){
                System.Console.WriteLine("The file could not be read: ");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}