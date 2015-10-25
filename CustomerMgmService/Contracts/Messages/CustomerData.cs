using System.Runtime.Serialization;

namespace CustomerMgmService.Contracts.Messages
{
    [DataContract]
    public sealed class CustomerData
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string PersonalNum { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public decimal TotalDebt { get; set; }
        [DataMember]
        public string Note { get; set; }

        public CustomerData(int id_, string personalNum_, string name_, string lastName_, decimal totalDebt_, string notes_)
        {
            this.ID = id_;
            this.PersonalNum = personalNum_;
            this.Name = name_;
            this.LastName = lastName_;
            this.TotalDebt = totalDebt_;
            this.Note = notes_;
        }
    }
}