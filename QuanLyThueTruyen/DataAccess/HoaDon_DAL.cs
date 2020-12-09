using QuanLyThueTruyen.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyThueTruyen.DataAccess
{
    class HoaDon_DAL
    {
        static string filepath = "HoaDon.txt";
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
                        arrayList.Add(new HoaDon(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7]));
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
                    foreach (HoaDon HoaDon in arrayList)
                    {
                        streamWriter.WriteLine(HoaDon.ToString());
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
