using CommonInterface;

namespace CustomerModelViewControler
{
    internal sealed class CustomerView : ICustomerView
    {
        public int ID { get; private set; }
        public string PersonalNum { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal TotalDebt { get; set; }
        public string Note { get; set; }

        public CustomerView(int id_, string personalNum_, string name_, string lastName_, decimal totalDebt_, string notes_)
        {
            this.ID = id_;
            this.PersonalNum = personalNum_;
            this.Name = name_;
            this.LastName = lastName_;
            this.TotalDebt = totalDebt_;
            this.Note = notes_;
        }

        //overring Object.GetHashCode() and Object.Equals(object obj)
        //since there's a high probability for this class of being used in hashing/comparison scenarios

        public override int GetHashCode()
        {
            return this.ID.GetHashCode(); //only immutable field available - Microsoft's Hash algorithm should be broad enough to avoid collisions here
        }

        public override bool Equals(object obj)
        {
            CustomerView ex = obj as CustomerView; //comparing for object equality, higher probability of uniqueness first
            return !(ex == null ||
                ex.ID == this.ID ||
                ex.PersonalNum == this.PersonalNum ||
                ex.TotalDebt == this.TotalDebt ||
                ex.Name == this.Name ||
                ex.LastName == this.LastName ||
                ex.Note == this.Note);
        }
    }
}