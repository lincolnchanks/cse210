class User
{
    private int _userPoints;

    public int GetUserScore()
    {
        return _userPoints;
    }
    public void AwardPoints(int awardedPoints)
    {
        _userPoints += awardedPoints;
    }
}