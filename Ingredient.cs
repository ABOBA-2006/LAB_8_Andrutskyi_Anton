namespace Lab8;

public class Ingredient(string name, float weight)
{
    public string Name => name;
    public float Weight => weight;
    
    public int UsingCounter = 0;

    public void EditName(string editName)
    {
        name = editName;
    }
    public void EditWeight(float editWeight)
    {
        if (editWeight > 0)
        {
            weight = editWeight;
        }
        else
        {
            throw new ArgumentException("Weight must be more than 0!");
        }
    }
}