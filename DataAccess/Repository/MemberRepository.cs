using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        void IMemberRepository.DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);

        Member IMemberRepository.GetMemberByID(int memberId) => MemberDAO.Instance.GetMemberByID(memberId);

        IEnumerable<Member> IMemberRepository.GetMembers() => MemberDAO.Instance.GetMembers();

        void IMemberRepository.InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

        void IMemberRepository.UpdateMember(Member member) => MemberDAO.Instance.Update(member);
    }
}
