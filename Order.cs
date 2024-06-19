namespace Lab8;

public class Order(DishesList listOfDishes, int tableNumber)
{
    private int _amountOfDishes  = listOfDishes.ContTotalAmount();
    private float _totalPrice = listOfDishes.CountTotalPrice();
    public DishesList ListOfDishes => listOfDishes;
    public int UsingCounter = 0;
    
    public void EditTableNumber(int editTableNumber)
    {
        tableNumber = editTableNumber;
    }
    public DishesList EditListOfDishes()
    {
        return listOfDishes;
    }
    public string ShowInfo()
    {
        _amountOfDishes = listOfDishes.ContTotalAmount();
        _totalPrice = listOfDishes.CountTotalPrice();
        string textOutput = "";
        
        textOutput += "\nTableNumber: " + tableNumber + ", amount of dishes: " + _amountOfDishes +"\n";
        textOutput += "List of dishes for this order:\n";
        textOutput += listOfDishes.WriteAllDishes();
        textOutput += "Total price: " + _totalPrice + " (UAH)\n";

        return textOutput;
    }
}