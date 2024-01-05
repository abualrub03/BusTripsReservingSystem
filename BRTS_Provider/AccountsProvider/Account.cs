using Interfaces;
using Entities;
using System;
using Microsoft.Data.SqlClient;
using Interfaces;
using Microsoft.AspNetCore.Http;
using ViewModels.UserViewModels;
namespace BRTS_Providers.AccountProvider
{
    public class Account : CoreLayer.Disposable, IAccount
    {
        public int AddingNewImage (IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                using (var imageStream = imageFile.OpenReadStream())
                {
                    Entities.Images image = new Entities.Images();
                    long imageLength = imageFile.Length;
                    byte[] imageData = new byte[imageLength];
                    int bytesRead = imageStream.Read(imageData, 0, (int)imageLength);
                    if (bytesRead != imageLength)
                    {
                        return -1;
                    }
                    image.ImageData = imageData;
                    image.ImageName = imageFile.FileName;
                    image.ImageContentType = imageFile.ContentType;
                    using (var DAL = new DataAccess.DataAccessLayer())
                    {
                        DAL.Parameters = new List<SqlParameter> {
                                new SqlParameter{ ParameterName = "@ImageData", Value =  image.ImageData },
                                new SqlParameter{ ParameterName = "@ImageName", Value = image.ImageName},
                                new SqlParameter{ ParameterName = "@ImageContentType", Value =  image.ImageContentType },

                            };
                        return DAL.ExecuteReader<ImageIdSignUp>("spInsertNewImageAndReturnId").FirstOrDefault().ImageId;
                       
                    }


                }
            }
            else
            {
                return -1;
            }
        }
        public bool SignUpNewAccount(IFormFile imageFile , Entities.Account Account)
        {
            using (var DAL = new DataAccess.DataAccessLayer())
            {
                DAL.Parameters = new List<SqlParameter> {
                    new SqlParameter{ ParameterName = "@lastName", Value =  Account.lastName },
                    new SqlParameter{ ParameterName = "@firstName", Value =  Account.firstName},
                    new SqlParameter{ ParameterName = "@Age", Value =  Account.Age },
                    new SqlParameter{ ParameterName = "@role", Value =  Account.role},
                    new SqlParameter{ ParameterName = "@emailAddress", Value =  Account.emailAddress},
                    new SqlParameter{ ParameterName = "@phoneNumber", Value =   Account.phoneNumber},
                    new SqlParameter{ ParameterName = "@gender", Value =   Account.gender},
                    new SqlParameter{ ParameterName = "@userName", Value = Account.userName  },
                    new SqlParameter{ ParameterName = "@password", Value =  Account.password},
                    new SqlParameter { ParameterName = "@imageId", Value = AddingNewImage(imageFile)},
                    new SqlParameter { ParameterName = "@status", Value =  "Pending"},
                };
                return  DAL.ExecuteNonQuery("spInsertIntoTblAccounts");
            }
        }
        public ViewModels.UserViewModels.SignInViewModel SignInRequest(Entities.Account Account)
        {
            
            using (var DAL = new DataAccess.DataAccessLayer())
            {
                DAL.Parameters = new List<SqlParameter> {
                            new SqlParameter{ ParameterName = "@emailAddress", Value =  Account.emailAddress},
                            new SqlParameter{ ParameterName = "@password", Value =  Account.password},
                };

                return DAL.ExecuteReader<ViewModels.UserViewModels.SignInViewModel>("spSignInRequest").FirstOrDefault();


            }
        }
        public ViewModels.UserViewModels.CheckingStatusRequestViewModel StatusChecking(Entities.Account Account)
        {
            using (var DAL = new DataAccess.DataAccessLayer())
            {
                DAL.Parameters = new List<SqlParameter> {
                            new SqlParameter{ ParameterName = "@emailAddress", Value =  Account.emailAddress},
                            new SqlParameter{ ParameterName = "@password", Value =  Account.password},
                };
                return DAL.ExecuteReader<ViewModels.UserViewModels.CheckingStatusRequestViewModel>("spChecckingStatus").FirstOrDefault();
            }
        }
        public List<Entities.Account> getAllAccounts()
        {
            using var DAL = new DataAccess.DataAccessLayer();
            return DAL.ExecuteReader<Entities.Account>("spSelectAllTblAccounts");
        }
    }
}
