namespace EducationalManagementSystem
{
    class student : member
    {
        private decimal Gpa;
        private int year;
        private bool Financial_aid_status;
        private char status;
        private string[] Academic_record;
        private string[] Extracurricular_activities;
        private string[] courses_taken;
        // constructor
        public student(int id, string fname, string lname, string profession, int daysoff, string[] days_at_college, int age, string gender, string account,string email
            ,decimal gpa, int year, bool finiancial_aid, char status, string[] academic_rec, string[] extra
            , string[] courses_taken)
      : base(id, fname, lname, profession, daysoff, days_at_college, age, gender, account,email)
        {
            this.year = year;
            this.Financial_aid_status = finiancial_aid;
            this.status = status;
            this.Extracurricular_activities = extra;
            this.Gpa = gpa;
            this.Academic_record = academic_rec;
            this.courses_taken = courses_taken;
        }
        // some getters
        public decimal get_gpa() => this.Gpa;
        public char get_statut() => this.status;
        public string[] get_academic_rec() => this.Academic_record;
        public int get_year() => this.year;
        public string get_financial_aid_status() => (this.Financial_aid_status ? "All fees are paid" : "There are fees has not payed");
        public string[] get_record() => Academic_record;
        public string[] get_Extracurricular_activities() => Extracurricular_activities;
        public string[] get_courses_taken() => courses_taken;
        public void add_course(string course) => courses_taken.Append(course);
        public void add_academic_rec(string rec) =>Academic_record.Append(rec);
        public override void erase(string[] arr, string name) => base.erase(arr,name);
        public void add_Extracurricular_activities(string act) => Extracurricular_activities.Append(act);
        public override int get_id() => base.get_id();
        public override int get_age() => base.get_age();
        public override int get_daysoff() => base.get_daysoff();
        public override string get_fname() => base.get_fname();
        public override string get_gender() => base.get_gender();
        public override string get_account() => base.get_account();
        public override string get_email() => base.get_email();
        public override string get_profession() => base.get_profession();
        public override string[] get_days() => base.get_days();
        public void modify_gpa(decimal gpa) => this.Gpa = gpa;
        public void modify_status(char c) => this.status = c;
        public override void modify_id(int newid)
        {
            // Custom implementation for modify_id in the derived class
            base.modify_id(newid); // Call the base implementation if necessary
        }

        public override void modify_fname(string newfname)
        {
            // Custom implementation for modify_fname in the derived class
            base.modify_fname(newfname); // Call the base implementation if necessary
        }

        public override void modify_lname(string newlname)
        {
            // Custom implementation for modify_lname in the derived class
            base.modify_lname(newlname); // Call the base implementation if necessary
        }

        public override void modify_age(int newage)
        {
            // Custom implementation for modify_age in the derived class
            base.modify_age(newage); // Call the base implementation if necessary
        }

        public override void modify_gender(string newgender)
        {
            // Custom implementation for modify_gender in the derived class
            base.modify_gender(newgender); // Call the base implementation if necessary
        }

        public override void modify_account(string newaccount)
        {
            // Custom implementation for modify_account in the derived class
            base.modify_account(newaccount); // Call the base implementation if necessary
        }

        public override void modify_profession(string newpprofession)
        {
            // Custom implementation for modify_profession in the derived class
            base.modify_profession(newpprofession); // Call the base implementation if necessary
        }
        public void modify_fin_ads_status(bool F) => this.Financial_aid_status = F;
        public override string ToString()
        {
            return base.ToString() + $"The Gpa is {Gpa}\n" +
                $"The year of the student is {year}\n" +
                $"The status of the stduent is {status}\n" +
                $"The financial aid status of the student is {get_financial_aid_status()}\n" +
                $"Academic record is {string.Join(" , ", Academic_record)}\n" +
                $"the Extracurricular activities is {string.Join(" , ", Extracurricular_activities)}\n" +
                $"The list of courses of this student is {string.Join(" , ", courses_taken)}\n";   
        }
        public override string getdata()
        {
            return base.getdata() + $"{Gpa},{year},{status},({string.Join("-", Academic_record)}),({string.Join("-", Extracurricular_activities)}),({string.Join("-", courses_taken)})";
        }
    }
}
