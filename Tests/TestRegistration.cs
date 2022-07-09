using IntroSE.Kanban.Backend.ServiceLayer;
using System;

namespace Tests
{
    class TestRegistration
    {

        private readonly Service service;

        public TestRegistration(Service service)
        {
            this.service = service;
        }
        public void RunTests()
        {

            Console.WriteLine("Test 1 (creating user)");
            Response res1 = service.Register("morabou1@gmail.com", "Aa1235");
            if (res1.ErrorOccured) 
                Console.WriteLine(res1.ErrorMessage);
            else Console.WriteLine("Created user successfully");
            service.DeleteData();
            /*          
                      Console.WriteLine("Test 2 (unsuccessful creating user)");
                      Response res2 = service.Register("guy@gmail.com", "1235"); //error
                      if (res2.ErrorOccured) Console.WriteLine(res2.ErrorMessage);

                      Console.WriteLine("Test 3(unsuccessful login user)");
                      Response res3 = service.Login("guy@gmail.com", "1234"); //error
                      if (res3.ErrorOccured) Console.WriteLine(res3.ErrorMessage);

                      Console.WriteLine("Test 4 (successful login user)");
                      Response res4 = service.Login("guy@gmail.com", "Aa1235");
                      if (res4.ErrorOccured) Console.WriteLine(res4.ErrorMessage);
                      else Console.WriteLine("logged in successfully");


                      Console.WriteLine("Test 5(unsuccessful login user) ");
                      Response res5 = service.Login("buy@gmail.com", "1235"); //error
                      if (res5.ErrorOccured) Console.WriteLine(res5.ErrorMessage);

                      Console.WriteLine("Test 6 (adding board succsessfuly)");
                      Response res6 = service.AddBoard("guy@gmail.com", "board1");
                      if (res6.ErrorOccured) Console.WriteLine(res6.ErrorMessage);
                      else Console.WriteLine("board added successfully");

                      DateTime dueDate = DateTime.Today.AddDays(1);
                      Console.WriteLine("Test 8 (adding task successfuly)");
                      Response res8 = service.AddTask("guy@gmail.com", "board1", "task1", "description of task1", dueDate);
                      if (res8.ErrorOccured) Console.WriteLine(res8.ErrorMessage);
                      else Console.WriteLine("task1 created successfully");

                      Console.WriteLine("Test 9 (adding task succssefully)");
                      Response res9 = service.AddTask("guy@gmail.com", "board1", "task2", "description of task2", dueDate);
                      if (res9.ErrorOccured) Console.WriteLine(res9.ErrorMessage);
                      else Console.WriteLine("task2 created successfully");

                      Console.WriteLine("Test 7 (limiting column unsuccessfully)");
                      Response res7 = service.LimitColumn("guy@gmail.com", "board1", 0, 1);
                      if (res7.ErrorOccured) Console.WriteLine(res7.ErrorMessage);
                      else Console.WriteLine("board column 0 limited unsuccessfully");


                      Console.WriteLine("Test 10 (uptading duedate succssefully)");
                      Response res10 = service.UpdateTaskDueDate("guy@gmail.com", "board1", 0, 0, dueDate.AddDays(2));
                      if (res10.ErrorOccured) Console.WriteLine(res10.ErrorMessage);
                      else Console.WriteLine("task1 dueDate updated successfully");

                      Console.WriteLine("Test 11 (uptading duedate unsuccssefully)");
                      Response res11 = service.UpdateTaskDueDate("guy@gmail.com", "board1", 0, 0, dueDate.AddDays(-4));
                      if (res11.ErrorOccured) Console.WriteLine(res11.ErrorMessage);
                      else Console.WriteLine("task1 dueDate updated unsuccesfully");

                      Console.WriteLine("Test 12 (adding task unsuccssefully)");
                      Response res12 = service.AddTask("guy@gmail.com", "board1", "task3", null, dueDate);
                      if (res12.ErrorOccured) Console.WriteLine(res12.ErrorMessage);
                      else Console.WriteLine("task1 dueDate updated unsuccesfully");

                      Console.WriteLine("Test 13 (updating task title succseefullly)");
                      Response res13 = service.UpdateTaskTitle("guy@gmail.com", "board1", 0, 0, "taskneew");
                      if (res13.ErrorOccured) Console.WriteLine(res13.ErrorMessage);
                      else Console.WriteLine("succesfully");


                      Console.WriteLine("Test 14 (advancing task succ)");
                      Response res14 = service.AdvanceTask("guy@gmail.com", "board1", 0, 0);
                      if (res14.ErrorOccured) Console.WriteLine(res14.ErrorMessage);
                      else Console.WriteLine(" succesfully");


                      Console.WriteLine("Test 14.5 (limiting column successfully)");
                      Response res145 = service.LimitColumn("guy@gmail.com", "board1", 2, 0);
                      if (res145.ErrorOccured) Console.WriteLine(res145.ErrorMessage);
                      else Console.WriteLine("board column 0 limited successfully");

                      Console.WriteLine("Test 15 (advancing task unsucc)");
                      Response res15 = service.AdvanceTask("guy@gmail.com", "board1", 1, 0);
                      if (res15.ErrorOccured) Console.WriteLine(res15.ErrorMessage);
                      else Console.WriteLine("succesfully");

                      Console.WriteLine("Test 16 (updating task title unsuccseefullly)");
                      Response res16 = service.UpdateTaskTitle("guy@gmail.com", "board1", 1, 0, "taskneew1");
                      if (res16.ErrorOccured) Console.WriteLine(res16.ErrorMessage);
                      else Console.WriteLine("succesfully");

                      Console.WriteLine("Test 17 (advancing task succ)");
                      Response res17 = service.AdvanceTask("guy@gmail.com", "board1", 0, 1);
                      if (res17.ErrorOccured) Console.WriteLine(res17.ErrorMessage);
                      else Console.WriteLine("succesfully");

                      Console.WriteLine("Test 18 (inprogresslist succ)");
                      Response<IList<IntroSE.Kanban.Backend.ServiceLayer.Task>> res18 = service.InProgressTasks("guy@gmail.com");
                      if (res18.ErrorOccured) Console.WriteLine(res18.ErrorMessage);
                      else Console.WriteLine("succesfully" + res18.Value.Count);

                      Response res20 = service.AddBoard("guy@gmail.com", "board2");
                      Response res21 = service.AddTask("guy@gmail.com", "board2", "task3", "description of task1", dueDate);
                      Response res22 = service.AdvanceTask("guy@gmail.com", "board2", 0, 2);
                      Response res23 = service.AdvanceTask("guy@gmail.com", "board2", 1, 2);



                      Console.WriteLine("Test 19 (inprogresslist succ)");
                      Response<IList<IntroSE.Kanban.Backend.ServiceLayer.Task>> res19 = service.InProgressTasks("guy@gmail.com");
                      if (res19.ErrorOccured) Console.WriteLine(res19.ErrorMessage);
                      else Console.WriteLine("succesfully" + res19.Value.Count);

                  }*/
        }
    }
    
}
