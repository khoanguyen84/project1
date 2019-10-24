using DAL.Interface;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public int AddUser(User user)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserName", user.UserName);
                parameters.Add("@UserMobile", user.UserMobile);
                parameters.Add("@UserEmail", user.UserEmail);
                parameters.Add("@FaceBookUrl", user.FaceBookUrl);
                parameters.Add("@LinkedInUrl", user.LinkedInUrl);
                parameters.Add("@TwitterUrl", user.TwitterUrl);
                parameters.Add("@PersonalWebUrl", user.PersonalWebUrl);
                parameters.Add("@CountryId", user.CountryId);
                parameters.Add("@JobId", user.JobId);
                parameters.Add("@DOB", user.DOB);
                var id = SqlMapper.ExecuteScalar<int>(con, "AddUser", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool DeleteUser(int userId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserId", userId);
            SqlMapper.Execute(con, "DeleteUser", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IList<UserView> GetAllUser()
        {
            IList<UserView> customerList = SqlMapper.Query<UserView>(con, "GetAllUsers", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public User GetUserById(int userId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserId", userId);
                return SqlMapper.Query<User>((SqlConnection)con, "GetUserById", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserId", user.UserId);
                parameters.Add("@UserName", user.UserName);
                parameters.Add("@UserMobile", user.UserMobile);
                parameters.Add("@UserEmail", user.UserEmail);
                parameters.Add("@FaceBookUrl", user.FaceBookUrl);
                parameters.Add("@LinkedInUrl", user.LinkedInUrl);
                parameters.Add("@TwitterUrl", user.TwitterUrl);
                parameters.Add("@PersonalWebUrl", user.PersonalWebUrl);
                parameters.Add("@Avatar", user.Avatar);
                SqlMapper.Execute(con, "UpdateUser", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
