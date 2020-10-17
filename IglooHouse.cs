class IGLOO : HouseBuilder
{
    private House house; 
    public IGLOO()
    {
        this.house = new House();
    }
    public void BuildFloor()
    {
        house.SetFloor("igloo floor");
    }
    public void BuildBody()
    {
        house.SetdBody("igloo body");
    }
    public void BuildRoof()
    {
        house.SetRoof("igloo roof");
    }

    public House GetHouse()
    {
        return this.house;
    }
}