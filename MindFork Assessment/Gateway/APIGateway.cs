using Dapper;
using Microsoft.IdentityModel.Protocols;
using MindFork_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MindFork_Assessment.Gateway
{
    public class APIGateway : Connection
    {
        public IEnumerable<UserDataModel> GetUsers()
        {
            try
            {
                DBConnection.Open();

                var result = DBConnection
                    .Query<UserDataModel>
                    (
                    sql: @"SELECT * FROM Users",
                    commandType: CommandType.Text
                    );

                return result;

            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                DBConnection.Close();
            }
        }

        public IEnumerable<BlogFeedbackDataModel> GetBlogFeedBack(int index, int count)
        {
            try
            {
                DBConnection.Open();

                var result = DBConnection
                    .Query<BlogFeedbackDataModel>
                    (
                    sql: @"USP_BlogFeedback " + index + "," + count,
                    commandType: CommandType.Text
                    );

                return result;

            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                DBConnection.Close();
            }
        }
    }
}
