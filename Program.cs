using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        
        public static void RandomArray(){
            int[] arr = new int[10];
            Random rand = new Random();
            for(int i = 0; i< arr.Length; i++){
                arr[i] = rand.Next(5,26);
            }
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for(int i = 0; i < arr.Length; i++){
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine($"Max: {max}, Min: {min}, Sum: {sum}");
        }
        public static string CoinToss(){
            Random rand = new Random();
                int x = rand.Next(1,100);
                if(x % 2 == 0){
                    return "Heads";
                } else {
                    return "Tails";
                }
        }
        public static double MultipleCoinToss(int num){
            double heads = 0;
            double x = 0;
            for(int i = 0; i <= num; i++){
                string y = CoinToss();
                if(y == "Heads"){
                    heads += 1;
                }
                x += 1;
            }
            return (heads/x);
            }

        public static List<string> Names () {
            List<string> Names = new List<string> () {
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney"
            };
            foreach (var name in Names) {
                Console.WriteLine (name);
            }
            Random rand = new Random ();
            for (int i = 0; i < Names.Count; i++) {
                int x = rand.Next (Names.Count);
                var temp = Names[x];
                Names[x] = Names[i];
                Names[i] = temp;
            }
            foreach (var name in Names) {
                Console.WriteLine (name);
            }
            List<string> fiveOrMore = new List<string> ();
            foreach (var name in fiveOrMore) {
                if (name.Length >= 5) {
                    Console.WriteLine(name);
                    fiveOrMore.Add (name);
                }
            }
            return Names;
        }
    




    static void Main(string[] args)
    {
        // RandomArray();
        Console.WriteLine(CoinToss());
        Console.WriteLine(MultipleCoinToss(20));
    }
}
}
