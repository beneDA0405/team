using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagement
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public TeamMember(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}