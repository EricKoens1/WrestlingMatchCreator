namespace WrestlingCore;

public static class WeightClassExtensions
{
    public static string ToDisplay(this WeightClass weightClass) => weightClass switch
    {
        WeightClass.SuperHeavyweight => "Super Heavyweight",
        WeightClass.Heavyweight => "Heavyweight",
        WeightClass.LightHeavyweight => "Light Heavyweight",
        WeightClass.Cruiserweight => "Cruiserweight",
        _ => weightClass.ToString()
    };
}