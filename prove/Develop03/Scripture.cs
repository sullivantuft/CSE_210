using System.Reflection.Metadata;
using System.Security.Cryptography;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    
    public Scripture(Reference reference, string text)
    {
        _reference=reference;


        string currentWord="";

        foreach (char character in text)
        {
            
            if (character==' ')
            {
                
                Word word = new Word(currentWord);
                
                _words.Add(word);
                currentWord="";
            }
            else
            {
                currentWord+=character;
            }
            
        }
    }

    public void HideRandomWords(int numberToHide) //Stretch challenge: Modified to ensure no two numbers are repeated
    {
        List<int> positionSequence= new List<int>();
        Random random = new Random();
        int randomNumber=0;
        
        for(int i=0; i<_words.Count(); i++) //Creates a list of numbers for each possible index
        {
            positionSequence.Add(i);
        }
        
        for (int i = 0; i < numberToHide; i++)
        {
           
        randomNumber = random.Next(0, _words.Count);
            
        _words[positionSequence[randomNumber]].Hide(); //hides the word at the random index
        _words[positionSequence[randomNumber]].IsHidden();


        positionSequence.Remove(positionSequence.IndexOf(randomNumber)); //removes the word at the current position
       
        
        }

    }
    public string GetDisplayText()
    {
        string text="";
        
        foreach (var word in _words)
        {
            
            text=text + word.GetDisplayText()+ " ";
            
        }
        
        return _reference.GetDisplayText() + text; 
    }

    public bool IsCompletelyHidden()
    {
        
        return false;
    }
    


}