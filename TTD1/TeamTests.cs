using System;
using TDD._1;
using xUnit;
using TeamManagement;

namespace TeamManagementTests
{
    public class TeamTests
    {
        [Fact]
        public void TeamMember_Creation_ShouldSetProperties()
        {
            var member = new TeamMember("John Doe", 1);
            Assert.Equal("John Doe", member.Name);
            Assert.Equal(1, member.Id);
        }

        [Fact]
        public void AddTeamMember_ShouldAddMember()
        {
            var team = new Team();
            var member = new TeamMember("Jane Doe", 1);
            team.AddTeamMember(member);

            var allMembers = team.GetAllMembers();
            Assert.Single(allMembers);
            Assert.Equal("Jane Doe", allMembers[0].Name);
        }

        [Fact]
        public void AddTeamMember_ShouldThrowExceptionForDuplicateId()
        {
            var team = new Team();
            var member1 = new TeamMember("Jane Doe", 1);
            var member2 = new TeamMember("John Doe", 1);

            team.AddTeamMember(member1);
            Assert.Throws<Exception>(() => team.AddTeamMember(member2));
        }

        [Fact]
        public void RemoveTeamMember_ShouldRemoveMember()
        {
            var team = new Team();
            var member = new TeamMember("Jane Doe", 1);
            team.AddTeamMember(member);

            team.RemoveTeamMember(1);
            Assert.Empty(team.GetAllMembers());
        }

        [Fact]
        public void RemoveTeamMember_ShouldThrowExceptionIfNotFound()
        {
            var team = new Team();
            Assert.Throws<Exception>(() => team.RemoveTeamMember(1));
        }

        [Fact]
        public void GetAllMembers_ShouldReturnAllMembers()
        {
            var team = new Team();
            team.AddTeamMember(new TeamMember("John Doe", 1));
            team.AddTeamMember(new TeamMember("Jane Doe", 2));

            var allMembers = team.GetAllMembers();
            Assert.Equal(2, allMembers.Count);
        }
    }
}