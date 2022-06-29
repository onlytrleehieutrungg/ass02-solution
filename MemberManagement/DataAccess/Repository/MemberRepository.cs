using MemberManagement.DataAccess.ObjectDAO;
using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(Member member) => MemberDAO.Instance.AddNew(member);

        public void DeleteMember(int memberId) => MemberDAO.Instance.RemoveMember(memberId);

        public Member GetMemberById(int memberId) => MemberDAO.Instance.GetMemberById(memberId);

        public IEnumerable<Member> GetMemebers() => MemberDAO.Instance.GetMemberList();

        public Member Login(string username, string password) => MemberDAO.Instance.Login(username, password);

        public IEnumerable<Member> Search(string id) => MemberDAO.Instance.SearchMember(id);
        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
    }
}
