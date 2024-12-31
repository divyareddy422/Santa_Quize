using System;
class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Your Name: ");
        string name;
        int flag=0,count=0;
        name=Console.ReadLine();  
        if(name!=null)
        {
            foreach(char c in name)
            {
                if(!Char.IsLetter(c))
                {
                    flag++;
                }
            }
        }
        else
        {
            flag++;
        }
        if(flag<=0)
        {
            string []Questions={
                "Q1. What is the Smallest State in India ?",
                "Q2. What is the Largest Ocean in the World ?",
                "Q3. What is the National Rivar of India ?",
                "Q4. What is the sensitive organ in human body ?",
                "Q5. What is the small planet in the solar system ?"
            };
            string []Answers={
                "gova","pacific","ganga","skin","mercury"
            };
            for(int i=0;i<Questions.Length;i++)
            {
                Console.WriteLine(Questions[i]);
                string Uanswer;
                Console.WriteLine("Your Answer: ");
                Uanswer=Console.ReadLine();
                Uanswer=Uanswer.ToLower();
                if(Answers[i]== Uanswer)
                {
                    count++;
                }
            }
            Console.WriteLine($"Congratulations {name} You got {count} gifts from santa");
        }
        else
        {
            Console.WriteLine("Invalid user name!");
        }
    }
}