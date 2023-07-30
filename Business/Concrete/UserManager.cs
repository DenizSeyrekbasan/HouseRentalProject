using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("kisi eklendi");
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            _userDal.GetAll();
            return new SuccessDataResult<List<User>>(Messages.UserListed);
        }

        public IDataResult<List<User>> GetById(int id)
        {
            _userDal.GetAll(p => p.UserId == id);
            return new SuccessDataResult<List<User>>();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
