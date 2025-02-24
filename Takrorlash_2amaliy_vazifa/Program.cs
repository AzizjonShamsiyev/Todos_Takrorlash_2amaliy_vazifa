try
{   
    List<string> todos = new List<string>();
    List<string> finishedTodos = new List<string>();

    while (true)
    {
        Console.Write(
        "0.Dasturni yopish\n" +
        "1.Yangi vazifa qo'shish\n" +
        "2.Vazifani o'chirish\n" +
        "3.Bajarilgan vazifani belgilash\n" +
        "4.Bajarilgan vazifalarni ko'rish\n" +
        "5.Bajarilmagan vazifalarni ko'rish\n" +
        "Tanlang : " );

        int option = int.Parse(Console.ReadLine());

        if (option == 0) 
            break;

        switch (option)
        {
            case 1: 
                Console.WriteLine("Vazifani yozing : "); 
                todos.Add(Console.ReadLine()); 
                Console.WriteLine("Vazifa muvaffaqiyatli qo'shildi!");
                break;
            case 2:
                Console.Write("Vazifa raqamini kiriting : ");
                todos.RemoveAt(int.Parse(Console.ReadLine()));
                Console.WriteLine("Vazifa muvaffaqiyatli o'chirildi!");
                break;
            case 3:
                Console.Write("Vazifa raqamini kiriting : ");
                int index = int.Parse(Console.ReadLine());
                finishedTodos.Add(todos[index]);
                todos.RemoveAt(index);
                Console.WriteLine("Vazifani bajarganingiz bilan tabriklayman!");
                break;
            case 4:
                foreach (var item in finishedTodos)
                {
                    Console.WriteLine(item);
                }
                break;
            case 5:
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine(i + " . " + todos[i]);
                }
                break;            
        }
        Console.WriteLine("-------------------------------------------------------------");

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
