using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace hrtest
{
    public class SqlInert
    {

        public static string ProfileInsertmethod()
        {
            return @"INSERT INTO [dbo].[Profile]
           ([Jobname]
           ,[InterviewDate]
           ,[Name]
           ,[sex]
           ,[Birthday]
           ,[Marriage]
           ,[Email]
           ,[Cellphone]
           ,[Address]
           ,[Contector]
           ,[ContectorRelationship]
           ,[ContectorCellphone]
           ,[StillStudy]
           ,[FriendInIs]
           ,[FriednRelationship]
           ,[FriendName]
           ,[CareInJob]
           ,[SalaryWish]
           ,[RegistDate]
           ,[Advanage]
           ,[Disadvantage]
           ,[FirstInIs]
           ,[FutureHope]
           ,[MindManager]
           ,[PromiseFromIs]
           ,[ShowYourSelf]
           ,[Armyitem]
           ,[Armydate]
           ,[Img])
     VALUES
           (@Jobname,
           ,@InterviewDate,
           ,@Name,
           ,@sex,
           ,@Birthday,
           ,@Marriage,
           ,@Email,
           ,@Cellphone,
           ,@Address,
           ,@Contector,
           ,@ContectorRelationship,
           ,@ContectorCellphone,
           ,@StillStudy,
           ,@FriendInIs,
           ,@FriednRelationship,
           ,@FriendName,
           ,@CareInJob,
           ,@SalaryWish,
           ,@RegistDate,
           ,@Advanage,
           ,@Disadvantage,
           ,@FirstInIs,
           ,@FutureHope,
           ,@MindManager,
           ,@PromiseFromIs,
           ,@ShowYourSelf,
           ,@Armyitem,
           ,@Armydate,
           ,@Img)";
        }
    }
}
