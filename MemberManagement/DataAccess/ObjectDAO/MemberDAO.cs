using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagement.DataAccess.ObjectDAO
{
    public class MemberDAO
    {

        private MemberDAO()
        {
        }

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetMemberList()
        {
            var members = new List<Member>();
            try
            {
                using var context = new FStoreDBContext();
                members = context.Members.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }


        public List<Member> GetList()
        {
            var members = new List<Member>();
            try
            {
                using var context = new FStoreDBContext();
                members = context.Members.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }



        public Member GetMemberById(int memberId)
        {
            Member member = null;

            try
            {
                using var context = new FStoreDBContext();
                member = context.Members.SingleOrDefault(c => c.MemberId == memberId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return member;
        }

        public void AddNew(Member member)
        {
            try
            {
                Member mem = GetMemberById(member.MemberId);
                if (mem == null)
                {
                    using var context = new FStoreDBContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The mem does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void UpdateMember(Member member)
        {
            try
            {
                Member mem = GetMemberById(member.MemberId);
               
                if(mem != null)
                {
                    using var context = new FStoreDBContext();
                    context.Members.Update(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void RemoveMember(int memberId)
        {
            try
            {
                Member member = GetMemberById(memberId);
                if (member != null)
                {
                    using var context = new FStoreDBContext();
                    context.Members.Remove(member);
                    
                }
                else
                {
                    throw new Exception("Member dose not already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public Member Login(string email, string password)
        {
            IEnumerable<Member> members = GetMemberList();
            Member member = members.SingleOrDefault(mb => mb.Email.Equals(email) && mb.Password.Equals(password));
            return member;
        }

        public IEnumerable<Member> SearchMember(string id)
        {
            IEnumerable<Member> searchResult = null;
            IEnumerable<Member> members = GetMemberList();

            var memberSearch = from member in members
                               where member.MemberId.Equals(id)
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }
    }
}
