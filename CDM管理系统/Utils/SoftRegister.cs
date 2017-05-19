﻿using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CDM.Utils
{
    class SoftRegister
    {
        static readonly string user = new Guid().ToString();
        static readonly string RegFreeList = "0";

        static string MachineCode
        {
            get { return user + RegFreeList;  }
        }

        public static bool IsRegister()
        {
            string registerString = "";
            RegistryKey rsg = null;
            rsg = Registry.Users.OpenSubKey(LoginInfo.RegeditPathString);
            if (rsg.GetValue("register") != null) //读取失败返回null
            {
                registerString = rsg.GetValue("register").ToString();
            }
            rsg.Close();
            return registerString == getRNum_md5(user + RegFreeList);
         
        }

        public static bool RegisterING(string mNum)
        {
            var md5 = getRNum_md5(user + RegFreeList);
            if(mNum == md5)
            {
                RegistryKey rsg = null;
                rsg = Registry.Users.OpenSubKey(LoginInfo.RegeditPathString, true);//true表示可以修改
                rsg.SetValue("register", md5);//写入注册表
                rsg.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        static string getRNum_md5(string mNum)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(mNum);
            byte[] encryptdata = md5.ComputeHash(palindata);
            return Convert.ToBase64String(encryptdata);
        }

        public static string GetFreeRegisterNum()
        {
            return getRNum_md5(user + RegFreeList);
        }

    }
}
