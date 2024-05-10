public class Word
{
private string _text;
private bool _isHidden;

public Word(string text)
{
    _text=text;

    
}
public void Hide()
{

 _text = new string('_', _text.Length);

}
public void Show()
{
    
}
public bool IsHidden()
{
    return true;
}
public string GetDisplayText()
{
    return _text;
}
}