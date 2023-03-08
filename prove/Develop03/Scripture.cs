using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Declare private fields to hold the reference and words of the scripture
    private Reference _reference;
    private List<Word> _words;
    // Define a constructor for the Scripture class that takes a reference and a string of text
    public Scripture(Reference reference, string text)
    {
        // Store the reference and create a list of Word objects from the text
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    // Define a method to hide the next word in the scripture
    public void HideWords()
    {
        // Iterate through each word in the list of words
        foreach (Word word in _words)
        {
            // If the word is not already hidden, hide it and break out of the loop
            if (!word.IsHidden())
            {
                word.Hide();
                break;
            }
        }
    }
    // Define a method to get the rendered text of the scripture
    public string GetRenderedText()
    {
        // Create an empty string to hold the rendered text
        string renderedText = "";
        // Iterate through each word in the list of words
        foreach (Word word in _words)
        {
            // Append the rendered text of the word and a space to the rendered text string
            renderedText += word.GetRenderedText() + " ";
        }
        // Trim any trailing whitespace from the rendered text string and return it
        return renderedText.Trim();
    }
    // Define a method to check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        // Return true if all words in the list of words are hidden, false otherwise
        return _words.All(word => word.IsHidden());
    }
    // Define a method to get the string representation of the reference
    public string GetReference()
    {
        // Call the ToString() method on the reference object and return the result
        return _reference.ToString();
    }
}