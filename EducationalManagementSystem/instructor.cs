namespace EducationalManagementSystem
{
    class instructor : member
    {
        private string[] subjects;
        private int idx = 0;
        private string[] jobs = { "Teaching assist"};
        private string cur_job;
        public instructor(int id, string fname, string lname, string profession, int daysoff, string[] days_at_college, int age, string gender, string account, string email,string[] subjects) : base(id, fname, lname, profession, daysoff, days_at_college, age, gender, account, email)
        {
            this.cur_job = jobs[0];
            this.subjects = subjects;
        }
        public void add_subject(string sub) => subjects.Append(sub);
        public void permotion() => this.cur_job = jobs[++idx];
        public string get_pos() => this.cur_job;
        public string[] get_sub() => this.subjects;
        public override string get_email() => base.get_email();
        public override int get_id() => base.get_id();
        public override int get_age() => base.get_age();
        public override int get_daysoff() => base.get_daysoff();
        public override string get_fname() => base.get_fname();
        public override string get_gender() => base.get_gender();
        public override string get_account() => base.get_account();
        public override string get_profession() => base.get_profession();
        public override string[] get_days() => base.get_days();
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
        public override string ToString()
        {
            return base.ToString() + $"\n role is {this.cur_job} \n" +
                $" the subject which {this.get_fname()} teaches is {string.Join(" , ", subjects)}\n";
        }
        public override string getdata()
        {
            return base.getdata()+$",{cur_job},{string.Join(" - ", subjects)}";
        }
    }
}
