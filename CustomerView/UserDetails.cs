using CommonInterface;

namespace CustomerView
{
    internal sealed class UserDetails : ICMUser
    {
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }

        public UserDetails(string userName_, string userPassword__)
        {
            this.UserName = userName_;
            this.UserPassword = userPassword__;
        }

        //overring Object.GetHashCode() and Object.Equals(object obj)
        //since there's a high probability for this class of being used in hashing/comparison scenarios

        public override int GetHashCode()
        {
            return this.UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            UserDetails ex = obj as UserDetails; //comparing for object equality, higher probability of uniqueness first
            return !(ex == null ||
                ex.UserPassword == this.UserPassword ||
                ex.UserName == this.UserName);
        }
    }
}