namespace CSI120_Lecture13
{
    internal class Program
    {
        // Hoang Khoi Gia Nguyen
        // CSI 120 - Computer Programming 1
        // Lecture 13 Notes

        // Array
        // Create array FoodItem with a size of 5

        static FoodItem[] foodItems = new FoodItem[5];


        static void Main(string[] args)
        {
            Preload();

            FoodItem kiwi = new FoodItem("Kiwi", 1, 42);

            //DoubleArraySize();

            try
            {
                AddNewFoodItem(kiwi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            foreach (FoodItem singleFoodItem in foodItems)
            {
                if (singleFoodItem != null)
                {
                    Console.WriteLine(singleFoodItem.DisplayFoodInformation());

                }
            }
        }// Main

        

        public static void DoubleArraySizeExample()
        {
            int ogArraySize = foodItems.Length;

            Console.WriteLine($"Original Array size: {foodItems.Length}");
            DoubleArraySize();

            int doubleArraySize = ogArraySize * 2;
            bool isArraySizeDoubled = doubleArraySize == foodItems.Length;

            if (isArraySizeDoubled)
            {
                Console.WriteLine("Doubled");
                foreach (FoodItem singleItem in foodItems)
                {
                    // How do we prevent a null exception error
                    // Check to see if something is not null

                    if (singleItem != null)
                    {

                        Console.WriteLine(singleItem.DisplayFoodInformation());

                    }
                    else
                    {
                        Console.WriteLine("404");
                    }
                }
            }
            else
            {
                Console.WriteLine("Not doubled");
            }



        }

        public static void AddNewFoodItem(FoodItem newFoodItem)
        {
            // Loop through my FoodIteam Array
            // Check for an empty spot
            // If yes, add to space
            // Else return error (No Space Found)

            for (int i = 0; i < foodItems.Length; i++)
            {
                // Check for an empty spot
                if(foodItems[i] == null)
                {
                    // If yes, add to space
                    foodItems[i] = newFoodItem;
                    // Can use the return in a method that is void to leave the method
                    return;

                }

            }

            // Throw a new exception
            throw new Exception("No more room in array");
        }

       

        // DoubleArraySize()
        public static void DoubleArraySize()
        {
            int arraySize = foodItems.Length;
            int newSize = arraySize * 2;

            FoodItem[] tempArray = new FoodItem[newSize];

            for (int i = 0; i < foodItems.Length; i++)
            {
                tempArray[i] = foodItems[i];
            }

            foodItems = tempArray;

        }

        public static void Preload()
        {
            foodItems[0] = new FoodItem("Apple", 7, 95);

            foodItems[1] = new FoodItem("Banana", 4, 105);

            foodItems[2] = new FoodItem("Chicken Breast", 8, 165);

            foodItems[3] = new FoodItem("Broccoli", 5, 55);

            foodItems[4] = new FoodItem("Almonds", 7, 70);

            foodItems[0] = new FoodItem("Apple", 7, 95);

        }

        public static void DisplayFoodTable()
        {
            foreach (FoodItem singleItem in foodItems)
            {
                Console.WriteLine(singleItem.DisplayFoodInformation());
            }
        }

        public static void ClassMethodExample()
        {
            // FoodItem() = DefaultConstructor
            // NewConstructor = FoodItem(string, double, double)
            FoodItem apple = new FoodItem("Apple", 7, 95);
            FoodItem noValue = new FoodItem();

            // FoodItem
            // Name
            // Qty
            // Calories


            Console.WriteLine(apple.DisplayFoodInformation());

        }


        // Talk about throwing exceptions
        // Class Methods
        // Arrays

    }// Class

    // Creating Class
    // access modifier class keyword name (starts with uppercase, and is singular)

    public class FoodItem
    {
        // Field
        public string Name;
        public double Qty;
        public double Calories;

        // Constructors
        // Name of Class
        public FoodItem(string name, double qty, double calories)
        {
            // Fields = arguments
            Name = name;
            Qty = qty;
            Calories = calories;

        }// FoodItem

        // Overloading methods
        // Allows naming similar methods the same name, but different parameters

        public FoodItem()
        {
            Name = "Unknown";
            Qty = 1;
            Calories = 0;
        }


        // Methods
        // Total Calories: Return Qty * Calories
        public double TotalCalories()
        {
            return Qty * Calories;
        }

        // Display Data
        // Name | Qty | Calories | Total Calories
        public string DisplayFoodInformation()
        {
            return $"{Name} | {Qty} | {Calories} | {TotalCalories()}";
        }

    }// Food Class

}//Name
