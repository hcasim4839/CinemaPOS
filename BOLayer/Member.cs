using DALayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Member: Customer
    {
        
        private string _phoneNum;
        private string _points;

        public Member(string name, string phoneNum )
        {
           
            base.Name = name;
            _phoneNum = phoneNum;
        }
        public Member(string phoneNum)
        {
            _phoneNum = phoneNum;
        }
        public bool AddPoints(int points)
        {
            return DALayer_AddPoints(points);
        }

        private bool DALayer_AddPoints(int points)
        {
            MemberDAO mDAO = new MemberDAO();
            MemberDTO mDTO = new MemberDTO();

            mDTO.Points = points;
            mDTO.PhoneNumber = _phoneNum;
            bool pointsAdded = mDAO.addPoints(mDTO);

            return pointsAdded; 
        }
        public bool removePoints(int points)
        {
            return DALayer_RemovePoints(points);
        }

        private bool DALayer_RemovePoints(int points)
        {
            MemberDAO mDAO = new MemberDAO();
            MemberDTO mDTO = new MemberDTO();

            mDTO.Points = points;
            mDTO.PhoneNumber = _phoneNum;
            bool pointsAdded = mDAO.removePoints(mDTO);

            return pointsAdded;
        }

        public override bool Delete()
        {
            return DALayer_Delete();
        }

        public override bool Insert()
        {
            return DALayer_Insert();
        }

        protected override bool DALayer_Delete()
        {
            MemberDAO mDAO = new MemberDAO();
            MemberDTO mDTO = new MemberDTO();

            mDTO.PhoneNumber = _phoneNum;
            bool isDeleted = mDAO.Delete(mDTO);

            return isDeleted;
        }

        protected override bool DALayer_Insert()
        {
            MemberDAO mDAO = new MemberDAO();
            MemberDTO mDTO = new MemberDTO();

            mDTO.PhoneNumber = _phoneNum;
            mDTO.Name = base.Name;
            mDTO.Points = 0;
            bool isInserted = mDAO.Insert(mDTO);

            return isInserted;
        }

        public MemberDTO Select()
        {
            return DALayer_Select();
        }

        private  MemberDTO DALayer_Select()
        {
            MemberDAO mDAO = new MemberDAO();
            MemberDTO mDTO = new MemberDTO();
            mDTO.PhoneNumber = _phoneNum;

            return mDAO.Select(mDTO);
        }
    }
}
