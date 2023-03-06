using System;

public class ScriptureReference
    {
        private int _startChapter;
        private int _startVerse;
        private int _endChapter;
        private int _endVerse;

        public ScriptureReference(string reference)
        {
            /* The constructor parses a scripture reference string (e.g. "John 3:16" or "Proverbs 3:5-6")
            into its component parts (start chapter, start verse, end chapter, end verse).*/
            string[] parts = reference.Split(':');
            string bookName = parts[0];
            string[] verses = parts[1].Split('-');
            _startChapter = int.Parse(verses[0].Split('.')[0]);
            _startVerse = int.Parse(verses[0].Split('.')[1]);
            if (verses.Length > 1)
            {
                _endChapter = int.Parse(verses[1].Split('.')[0]);
                _endVerse = int.Parse(verses[1].Split('.')[1]);
            }
            else
            {
                _endChapter = _startChapter;
                _endVerse = _startVerse;
            }
        }

        public bool IsSingleVerse()
        {
            // The IsSingleVerse method checks if the scripture reference refers to a single verse.
            return _startChapter == _endChapter && _startVerse == _endVerse;
        }

        public int GetStartChapter()
        {
            // The GetStartChapter method returns the start chapter number of the scripture reference.
            return _startChapter;
        }

        public int GetStartVerse()
        {
            // The GetStartVerse method returns the start verse number of the scripture reference.
            return _startVerse;
        }

        public int GetEndChapter()
        {
            return _endChapter;
        }

        public int GetEndVerse()
        {
            return _endVerse;
        }
    }