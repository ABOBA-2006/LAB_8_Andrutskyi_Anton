namespace Lab8;

public class Dish(string name, float price, IngredientsList listOfIngredients, float timeToCook)
{
    public int UsingCounter = 0;
    public float Price => price;
    public string Name => name;
    
    public void EditName(string editName)
    {
        name = editName;
    }
    
    public void EditPrice(float editPrice)
    {
        if (editPrice > 0)
        {
            price = editPrice;
        }
        else
        {
            throw new Exception("Price must be more than 0!");
        }
    }

    public IngredientsList EditListOfIngredients()
    {
        return listOfIngredients;
    }
    
    public void EditTimeToCook(float editTime)
    {
        if (editTime > 0)
        {
            timeToCook = editTime;
        }
        else
        {
            throw new Exception("Time must be more than 0!");
        }
    }
    
    public string ShowInfo()
    {
        string textOutput = "";
        
        textOutput += "\nName: " + name + ", price: " + price + " (UAH)\n";
        textOutput += "List of ingredients for dish:\n";
        textOutput += listOfIngredients.WriteAllIngredients();
        textOutput += "Time to cook: " + timeToCook + " minutes\n";

        return textOutput;
    }
}