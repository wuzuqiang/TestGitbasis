﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    class DirUtil
    {
        public void recycleChangeDir(string path, string match, string toMatch)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileSystemInfo[] fileSysArray = directoryInfo.GetFileSystemInfos();
            foreach(FileSystemInfo info in fileSysArray)
            {
                if(info is DirectoryInfo)
                {
                    recycleChangeDir(info.FullName, match, toMatch);
                }
                else
                {
                    if(info.FullName.Contains(match))
                    {
                        File.Move(info.FullName, info.FullName.Replace(match, toMatch));
                    }
                }
            }
        }

        public FileInfo[] getAllFile(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.GetFiles("*", SearchOption.AllDirectories);
        }

        public FileInfo[] getAllFile(string path, string contained)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return directoryInfo.GetFiles("*"+contained+"*", SearchOption.AllDirectories);
        }

        public DirectoryInfo[] getAllDir(string path)
        {
            return (new DirectoryInfo(path)).GetDirectories("*", SearchOption.AllDirectories);
        }

        public void createDir(string path)
        {
            Directory.CreateDirectory(path);
        }

        public List<string> get第二级别下各自的一行目录或者文件(string path)
        {
            List<string> listFile = new List<string>();
            //d:\aa\bb\cc\dd\ee\ff\gg
            //需要得到类似d:\aa\bb\cc[.txt]的字符串
            string pattern = @"\w+:\\\w+\\\w+";
            //string input = @"d:\aa\bb\cc\dd\ee\ff\gg";
            Regex regex = new Regex(pattern);
            MatchCollection matchs = regex.Matches(path);
            if(matchs.Count > 0)
            {
                path = matchs[0].Value;
            }
            else
            {
                throw new Exception(string.Format("未能匹配到路径：{0}的第二级别路径名", path));
            }

            return listFile;
        }

        public void get(string path)
        {
            List<string> listFile = new List<string>();
            FileSystemInfo[] fileSysArray = (new DirectoryInfo(path)).GetFileSystemInfos();
            foreach (FileSystemInfo info in fileSysArray)
            {
                if (info is DirectoryInfo)
                {
                    getAllFile(info.FullName);
                }
                else
                {
                    listFile.Add(info.FullName);
                }
            }
        }

    }
}
