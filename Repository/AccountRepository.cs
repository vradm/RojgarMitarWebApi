﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
//using System.Web.Http;
using RojgarMitraWebApi.BusinessModel;
using RojgarMitraWebApi.BusinessModel.UnitOfWork;
using RojgarMitraWebApi.DBManager;
using RojgarMitraWebApi.IRepository;
using System.Transactions;
namespace RojgarMitraWebApi.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly _UnitOfWork _unitofwork;
        private readonly RojgarMitraEntities _Context;
        public AccountRepository(RojgarMitraEntities context)
        {
            _unitofwork = new _UnitOfWork();
            this._Context = context;

        }


        public AccountModel UserLogin(string EmailID, string Password)
        {
            try
            {

                var objUserRes = SpHelper<AccountModel>.GetListWithRawSql("Sp_LoginCheck @Emaild,@passWord",
                    new SqlParameter { ParameterName = "@Emaild", DbType = DbType.String, Value = EmailID },
                    new SqlParameter { ParameterName = "@passWord", DbType = DbType.String, Value = Password }).FirstOrDefault();

                return objUserRes;
            }

            catch (Exception ex)
            {
            }
            return null;
        }
        public UserLoginInfoModel GetUserInfo(int UserID)
        {
            try
            {
                var objCrd = _unitofwork.UserMastersRepository.GetSingle(x => x.UserID == UserID && x.Active == true);

                if (objCrd != null)
                {

                    var objUserInfo = new UserLoginInfoModel
                    {
                        EmailID = objCrd.EmailID,
                        Role = objCrd.Role,
                        UserID = objCrd.UserID,
                    };
                    return objUserInfo;
                }
            }
            catch { }
            return null;
        }
        public ResponseModel SavePersonalDetails(UserRegistartionPersonalDetailsModel model)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel.data = Guid.NewGuid().ToString() + model.Resume;
            object obj = new object();obj = responseModel.data;
            try
            {

                using (var scope = new TransactionScope())
                {
                    var objuser = new DBManager.UserMaster
                    {
                        FullName = model.FullName,
                        EmailID = model.EmailID,
                        Password = model.Password,
                        MobileNumber = model.MobileNumber,
                        TotalExYear = model.TotalExYear,
                        Gender = model.Gender,
                        Resume = obj.ToString(),
                        Active = true,
                        CreatedDate = DateTime.Now,
                        Role = "User",
                        Extension = model.Extension


                    };
                    _unitofwork.UserMastersRepository.Insert(objuser);
                    _unitofwork.Save();
                    scope.Complete();
                    responseModel.message = "Succuess";
                    responseModel.id = objuser.UserID;
                    responseModel.status = true;
                    return responseModel;
                }

            }
            catch (Exception ex)
            {
                responseModel.status = false;
                responseModel.message = ex.Message;
            }
            return responseModel;

        }
        public ResponseModel SaveEmploymentDetails(UserRegistrationEmployeMentModel model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                using (var scope = new TransactionScope())
                {


                    var objuser = new DBManager.UserEmployementDetail
                    {
                        UserID = model.UserID,
                        CurrentDesignation = model.CurrentDesignation,
                        CurrentCompany = model.CurrentCompany,
                        CurrentLocationID = model.CurrentLocationID,
                        AnnualSalaryInlakhs = model.AnnualSalaryInlakhs,
                        AnnualSalaryInThousand = model.AnnualSalaryInThousand,
                        WorkingSinceYear = model.WorkingSinceYear,
                        WotkingSinceMonth = model.WotkingSinceMonth,
                        CreatedDate = DateTime.Now,
                        Active = true,
                        OutSideIndia = model.OutSideIndia,
                        NoticePeriod = model.NoticePeriod,
                        ServeNoticePeriod = model.ServeNoticePeriod
                        //Role = "User"
                    };
                    _unitofwork.UserEmployementDetailRepository.Insert(objuser);
                    _unitofwork.Save();
                    scope.Complete();
                    responseModel.id = objuser.UserID;
                    responseModel.status = true;
                    responseModel.data = objuser.ID;
                    responseModel.message = "succuess";
                    return responseModel;
                }

            }
            catch (Exception ex)
            {
                responseModel.status = false;

                responseModel.message = ex.Message;
            }
            return responseModel;

        }
        public ResponseModel SaveEducationDetails(UserRegistrationEducationModel model)
        {
            ResponseModel responseModel = new ResponseModel();
           
            responseModel.data = Guid.NewGuid().ToString() + model.ProfileImage;
            object obj = new object(); obj = responseModel.data;
            try
            {
                using (var scope = new TransactionScope())
                {


                    var objuser = new DBManager.UserEducationDetail
                    {
                        UserId = model.UserId,
                        ProfileImage = obj.ToString(),
                        HighestQualification = model.HighestQualification,
                        Course = model.Course,
                        CourseType = model.CourseType,
                        University_College = model.University_College,
                        PassingYear = model.PassingYear,
                        ProfessionalExperience = model.ProfessionalExperience,
                        createdDate = DateTime.Now,
                        IsActive = true,
                        Specialization = model.Specialization,

                    };
                    _unitofwork.UserEducationDetailRepository.Insert(objuser);
                    _unitofwork.Save();
                    scope.Complete();
                    responseModel.id = objuser.UserId;
                    responseModel.message = "Succuess";
                    responseModel.status = true;
                    return responseModel;
                }

            }
            catch (Exception ex)
            {
                responseModel.status = false;
                responseModel.message = ex.Message;
            }
            return responseModel;
        }
    }
}