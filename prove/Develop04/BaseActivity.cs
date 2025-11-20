class BaseActivity
{
    string _name = "";
    string _description = "";
    int _duration;

    public BaseActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
}