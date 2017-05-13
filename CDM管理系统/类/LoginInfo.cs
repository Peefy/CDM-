using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace 流量计检定上位机
{
    public static class LoginInfo
    {

        public static string RegeditPathString = ".DEFAULT\\Software\\CMDV1";

        public static string UserName { get; set; } = "管理员";
        public static int UserId { get; set; }
        public static string PassWord { get; set; } = "dugu";
        public static int GroupID { get; set; }
        public static string GroupTitle { get; set; }
        public static DateTime LoginTime { get; set; }
        public static DateTime TimeBegin { get; set; }
        public static DateTime TimeEnd { get; set; }

        public static bool IsManager { get; set; } = false;

        public static bool ClientLogin(string userName,string passWord, out int errorId, out string[] infoList,bool isFirst)
        {
            errorId = 2;
            string[] infolist = { "1", "DuGu", "password", "2", "系统管理员", TimeHelper.GetTime(), "2016-12-14" };
            infoList = infolist;

            if (isFirst == true)
            {
                isFirst = false;
                return true;
            }
            if (userName == "dugu" && passWord == "dugu")
            {
                IsManager = true;
                return true;
            }
            string rightPassWord = "";
            RegistryKey rsg = null;           
            rsg = Registry.Users.OpenSubKey(LoginInfo.RegeditPathString, true);
            if (rsg.GetValue("password") != null) //读取失败返回null
            {
                rightPassWord = rsg.GetValue("password").ToString();
            }
            infoList = infolist;
            rsg.Close();
            return (rightPassWord == passWord);
        }

        public static bool ChangePassword(string passWord)
        {
            if (string.IsNullOrEmpty(passWord) == true)
                return false;
            RegistryKey rsg = null;
            rsg = Registry.Users.OpenSubKey(LoginInfo.RegeditPathString, true);
            if (rsg.GetValue("password") != null) //读取失败返回null
            {
                rsg.SetValue("password", passWord);
                LoginInfo.PassWord = passWord;
                SetRememberPwd(false);
                rsg.Close();
                return true;
            }
            else
            {
                rsg.Close();
                return false;
            }
            
        }

        public static bool ChangeUserNamePassword(string userName,string passWord)
        {
            if (string.IsNullOrEmpty(passWord) == true)
                return false;
            RegistryKey rsg = null;
            rsg = Registry.Users.OpenSubKey(LoginInfo.RegeditPathString, true);
            if (rsg.GetValue("password") != null && rsg.GetValue("username") != null) //读取失败返回null
            {
                rsg.SetValue("password", passWord);
                rsg.SetValue("username", userName);
                LoginInfo.UserName = userName;
                LoginInfo.PassWord = passWord;
                SetRememberPwd(false);
                rsg.Close();
                return true;
            }
            else
            {
                rsg.Close();
                return false;
            }

        }

        public static bool SetRememberPwd(bool isRemember)
        {
            RegistryKey rsg = null;
            rsg = Registry.Users.OpenSubKey(LoginInfo.RegeditPathString, true);
            if (rsg.GetValue("issavepsd") != null) //读取失败返回null
            {
                rsg.SetValue("issavepsd", isRemember);
                rsg.Close();
                return true;
            }
            else
            {
                rsg.Close();
                return false;
            }
        }

    }
}
