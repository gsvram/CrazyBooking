using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooking.Model
{
    public enum AgeRatingType
    {
        [Description("Universal")]
        Universal,
        [Description("Parental Guidance")]
        ParentalGuidance,
        [Description("12+ Allowed")]
        Year12,
        [Description("12+ Allowed with adult")]
        Year12PlusAudlt,
        [Description("15+ Allowed")]
        Year15Plus,
        [Description("18+ Allowed")]
        Year18Plus
        
    }
}
