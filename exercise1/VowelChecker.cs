using System;

namespace exercise1;

public class VowelChecker
{
     public static void VowelCheck()
    {
        
        Console.Write("Enter the user  input: ");
        char vowel=char.Parse(Console.ReadLine());
        switch(vowel)
        {
            case ('a'): Console.Write("The input is a vowel");break;
            case ('e'):Console.Write("The input is a vowel");break;
            case ('i'):Console.Write("The input is a vowel");break;
            case ('o'):Console.Write("The input is a vowel");break;
            case ('u'):Console.Write("The input is a vowel");break;
            default : Console.Write("The input is a consonant");break;
            
            
        }
    }
}
