using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RGIS.Units.Helper
{
    public static class UnitListings
    {
        private static List<Type> GetUnitList()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "RGIS.Units").ToList();
        }

        public static List<string> GetDistanceTypes()
        {
            List<Type> theList = GetUnitList();
            List<string> stringList = new();
            foreach (Type name in theList)
            {
                stringList.Add(name.Name);
            }
            return stringList;
        }

        public static string GetDistanceTypesString(bool withEnumeration = false)
        {
            string result = "";
            List<string> list = GetDistanceTypes();
            int counter = 1;
            foreach (string element in list)
            {
                if (withEnumeration)
                {
                    result += counter + ". " + element + "\n";
                    counter++;
                }
                else
                {
                    result += element + "\n";
                }

            }
            return result;
        }

        public static List<IDistance> GetDistanceList(IDistance value)
        {
            List<IDistance> list = new();
            List<Type> result = GetUnitList();
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Type currentType in result)
            {
                IDistance item = assembly.CreateInstance("RGIS.Units." + currentType.Name) as IDistance;
                item.Set(value);
                list.Add(item);
            }

            return list;
        }
    }
}
