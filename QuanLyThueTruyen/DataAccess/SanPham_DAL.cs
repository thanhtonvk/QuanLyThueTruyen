using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyThueTruyen.DataAccess
{
    class SanPham_DAL
    {
        static string filepath = "SanPham.txt";
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
                        arrayList.Add(new SanPham(arr[0],arr[1],arr[2],int.Parse(arr[3]), int.Parse(arr[4]), int.Parse(arr[5])));
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
                    foreach (SanPham SanPham in arrayList)
                    {
                        streamWriter.WriteLine(SanPham.ToString());
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
