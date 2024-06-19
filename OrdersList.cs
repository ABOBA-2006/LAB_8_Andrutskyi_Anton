namespace Lab8;

public class OrderList: IManipulations<Order>, ISeeker<Order>
{
    private readonly List<Order> _listOfOrders = new();
    
    public void Add(Order item)
    {
        if(_listOfOrders.Contains(item))
        {
            throw new ArgumentException("There is already this dish in list, just edit it!");
        }
        
        _listOfOrders.Add(item);
        item.UsingCounter++;
    }
    public void Delete(Order item)
    {
        if (item.UsingCounter <= 1)
        {
            _listOfOrders.Remove(item);
        }
        else
        {
            throw new ArgumentException("This dish is used in other lists!");
        }
    }
    public Order Change(Order dish)
    {
        if (_listOfOrders.Contains(dish))
        {
            return dish;
        }

        throw new ArgumentException("There is no such order in this list!");
    }
    
    public List<Order> Seek(string keyWord)
    {
        List<Order> possibleOrder = new();
        
        foreach (var order in _listOfOrders)
        {
            bool isFound = false;
            
            foreach (var dish in order.ListOfDishes.ListOfDishes)
            {
                if (!isFound)
                {
                    if (dish.Name.Contains(keyWord))
                    {
                        possibleOrder.Add(order);
                        isFound = true;
                    }
                }
            }
        }

        return possibleOrder;
    }
}