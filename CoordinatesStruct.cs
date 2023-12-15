namespace chess1;
struct Coordinates
{
    public string coord;
    public Coordinates(string inputCoordinates)
    {
        coord = inputCoordinates;
    }
    public Letters ReturnsLetterCoordinate()
    {
        //char letter = coord[0];
        Enum.TryParse(coord[0].ToString(), out Letters letterCoord);
        return letterCoord;
    }
    public int ReturnsNumberCoordinate()
    {
        //int number = coord[1];
        int.TryParse(coord[1].ToString(), out int numberCoord);
        return numberCoord;
    }
}
