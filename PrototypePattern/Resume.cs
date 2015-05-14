using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Resume:ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        private readonly List<WorkExperience> _workExperience=new List<WorkExperience>();

        public void AddWorkExperience(WorkExperience experience)
        {
            _workExperience.Add(experience);
        }

        public void ResetWorkExperience()
        {
            _workExperience.Clear();
        }

        public Resume(string name)
        {
            this.Name = name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("{0},{1},{2}", Name, Sex, Age);
            foreach (var experience in _workExperience)
            {
                Console.WriteLine("Work Experience：{0},{1}", experience.WorkDate.ToString(),
                    experience.Company);
            }
        }
    }
}
