
public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;
    private static readonly Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        List<Word> hiddenCandidates = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && hiddenCandidates.Count > 0; i++)
        {
            int index = _random.Next(hiddenCandidates.Count);
            hiddenCandidates[index].Hide();
            hiddenCandidates.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordsText}";
    }
}
