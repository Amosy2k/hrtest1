using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace hrtest
{
    public class SqlLink
    {
        public static string linkmethod()
        {
            return ConfigurationManager.ConnectionStrings["User"].ConnectionString;
        }
    }

    public class SqlSelect
    {
        public static string LoginSelectmethod()
        {
            return @"Select * from [user] where UserName=@username and Password=@password";
        }
        public static string GrantLoadlocalusermethod()
        {
            return @"Select username, active from [user] where UserName=@username";
        }

        public static string GrantLoadAllusermethod()
        {
            return @"Select username, active from [user]";
        }

        public static string UserCheckmethod()
        {
            return @"select count(username) from [user] where username = @username";
        }

        public static string UserDataInterviewEducationmethod()
        {
            return @"SELECT [SchoolName],[Department],[DateStart],[DateEnd],[Graduate],[Note] 
            FROM[dbo].[Education] WHERE[ID] = 0";
        }
        public static string UserDataInterviewExperiencemethod()
        {
            return @"SELECT [CompanyName],[Title],[DateStart],[DateEnd],[SatartSalary],[EndSalary],[LeaveReason]
            FROM [dbo].[Experience] WHERE [ID] = 0";
        }
        public static string UserDataInterviewLanguagemethod()
        {
            return @"SELECT [Language],[Listen],[Speak],[Read],[Write]
             FROM [dbo].[Language] WHERE [ID] = 0";
        }
    }
    public class SqlInsert
    {

        public static string ProfileInsertmethod()
        {
            return @"INSERT INTO[dbo].[Profile]
           ([Jobname],[InterviewDate],[Name],[sex],[Birthday],[Marriage],[Email],[Mobile],[Address],[Contector],[ContectorRelationship]
           ,[ContectorMobile],[StillStudy],[FriendInCompany],[FriednRelationship],[FriendName],[CareInwork],[WishSalary],[RegistDate]
           ,[Advanage],[Disadvantage],[FirstInIs],[FutureHope],[MindManager],[PromiseFromIs],[ShowYourSelf],[Armydate],[NonArmyReason],[Img],[LastUpdatetime])
     OUTPUT inserted.ID
     VALUES
           (@Jobname,@InterviewDate,@Name,@sex,@Birthday,@Marriage,@Email,@Mobile,@Address,@Contector,@ContectorRelationship
           ,@ContectorMobile,@StillStudy,@FriendInCompany,@FriednRelationship,@FriendName,@CareInwork,@WishSalary,@RegistDate
           ,@Advanage,@Disadvantage,@FirstInIs,@FutureHope,@MindManager,@PromiseFromIs,@ShowYourSelf,@Armydate,@NonArmyReason,@Img,@LastUpdatetime)";
        }
        public static string EducationInsertmethod()
        {
            return @"INSERT INTO [dbo].[Education]
           ([ID],[SchoolName],[Department],[DateStart],[DateEnd],[Graduate],[Note])
     VALUES
           (@ID,@SchoolName,@Department,@DateStart,@DateEnd,@Graduate,@Note)";
        }

        public static string ExpressInsertmethod()
        {
            return @"INSERT INTO [dbo].[Experience]
           ([ID],[CompanyName],[Title],[DateStart],[DateEnd],[SatartSalary],[EndSalary],[LeaveReason])
     VALUES
           (@ID,@CompanyName,@Title,@DateStart,@DateEnd,@SatartSalary,@EndSalary,@LeaveReason)";
        }

        public static string LanguageInsertmethod()
        {
            return @"INSERT INTO [dbo].[Language]
           ([ID],[Language],[Listen],[Speak],[Read],[Write])
     VALUES
           (@ID,@Language,@Listen,@Speak,@Read,@Write)";
        }

        public static string Addusermethod()
        {
            return @"Insert into[user](username, password, active, [grant], email) 
     VALUES
            (@username, @password, 'N', @grant, @email)";
        }

        public static string SkillInsertmethod()
        {
            return @"INSERT INTO [dbo].[Skill]
           ([ID],[Language],[Developetools],[Devops],[Os],[Bigdata],[Database],[Cert],[Framwork])
     VALUES
           (@ID,@Language,@Developetools,@Devops,@Os,@Bigdata,@Database,@Cert,@Framwork)";
        }
    }

    
    public class SqlUpdate
    {
        public static string ChangePasswordmethod()
        {
            return @"update [user] set Password=@password where UserName=@username"
;
        }
    }

    public class SqlDelete
    {
        public static string AlluserDeletemethod()
        {
            return @"delete from [user] where username = @username";
        }
    }


}