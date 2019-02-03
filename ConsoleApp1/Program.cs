// using System.Security.Cryptography.X509Certificates;

public class TodoList {
    
    string[] tasks = new string[10];
    int taskCount = 0;
    public void AddTask() {
         if (taskCount < tasks.Length) {
         Console.Write("Enter a task: ");
        string task = Console.ReadLine();
        tasks[taskCount] = task;
        taskCount++;
            
         } else {
             Console.WriteLine("Task list is full.");
        }
        
    }
    public void ViewTasks(){
            Console.WriteLine("Task List:");
            for (int i = 0; i < taskCount; i++) {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
           
        }
    public void CompleteTask(){
        Console.Write("Enter the task number to complete: ");
        int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
        if (taskNumber >= 0 && taskNumber < taskCount) {
            tasks[taskNumber] = null;
            for (int i = taskNumber; i < taskCount - 1; i++) {
                tasks[i] = tasks[i + 1];
            }
            taskCount--;
            Console.WriteLine("Task completed.");
        } else {
            Console.WriteLine("Invalid task number.");
        }


     
    }   
    public static void Main(string[] args) {
        TodoList todoList = new TodoList();
        while (true) {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    todoList.AddTask();
                    break;
                case 2:
                    todoList.ViewTasks();
                    break;
                case 3:
                    todoList.CompleteTask();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
   
