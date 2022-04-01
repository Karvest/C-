using MovieStore.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Classes
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        TypeOfSubscription Subscription { get; set; }

    }
}
