using Lab8;

namespace Program;

abstract class Program()
{
    static void Main()
    {
        Ingredient apple = new Ingredient("Apple", 120);
        Ingredient potato = new Ingredient("Potato", 1000);

        apple.EditName("Antonovka");
        apple.EditWeight(400);

        IngredientsList ingredientsList = new IngredientsList();
        ingredientsList.Add(apple);
        ingredientsList.Add(potato);

        ingredientsList.Change(apple).EditName("Green Apple");
       
        ingredientsList.WriteAllIngredients();
        Console.WriteLine(apple.Name);

        Dish appleWithPotato = new Dish("Apple bakes with Potato", 150, ingredientsList, 60);
        appleWithPotato.EditName("Apple bakes with sliced potato");
        appleWithPotato.EditListOfIngredients().Change(potato).EditWeight(350);
        appleWithPotato.EditPrice(200);
        appleWithPotato.EditTimeToCook(50);
        
        appleWithPotato.ShowInfo();
        
        // second dish 
        Ingredient bread = new Ingredient("Dark Bread", 40);
        Ingredient butter = new Ingredient("Butter 50%", 20);
        Ingredient salt = new Ingredient("Sea Salt", 3);

        IngredientsList ingredientsList2 = new IngredientsList();
        ingredientsList2.Add(bread);
        ingredientsList2.Add(butter);
        ingredientsList2.Add(salt);

        Dish butik = new Dish("Butik with butter and salt", 20, ingredientsList2, 2);

        DishesList dishesList = new DishesList();
        dishesList.Add(butik);
        dishesList.Add(appleWithPotato);

        Order order1 = new Order(dishesList, 1);
        order1.ShowInfo();

        Ingredient salmon = new Ingredient("Sea salmon", 1000);
        Ingredient oil = new Ingredient("Oil", 100);

        IngredientsList ingredientsList3 = new IngredientsList();
        ingredientsList3.Add(salmon);
        ingredientsList3.Add(oil);

        Dish friedSalmon = new Dish("Salmon fried with a lot of oil", 200, ingredientsList3, 40);

        DishesList dishesList2 = new DishesList();
        dishesList2.Add(friedSalmon);

        Order order2 = new Order(dishesList2, 2);

        OrderList orderList = new OrderList();
        orderList.Add(order1);
        orderList.Add(order2);
        
        orderList.Seek("with");
        ingredientsList.Seek("a");
    }
}