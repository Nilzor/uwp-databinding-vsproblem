using System;
using Csla;

namespace UwpApp
{
    [Serializable]
    public sealed class Customer : BusinessBase<Customer>
    {
        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
        public string Name
        {
            get { return GetProperty(NameProperty); }
            set { SetProperty(NameProperty, value); }
        }

        public static readonly PropertyInfo<int> AgeProperty = RegisterProperty<int>(c => c.Age);
        public int Age
        {
            get { return GetProperty(AgeProperty); }
            set { SetProperty(AgeProperty, value); }
        }

        public static readonly PropertyInfo<DateTime?> DateOfDeathProperty = RegisterProperty<DateTime?>(c => c.DateOfDeath);
        public DateTime? DateOfDeath
        {
            get { return GetProperty(DateOfDeathProperty); }
            set { SetProperty(DateOfDeathProperty, value); }
        }
    }
}
