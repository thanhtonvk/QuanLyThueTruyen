using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyThueTruyen.DataAccess
{
    class NhanVien_DAL
    {
        static string filepath = "NhanVien.txt";
        public void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] arr = line.Split("#");
                        arrayList.Add(new NhanVien(arr[0], arr[1], arr[2], arr[3], arr[4]));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GhiFile(ArrayList arrayList)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filepath))
                {
                    foreach (NhanVien NhanVien in arrayList)
                    {
                        streamWriter.WriteLine(NhanVien.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
