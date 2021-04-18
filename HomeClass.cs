using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone_Project
{
    static class HomeClass      //static to be accessible by all the forms in the app
    {
        public enum ServiceList    //used in combobox to display services, and dictionary
        {
            Lesson10Min,
            Lesson15Min,
            Lesson20Min,
            Lesson25Min,
            Lesson30Min,
            Sharpening,
            Boots,
            Payment
        }
        
        //public is accessible by all the forms
        //private is accessible by methods in this class
        public static Dictionary<ServiceList, double> ServiceAndCost = new Dictionary<ServiceList, double>();

        //set paths and lists for the text files

        private static string CustListFilePath = @"CapstoneFiles\customers.txt";
        public static List<string> CustList = new List<string>();
        private static string IdListFilePath = @"CapstoneFiles\customer_id_list.txt";
        public static List<string> IdList = new List<string>();
        private static string CustomerServicesListFilePath = @"CapstoneFiles\customer_services.txt";
        public static List<string> CustomerServicesList = new List<string>();

        //to store customer info to be used in the get and set methods below

        private static string CustId;
        private static string CustName;
        private static string CustMail;
        private static string UserSelect;

        //dictionary 

        public static void InitializeServiceAndCost()
        {
            ServiceAndCost.Add(ServiceList.Lesson10Min, 12.00);
            ServiceAndCost.Add(ServiceList.Lesson15Min, 18.00);
            ServiceAndCost.Add(ServiceList.Lesson20Min, 24.00);
            ServiceAndCost.Add(ServiceList.Lesson25Min, 30.00);
            ServiceAndCost.Add(ServiceList.Lesson30Min, 36.00);
            ServiceAndCost.Add(ServiceList.Sharpening, 20.00);
            ServiceAndCost.Add(ServiceList.Boots, 200.00);
            ServiceAndCost.Add(ServiceList.Payment, 0);

        }

        /// <summary>
        /// Method calling the method (WriteToFile) to write 
        /// information from the txt files to the lists
        /// </summary>
        internal static void WriteListsToFile()
        {
            string filePath;
            filePath = CustListFilePath;
            WriteToFile(CustList, filePath);
            filePath = IdListFilePath;
            WriteToFile(IdList, filePath);
            filePath = CustomerServicesListFilePath;
            WriteToFile(CustomerServicesList, filePath);

        }

        /// <summary>
        /// Method writing the updated list back into the files
        /// </summary>
        /// <param name="custList"></param>
        /// <param name="filePath"></param>
        private static void WriteToFile(List<string> custList, string filePath)
        {
            try
            {
                 File.WriteAllLines(filePath, custList);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Not Found: " + filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to Opent the File: " + filePath);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to Read the File at this Path: " + filePath);
            }
        }

        //Methods to store and return user input/choices
        public static void SetUserSelect(string userSelect)
        {
            UserSelect = userSelect;
        }

        public static string GetUserSelect()
        {
            return UserSelect;
        }

        public static void SetCustomerList()
        {
            CustList = LoadListFromFile(CustListFilePath);
        }

        public static void SetIdList()
        {
            IdList = LoadListFromFile(IdListFilePath);
        }

        public static void SetCustomerServicesList()
        {
            CustomerServicesList = LoadListFromFile(CustomerServicesListFilePath);
        }


        public static List<string> GetCustomerList()
        {
            return CustList;
        }


        public static void SetCustMail(string custMail)
        {
            CustMail = custMail;
        }

        public static string GetCustMail()
        {
            return CustMail;
        }


        public static void SetCustId(string custId)
        {
            CustId = custId;
        }

        public static string GetCustId()
        {
            return CustId;
        }

        public static void SetCustName(string firstName, string lastName)
        {
            CustName = firstName + " " + lastName;
        }

        public static string GetCustName()
        {
            return CustName;
        }

        /// <summary>
        /// Method taking list of existsing ID's and finds next id #
        /// </summary>
        /// <returns></returns>
        public static string GetNextCustomerID()
        {
            IdList.Sort();
            string item = IdList[IdList.Count - 1];
            int custId;
            int.TryParse(item, out custId);
            int nextCustId = custId + 1;

            IdList.Add(nextCustId.ToString());
            return nextCustId.ToString();
        }

        /// <summary>
        /// Method reading from files and writing to lists.
        /// </summary>
        /// <param name="custListFilePath"></param>
        /// <returns></returns>
        private static List<string> LoadListFromFile(string custListFilePath)
        {
            List<string> fileItems = new List<string>();

            try
            {
                fileItems = File.ReadAllLines(custListFilePath).ToList();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Not Found: " + custListFilePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to Opent the File: " + custListFilePath);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to Read the File at this Path: " + custListFilePath);
            }
            return fileItems;
        }
    }
}
