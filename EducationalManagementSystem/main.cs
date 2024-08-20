using System.IO;
using System.Threading;
namespace EducationalManagementSystem
{  // replace students with the list
    class main
    {  
        private student[] students = new student[] { };
        private instructor[] instructors = new instructor[] { };
        private List<string[]> s = new List<string[]>();
        private List<string[]> i = new List<string[]>();
        private const string user_name = "zeyad";
        private const string password = "123456789";
        public main()
        {
                preprocess();
                Console.WriteLine("Welcome to our Eductional System\n");
                int x = 1;
            // login part start
            security();
            while (x > 0)
                {  
             // login part end         
                      Console.WriteLine("*****************************************");
                    Console.WriteLine("       If you want student system press 1");
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("       If you want instructor system press 2");
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("       To close the system press 0");
                    Console.WriteLine("*****************************************");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (x == 1)
                    {
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("       to add new student press 1 ");
                        Console.WriteLine("****************************************");
                        Console.WriteLine("       to modify student data press 2");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("  to show the data of a student press 3");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("       to delete a student from  press 4");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("          To getback press -1");
                        Console.WriteLine("*****************************************");
                        int choice;
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    if (choice == 1) insert(1);
                    else if (choice == 2) modify(1);
                    else if (choice == 3) show(1);
                    else if (choice == 4) delete(1);
                    else if (choice == -1) continue;
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("    to add new Instuctor press 1");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("    to modify Instructor data press 2");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("    to show the data of a Instructor press 3");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("    to delete a instructor from  press 4");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("          To getback press -1");
                        Console.WriteLine("*****************************************");
                        int choice;
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (choice == 1) insert(2);
                        else if (choice == 2) modify(2);
                        else if (choice == 3) show(2);
                        else if (choice == 4) delete(2);
                        else if (choice == -1) continue;

                    }
                    

                }
            postprocessing1();
            postprocessing2();

        }
        private void insert(int y)
        {
            int id=0;
            string fname="", lname="";
            string profession = "";
            int days_off = 0;
            string[] days_at_college = {};
            int age = 0;
            string gender = "";
            string account = "";
            string email = "";
            if (y == 1)
            {

                decimal gpa=0;
                int year = 0;
                bool fini_aid =false;
                char status='f';
                string[] academic_rec = {};
                string[] extra = {};
                string[] courses_taken = {};
                ReadInputValuesforstudent(
     ref id, ref fname, ref lname, ref profession, ref days_off, ref days_at_college,
     ref age, ref gender, ref account, ref email, ref gpa, ref year, ref fini_aid,
     ref status, out academic_rec, out extra, out courses_taken);
                student s1 = new student(id, fname, lname, profession, days_off, days_at_college, age, gender, account, email, gpa, year, fini_aid, status, academic_rec, extra, courses_taken);
                AddStudent(ref students, s1);
                string st = s1.getdata();
                StreamWriter streamWriter = new StreamWriter("F:\\a.txt",true);
                s.Add(st.Split(','));
                streamWriter.WriteLine($"{st}\n\n\n\n");
                streamWriter.Close();
                postprocessing1();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Insertion is done");
                Console.ResetColor();
                Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                string[] subjects = {};
                ReadInputValuesforinstructor(ref id, ref fname, ref lname, ref profession, ref days_off, ref days_at_college,ref age, ref gender, ref account, ref email, ref subjects);
                instructor ins = new instructor(id, fname, lname, profession, days_off, days_at_college, age, gender, account, email, subjects);
                AddInstructor(ref instructors, ins);
                string st = ins.getdata();
                i.Add(st.Split(','));
                StreamWriter streamWriter = new StreamWriter("F:\\b.txt", true);
                streamWriter.WriteLine($"{st}\n\n\n\n");
                streamWriter.Close();
                postprocessing2();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Insertion is done");
                Console.ResetColor();
                Thread.Sleep(1500);
                Console.Clear();
            }

          
            static void AddStudent(ref student[] array, student element)
            {
                Array.Resize(ref array, array.Length + 1);    // Resize the array
                array[array.Length - 1] = element;    // Append the new value
            }
            static void AddInstructor(ref instructor[] array, instructor element)
            {
                Array.Resize(ref array, array.Length + 1);    // Resize the array
                array[array.Length - 1] = element;    // Append the new value
            }
            static void ReadInputValuesforstudent(
         ref int id, ref string fname, ref string lname, ref string profession, ref int days_off,
         ref string[] days_at_college, ref int age, ref string gender, ref string account,
         ref string email, ref decimal gpa, ref int year, ref bool fini_aid, ref char status,
         out string[] academic_rec, out string[] extra, out string[] courses_taken)
            {
                // Read input values for each variable
                Console.Write("Enter ID: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Enter first name: ");
                fname = Console.ReadLine();

                Console.Write("Enter last name: ");
                lname = Console.ReadLine();

                Console.Write("Enter profession: ");
                profession = Console.ReadLine();

                Console.Write("Enter number of days off: ");
                days_off = int.Parse(Console.ReadLine());

                Console.Write("Enter days at college separated by commas: ");
                days_at_college = Console.ReadLine().Split(',');

                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Enter gender: ");
                gender = Console.ReadLine();

                Console.Write("Enter account: ");
                account = Console.ReadLine();

                Console.Write("Enter email: ");
                email = Console.ReadLine();

                Console.Write("Enter GPA: ");
                gpa = decimal.Parse(Console.ReadLine());

                Console.Write("Enter year: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter whether financial aid has been received (true/false): ");
                fini_aid = bool.Parse(Console.ReadLine());

                Console.Write("Enter status (Single character): ");
                status = char.Parse(Console.ReadLine());

                Console.Write("Enter academic records separated by commas: ");
                academic_rec = Console.ReadLine().Split(',');

                Console.Write("Enter extra-curricular activities separated by commas: ");
                extra = Console.ReadLine().Split(',');

                Console.Write("Enter courses taken separated by commas: ");
                courses_taken = Console.ReadLine().Split(',');
            }





            static void ReadInputValuesforinstructor(
    ref int id, ref string fname, ref string lname, ref string profession, ref int days_off, ref string[] days_at_college,
    ref int age, ref string gender, ref string account, ref string email, ref string[] subjects)
            {
                // Read input values for each variable
                Console.Write("Enter ID: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Enter first name: ");
                fname = Console.ReadLine();

                Console.Write("Enter last name: ");
                lname = Console.ReadLine();

                Console.Write("Enter profession: ");
                profession = Console.ReadLine();

                Console.Write("Enter number of days off: ");
                days_off = int.Parse(Console.ReadLine());

                Console.Write("Enter days at college separated by comma: ");
                days_at_college = Console.ReadLine().Split(',');

                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Enter gender: ");
                gender = Console.ReadLine();

                Console.Write("Enter account: ");
                account = Console.ReadLine();

                Console.Write("Enter email: ");
                email = Console.ReadLine();

                Console.Write("Enter subjects separated by comma: ");
                subjects = Console.ReadLine().Split(',');
            }
        }
        private void modify(int y) {
             string[] AddElementToArray(string[] originalArray, string newElement)
            {
                string[] newArray = new string[originalArray.Length + 1];

                for (int i = 0; i < originalArray.Length; i++)
                {
                    newArray[i] = originalArray[i];
                }

                newArray[newArray.Length - 1] = newElement;

                return newArray;
            }
             string[] DeleteElementFromArray(string[] originalArray, string elementToDelete)
            {
                int deleteIndex = Array.IndexOf(originalArray, elementToDelete);

                if (deleteIndex == -1) // element not found in the array
                {
                    return originalArray;
                }

                string[] newArray = new string[originalArray.Length - 1];

                for (int i = 0, j = 0; i < originalArray.Length; i++)
                {
                    if (i == deleteIndex)
                    {
                        continue;
                    }

                    newArray[j++] = originalArray[i];
                }

                return newArray;
            }
            if (y == 1)
            {
                Console.WriteLine("What is the id of the student ?\n");
                int ident, idx = 0;
                ident = int.Parse(Console.ReadLine());
                bool f = false;
                for (int i = 0; i < s.Count(); i++)
                {
                    if (s[i].Length >= 2)
                    if (s[i][1] == ident.ToString()) { f = true; idx = i; break; }
                }
                if (f == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This student doesnot exist\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Choose from this list\n");
                    Console.WriteLine("to change id press 1\n");
                    Console.WriteLine("to change age  press 2\n");
                    Console.WriteLine("to change account  press 3\n");
                    Console.WriteLine("to change Gpa  press 4\n");
                    Console.WriteLine("to Add daysoff  press 5\n");
                    Console.WriteLine("to change year  press 6\n");
                    Console.WriteLine("to change Financial_aid_status  press 7\n");
                    Console.WriteLine("to change status press 8\n");
                    Console.WriteLine("to add course press 9 \n");
                    Console.WriteLine("to delete course press 10 \n");
                    Console.WriteLine("to add acadimic rec press 11 \n");
                    Console.WriteLine("to delete acadimic rec press 12 \n");
                    int choice;
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choose from them and enter the value");
                    switch (choice)
                    {
                        case 1:
                            int new_id = Convert.ToInt32(Console.ReadLine());
                            s[idx][1] = new_id.ToString();
                            break;
                        case 2:
                            int new_age = Convert.ToInt32(Console.ReadLine());
                            s[idx][5]=new_age.ToString();
                            break;
                        case 3:
                            string new_acc = Console.ReadLine();
                            s[idx][7] = new_acc;
                            break;
                        case 4:
                            decimal new_gpa = Convert.ToDecimal(Console.ReadLine());
                            s[idx][8]=new_gpa.ToString();
                            break;
                        case 5:

                            string r = s[idx][4];
                            int r2 = int.Parse(r);
                            r2++;
                            s[idx][4] = r2.ToString();
                            break;
                        case 6:
                            int new_year = int.Parse(Console.ReadLine());
                            s[idx][9] = new_year.ToString();
                            break;
                        case 7:
                            bool finial_aid = Convert.ToBoolean(Console.ReadLine());
                            if (idx < students.Length)
                            students[idx].modify_fin_ads_status(finial_aid);
                            break;
                        case 8:
                            char new_status = Convert.ToChar(Console.ReadLine());
                            s[idx][10] = new_status.ToString();
                            break;
                        case 9:
                            string new_course = Console.ReadLine();
                            string[] a3 = s[idx][13].Split(',');
                            s[idx][13] = string.Join(',',AddElementToArray(a3, new_course));
                            break;
                        case 10:
                            string tar = Console.ReadLine();
                            string[] aa = s[idx][13].Split(',');
                            s[idx][13] = string.Join(',',DeleteElementFromArray(aa,tar));
                            break;
                        case 11:
                            string new_academic_rec = Console.ReadLine();
                            string []temps=s[idx][11].Split(',');
                            s[idx][11] = String.Join(',', AddElementToArray(temps, new_academic_rec));
                            break;
                        case 12:
                            string tar_academic_rec = Console.ReadLine();
                            string[] temps2 = s[idx][11].Split(',');
                            s[idx][11] = String.Join(',', DeleteElementFromArray(temps2, tar_academic_rec));
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                    postprocessing1();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Modifiction on student is Done ...");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("What is the id of the Instructor ?\n");
                int ident, idx = 0;
                ident = int.Parse(Console.ReadLine());
                bool f = false;
                for (int j = 0; j < i.Count(); j++)
                {
                    if (i[j].Length>=2)
                    if (i[j][1] == ident.ToString()) { f = true; idx = j; break; }
                }
                if (f == false) { 
                   Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This instructor doesnot exist\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Choose from this list\n");
                    Console.WriteLine("to change id press 1\n");
                    Console.WriteLine("to change age  press 2\n");
                    Console.WriteLine("to change account  press 3\n");
                    Console.WriteLine("to change current pos press 4\n");
                    Console.WriteLine("to Add daysoff  press 5\n");
                    Console.WriteLine("to add subject press 6 \n");
                    Console.WriteLine("to delete subject press 7 \n");
                    int choice;
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            int new_id = Convert.ToInt32(Console.ReadLine());
                            i[idx][1] = new_id.ToString();
                            break;
                        case 2:
                            int new_age = Convert.ToInt32(Console.ReadLine());
                            i[idx][5]=new_age.ToString();
                            break;
                        case 3:
                            string new_acc = Console.ReadLine();
                            i[idx][7]=new_acc.ToString();
                            break;
                        case 4:
                            string yy = Console.ReadLine();
                            i[idx][8] = yy;
                            break;
                        case 5:
                            instructors[idx].add_dayoff();
                            i[idx][3] = instructors[idx].get_daysoff().ToString();
                            break;
                        case 6:
                            string subject = Console.ReadLine();
                            string[] a = i[idx][9].Split(',');
                            i[idx][9]=string.Join(',',AddElementToArray(a, subject));
                            break;
                        case 7:
                            string tar = Console.ReadLine();
                            string[] a2 = i[idx][9].Split(',');
                            i[idx][9] = string.Join(',',DeleteElementFromArray(a2, tar));
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                    postprocessing2();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Modifiction on instructor is Done ...");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                    
                }
            }
        
        }
        private void show(int y)
        {
            if (y==1)
            {
                Console.WriteLine("What is the id of the student ?\n");
                int ident, idx = 0;
                ident = int.Parse(Console.ReadLine());
                bool f = false;
                for (int i = 0; i <s.Count(); i++)
                {
                    if (s[i].Length >= 2)
                    if (s[i][1] == ident.ToString()) { f = true; idx = i; break; }
                }
                if (f == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This student doesnot exist\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else {
                    templateforstudent(s[idx][0], s[idx][1], s[idx][3], s[idx][4], s[idx][5], s[idx][6], s[idx][7], s[idx][8], s[idx][9],s[idx][11], s[idx][13]);
                    Console.WriteLine("To continue press any key...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {

                Console.WriteLine("What is the id of the Instructor ?\n");
                int ident, idx = 0;
                ident = int.Parse(Console.ReadLine());
                bool f = false;
                for (int j = 0; j < i.Count(); j++)
                {
                    if (i[j].Length >= 2)
                        if (i[j][1] == ident.ToString()) { f = true; idx = j; break; }
                }
                if (f == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This instructor doesnot exist\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else {
                    templateforinstructor(i[idx][0], i[idx][1], i[idx][3],i[idx][4],i[idx][5], i[idx][6], i[idx][7], i[idx][8],i[idx][9]);
                    Console.WriteLine("To continue press any key...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        private void preprocess()
        {
            StreamReader st = new StreamReader("F:\\a.txt");
            string std="";
            string temp = st.ReadLine();
            while(temp!=null)
            {
                std = temp;
                s.Add(std.Split(','));
                std = "";
                temp = st.ReadLine();
            }
            st.Close();
            StreamReader ins = new StreamReader("F:\\b.txt");
             std = "";
            temp = ins.ReadLine();
            while (temp != null)
            {
                std = temp;
                i.Add(std.Split(','));
                std = "";
                temp = ins.ReadLine();
            }
            ins.Close();
        }
        private void security()
        {
            while (true)
            {
                Console.WriteLine("Please enter email and password");
                Console.Write("Email :");
                string u = Console.ReadLine();
                Console.Write("Password :");
                string p = Console.ReadLine();
                if (u != user_name || p != password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong email or password try again..\n\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                else break;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login successfully ! , Hello Zeyad");
            Console.ResetColor();
        }
        private void templateforstudent(string name , string id , string daysoff,string daysatcollege,string age ,string gender,string account,string gpa,string year, string academic_rec, string courses)
        {
            Console.WriteLine($"The name of student is {name}\n id = {id}\n number of days off = {daysoff}\n the attandance days is ({daysatcollege})\n age = {age}\n gender is {gender}\n account is {account}\n gpa = {gpa} \n his year is {year}\n his acadimic rec is { academic_rec}\n course is {courses}");
        }
        private void templateforinstructor(string name, string id, string daysoff, string daysatcollege, string age, string gender, string account, string curjob, string courses)
        {
            Console.WriteLine($"The name of student is {name}\n"
                + $"id is {id}\n" +
                $"daysoff is {daysoff}\n" +
                $"the attandance days is {daysatcollege}\n" +
                $"age is {age}\n" +
                $"gender is {gender}\n" +
                $"account is {account}\n" +
                $"curjob is {curjob}\n" +
                $"course teached by the instructor is {courses}");
        }
        void postprocessing1()
        {
            string filePath = "F:\\a.txt";
            File.WriteAllText(filePath, string.Empty);
            List<string> lines = new List<string>();
            foreach (string[] stringArray in s)
            {
                string line = string.Join(",", stringArray);
                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);
        }
        void postprocessing2()
        {
            string filePath = "F:\\b.txt";
            File.WriteAllText(filePath, string.Empty);
            List<string> lines2 = new List<string>();
            foreach (string[] stringArray in i)
            {
                string line = string.Join(",", stringArray);
                lines2.Add(line);
            }
            File.WriteAllLines(filePath, lines2);
        }
        void delete(int y)
        {
            
            if (y == 1)
            {
                Console.WriteLine("What is the id of the student ?\n");
                int ident, idx = 0;
                ident = int.Parse(Console.ReadLine());
                bool f = false;
                for (int i = 0; i < s.Count(); i++)
                {
                    if (s[i].Length >= 2)
                        if (s[i][1] == ident.ToString()) { f = true; idx = i; break; }
                }
                if (f == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This student doesnot exist\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    s.Remove(s[idx]);
                    Console.WriteLine("Deletion is complete...");
                    Console.ResetColor();
                    postprocessing1();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("What is the id of the Instructor ?\n");
                int ident, idx = 0;
                ident = int.Parse(Console.ReadLine());
                bool f = false;
                for (int j = 0; j < i.Count(); j++)
                {
                    if (i[j].Length >= 2)
                        if (i[j][1] == ident.ToString()) { f = true; idx = j; break; }
                }
                if (f == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This instructor doesnot exist\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    i.Remove(i[idx]);
                    Console.WriteLine("Deletion is complete...");
                    Console.ResetColor();
                    postprocessing2();
                    Thread.Sleep(1500);
                    Console.Clear();

                }
            }
        }
    }
}
