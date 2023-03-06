using System;

// This class represents a scripture, including the reference (e.g. John 3:16) and the text of the scripture.
public class Scripture
    {
        // Private fields for the reference and text of the scripture.
        private string _reference;
        private string _text;
        private List<string> hiddenWords;

        // Constructor that takes the reference and text of the scripture as parameters.
        public Scripture(string reference, string text)
        {
            // The constructor initializes the reference, text, and list of hidden words for a new scripture.
            _reference = reference;
            _text = text;
            hiddenWords = new List<string>();
        }
        
        // Getter for the reference field.
        public string GetReference()
        {
            // The GetReference method returns the reference of the scripture.
            return _reference;
        }
        
        // Getter for the text field.
        public string GetText()
        {
            // The GetText method returns the text of the scripture with hidden words.
            string displayedText = _text;
            foreach (string word in hiddenWords)
            {
                displayedText = displayedText.Replace(word, new string('_', word.Length));
            }
            return displayedText;
        }

        public bool IsComplete()
        {
            // The IsComplete method checks if all words in the scripture have been hidden.
            return hiddenWords.Count == GetWords().Count;
        }

        // Method to hide a specified number of random words in the scripture.
        public void HideRandomWord()
        {
            // The HideRandomWord method hides a random word in the scripture by adding it to the list of hidden words.
            List<string> words = GetWords();
            // Create a random number generator.
            Random rand = new Random();
            int index = rand.Next(words.Count);
            hiddenWords.Add(words[index]);
        }

        private List<string> GetWords()
        {
            // The GetWords method returns a list of all words in the scripture.
            return new List<string>(_text.Split(' '));
        }
    }