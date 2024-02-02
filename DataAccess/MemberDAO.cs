using System;
using BusinessObject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> MemberList = new List<Member>()
        {
            new Member{MemberID = 1, MemberName = "Ngo Ba Dung", Email = "nbdung0000@gmail.com", Password = "123456", City = "Ha Noi", Country = "Viet Nam" },
            new Member{MemberID = 2, MemberName = "Nguyen Bao Phi", Email = "nbphi@gmail.com", Password = "123456", City = "Thanh Hoa", Country = "Viet Nam"},
            new Member{MemberID = 3, MemberName = "Alex Nguyen", Email = "alexnn@gmail.com", Password = "123123", City = "New York", Country = "US"},
            new Member{MemberID = 4, MemberName = "Hoang Quoc Viet", Email = "hqviet@gmail.com", Password = "123123", City = "Nghe An", Country = "Viet Nam"},
            new Member{MemberID = 5, MemberName = "Nguyen Van Giang Minh", Email = "nvgminh@gmail.com", Password = "123123", City = "Ha Noi", Country = "Viet Nam"},
            new Member{MemberID = 6,    MemberName = "John Smith", Email = "johnsmith@example.com", Password = "123456",
    City = "Boston",
    Country = "United States"
  },

  new Member{
    MemberID = 7,
    MemberName = "Mary Johnson",
    Email = "mary@example.com",
    Password = "654321",
    City = "Chicago",
    Country = "United States"
  },

  new Member{
    MemberID = 8,
    MemberName = "Bob Williams",
    Email = "bob.williams@example.com",
    Password = "123abc",
    City = "Atlanta",
    Country = "United States"
  },
  new Member{
  MemberID = 11,
  MemberName = "Robert Brown",
  Email = "robertbrown@example.com",
  Password = "13579",
  City = "Chicago",
  Country = "United States"
}
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        public MemberDAO()
        {

        }
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

        public List<Member> GetMembers() => MemberList;

        public Member GetMemberByID(int mId)
        {
            Member member = MemberList.SingleOrDefault(mem => mem.MemberID == mId);
            return member;
        }

        public Member GetMemberByEmail(string email)
        {
            Member member = MemberList.SingleOrDefault(mem => mem.Email == email);
            return member;
        }

        public void AddNew(Member member)
        {
            Member mem = GetMemberByID(member.MemberID);
            Member mem1 = GetMemberByEmail(member.Email);
            if (mem == null  && mem1 == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exits.");
            }
        }

        public void Update(Member member)
        {
            Member mem = GetMemberByID(member.MemberID);
            if (mem != null)
            {
                var index = MemberList.IndexOf(mem);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exits.");
            }
        }

        public void Remove(int mId)
        {
            Member mem = GetMemberByID(mId);
            if (mem != null)
            {
                MemberList.Remove(mem);
            }
            else
            {
                throw new Exception("Member does not already exits.");
            }
        }

        public bool CheckLogin(string email, string password)
        {
            return MemberList.Any(x =>
                x.Email.ToLower() == email.ToLower() &&
                x.Password == password
            );
        }
    }
}
