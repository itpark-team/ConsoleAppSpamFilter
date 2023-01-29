string[] LoadStopWords(string fileName) 
{
    string[] stopWords;

    StreamReader reader = new StreamReader(fileName);

    int lenght = int.Parse(reader.ReadLine());

    stopWords = new string[lenght];

    for (int i = 0; i < stopWords.Length; i++) 
    {
        stopWords[i] = reader.ReadLine();
    }

    reader.Close();

    return stopWords;
}

string LoadText(string fileName)
{
    string text;

    StreamReader reader = new StreamReader(fileName);

    text = reader.ReadToEnd();

    reader.Close();

    return text;
}

string[] stopWords = null;
string text;

stopWords = LoadStopWords("stopList.txt");
text = LoadText("text.txt");