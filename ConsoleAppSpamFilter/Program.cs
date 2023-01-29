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

string ClearFromSpam(string text, string[] stopWords)
{
    for (int i = 0; i < stopWords.Length; i++)
    {
        text = text.Replace(stopWords[i], new string('*',stopWords[i].Length));
    }

    return text;
}

void SaveText (string text, string fileName)
{
    StreamWriter writer = new StreamWriter(fileName);
    writer.Write(text);
    writer.Close();
}

string[] stopWords = null;
string text;

stopWords = LoadStopWords("stopList.txt");
text = LoadText("text.txt");

string cleanText = ClearFromSpam(text,stopWords);

SaveText(cleanText, "CleanText.txt");

Console.WriteLine("Файл очищен и сохранен");