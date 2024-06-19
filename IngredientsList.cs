namespace Lab8;

public class IngredientsList: IManipulations<Ingredient>, ISeeker<Ingredient>
{
    private readonly List<Ingredient> _listOfIngredients = new();

    private bool IsTheSame(Ingredient item2)
    {
        foreach (var item in _listOfIngredients)
        {
            if (item.Name == item2.Name && Math.Abs(item.Weight - item2.Weight) < 0.00001)
            {
                return true;
            }
        }
        return false;
    }
    public void Add(Ingredient item)
    {
        if(_listOfIngredients.Contains(item) || IsTheSame(item))
        {
            throw new ArgumentException("There is already this ingredient in list, just edit it!");
        }
        
        _listOfIngredients.Add(item);
        item.UsingCounter++;
    }

    public void Delete(Ingredient item)
    {
        if (item.UsingCounter <= 1)
        {
            _listOfIngredients.Remove(item);
        }
        else
        {
            throw new ArgumentException("This ingredient is used in other lists!");
        }
    }
    
    public Ingredient Change(Ingredient ingredient)
    {
        if (_listOfIngredients.Contains(ingredient))
        {
            return ingredient;
        }

        throw new ArgumentException("There is no such ingredient in this list!");
    }
    
    public string WriteAllIngredients()
    {
        string textOutput = "";
        
        int index = 1;
        foreach (var ingredient in _listOfIngredients)
        { 
            textOutput += index + ") Name: " + ingredient.Name + ", weight: " + ingredient.Weight + " (g)\n"; 
            index++;
        }

        return textOutput;
    }

    public List<Ingredient> Seek(string keyWord)
    {
        List<Ingredient> possibleIngredients = new();
        
        foreach (var ingredient in _listOfIngredients)
        {
            if (ingredient.Name.Contains(keyWord))
            {
                possibleIngredients.Add(ingredient);
            }
        }

        return possibleIngredients;
    }
}