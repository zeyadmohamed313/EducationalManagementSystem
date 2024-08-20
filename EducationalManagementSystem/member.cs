namespace EducationalManagementSystem
{
    abstract class member
    {
        // first char is small because its private
        private int id;
        private string fname;
        private string lname;
        private string profession;
        private int daysoff;
        private string[] days_at_college;
        private int age;
        private string gender;
        private string account;
        private string email;
        public member(int id, string fname, string lname, string profession, int daysoff, string[] days_at_college, int age, string gender, string account, string email)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.profession = profession;
            this.daysoff = daysoff;
            this.days_at_college = days_at_college;
            this.age = age;
            this.gender = gender;
            this.account = account;
            this.email = email;
        }

        // access only to derived classes

        // getters
        public virtual int get_daysoff() => this.daysoff;
        public virtual string get_email() => this.email;
        public virtual int get_age() => this.age;
        public virtual string get_gender() => this.gender;
        public virtual int get_id() => this.id;
        public virtual string get_fname() => this.fname;
        public virtual string get_lname() => this.lname;
        public virtual string get_profession() => this.profession;
        public virtual string get_account() => this.account;
        public virtual string[] get_days() => this.days_at_college;
        // modification
        public virtual void modify_id(int newid) => this.id = newid;
        public virtual void modify_fname(string newfname) => this.fname = newfname;
        public virtual void modify_lname(string newlname) => this.lname = newlname;
        public virtual void modify_age(int newage) => this.age = newage;
        public virtual void modify_gender(string newgender) => this.gender = newgender;
        public virtual void modify_account(string newaccount) => this.account = newaccount;
        public virtual void modify_profession(string newpprofession) => this.profession = newpprofession;
        // the member take a dayoff
        public virtual void add_dayoff() => this.daysoff++;
        // modify the courses list 
        public virtual void add_day(string day) => days_at_college.Append(day);
        public virtual void erase(string[] arr, string name)
        {
            int indx = Array.IndexOf(arr, name);
            if (indx != -1)
            {
                string[] newday = new string[arr.Length - 1];
                Array.Copy(arr, 0, newday, 0, indx);
                Array.Copy(arr, indx + 1, newday, indx, arr.Length - 1);
                arr = newday;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("the course has been removed...");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are trying to delete an unexsist course");
                Console.ResetColor();
            }
        }
        public override string ToString()
        {
            return $"Name is {fname+lname}\n" +
                $"Id is {id}\n" +
                $"Profession is {profession}\n" +
                $"Number of daysoff is {daysoff}\n" +
                $"the attendance day is { string.Join(" , ", days_at_college) }\n" +
                $"Age is {age}\n" +
                $"Gender is {gender}\n" +
                $"Account is {account}\n";
        }
        public virtual string getdata()
        {
            string a = string.Join('-', days_at_college);
            return $"{fname + lname},{id},{profession},{daysoff},({a}),{age},{gender},{account}";
        }
    }
}
