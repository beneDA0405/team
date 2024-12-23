using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TeamManagement
{
    public class Team
    {
        private List<TeamMember> members = new List<TeamMember>();

        public void AddTeamMember(TeamMember member)
        {
            if (members.Any(m => m.Id == member.Id)) // Додана перевірка унікальності Id
                throw new Exception("Member with the same Id already exists.");
            members.Add(member);
        }

        public void RemoveTeamMember(int memberId)
        {
            var member = members.FirstOrDefault(m => m.Id == memberId); // Виправлена умова пошуку
            if (member == null)
                throw new Exception("Member not found.");
            members.Remove(member);
        }

        public List<TeamMember> GetAllMembers()
        {
            // Помилка: повертається оригінальний список, а не копія
            return members;
        }
    }
}