using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi",3,7);
        Scripture scripture = new Scripture(reference,"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            scripture.HideRandomWords();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Type Enter to Hide, type q to quit");
            string choice = Console.ReadLine();
            Console.Clear();
            


            if (choice != "q")
            {

                Console.Clear();
                scripture.HideRandomWords();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Type s to Show, type q to quit");
                string show = Console.ReadLine();
                Console.Clear();

                if (show == "s")
                {
                    
                    while (show != "q")
                    {
                        Console.Clear();
                        scripture.ShowFullText();
                        Console.WriteLine();
                        Console.WriteLine("Type Enter to Continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                        
                    }
                    

                }
               
                
            }
            else
            {
                break;
            }

        }

        
    }
}