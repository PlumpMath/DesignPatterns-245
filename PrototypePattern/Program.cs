using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        //Intent: Specify the kinds of objects to create using a prototypical instance, 
        //        and create new objects by copying this prototype.
        static void Main(string[] args)
        {
            var peter = new Resume("Peter")
            {
                Age = 25,
                Sex = "Male",
            };
            peter.AddWorkExperience(new WorkExperience {Company = "Apple", WorkDate = new YearRange{StartYear =1995,EndYear = 2000}});
            peter.AddWorkExperience(new WorkExperience { Company = "Oracle", WorkDate = new YearRange { StartYear = 2001, EndYear = 2014 } });

            var jasmine = (Resume)peter.Clone();
            jasmine.Name = "Jasmine";
            jasmine.Sex = "Female";
            jasmine.ResetWorkExperience();
            jasmine.AddWorkExperience(new WorkExperience { Company = "Google", WorkDate = new YearRange { StartYear = 1996, EndYear = 2001 } });
            jasmine.AddWorkExperience(new WorkExperience { Company = "Microsoft", WorkDate = new YearRange { StartYear = 2002, EndYear = 2015 } });


            peter.Display();
            jasmine.Display();

        }
    }
}
