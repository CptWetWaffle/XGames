public class State
{
    public string HorizonalState { get; set; }
    public string VerticalState { get; set; }
    public bool HasChangedHorizontal { get; set; }
    public bool HasChangedVertical { get; set; }

    public State()
    {
        HorizonalState = "Center";
        VerticalState = "Middle";
    }
}
