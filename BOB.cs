class BOB
{
    private HouseBuilder housebuilder;
    public BOB(HouseBuilder housebuilder)
    {
        this.housebuilder = housebuilder;
    }

    public void constract()
    {
        housebuilder.BuildFloor();
        housebuilder.BuildBody();
        housebuilder.BuildRoof();
        System.Console.WriteLine("done");
    }

    public House GetHouse()
    {
        System.Console.WriteLine("deliver.");
        return this.housebuilder.GetHouse();
    }
}