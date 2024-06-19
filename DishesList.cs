namespace Lab8;

public class DishesList: IManipulations<Dish>
{
    private readonly List<Dish> _listOfDishes = new();

    public List<Dish> ListOfDishes => _listOfDishes;

    private bool IsTheSame(Dish item2)
    {
        foreach (var item in _listOfDishes)
        {
            if (item.Name == item2.Name && Math.Abs(item.Price - item2.Price) < 0.00001)
            {
                return true;
            }
        }
        return false;
    }
    public void Add(Dish item)
    {
        if(_listOfDishes.Contains(item) || IsTheSame(item))
        {
            throw new ArgumentException("There is already this dish in list, just edit it!");
        }
        
        _listOfDishes.Add(item);
        item.UsingCounter++;
    }
    
    public void Delete(Dish item)
    {
        if (item.UsingCounter <= 1)
        {
            _listOfDishes.Remove(item);
        }
        else
        {
            throw new ArgumentException("This dish is used in other lists!");
        }
    }
    
    public Dish Change(Dish dish)
    {
        if (_listOfDishes.Contains(dish))
        {
            return dish;
        }

        throw new ArgumentException("There is no such dish in this list!");
    }

    public float CountTotalPrice()
    {
        float sum = 0;
        foreach (var dish in _listOfDishes)
        {
            sum += dish.Price;
        }

        return sum;
    }

    public int ContTotalAmount()
    {
        return _listOfDishes.Count;
    }
    
    public string WriteAllDishes()
    {
        string textOutput = "";
        
        int index = 1;
        foreach (var dish in _listOfDishes)
        {
            textOutput += index + ") Name: " + dish.Name + ", price: " + dish.Price + " (UAH)\n";
            index++;
        }

        return textOutput;
    }
}