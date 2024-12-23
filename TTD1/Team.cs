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
            // Помилка: пропущена перевірка унікальності Id
            members.Add(member);
        }

        public void RemoveTeamMember(int memberId)
        {
            // Помилка: неправильна умова пошуку
            var member = members.FirstOrDefault(m => m.Id != memberId);
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