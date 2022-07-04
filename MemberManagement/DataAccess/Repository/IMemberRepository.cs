using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<Member> GetMemebers();
        public List<Member> GetList();
        Member GetMemberById(int memberId);
        void AddMember(Member member);
        void DeleteMember(int memberId);
        void UpdateMember(Member member);

        Member Login(string username, string password);

        public IEnumerable<Member> Search(string id);
    }
}
