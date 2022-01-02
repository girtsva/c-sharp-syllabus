using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory() {
            _data = new SortedDictionary<string, string>();
        }

        public bool Find(string name)
        {
            return (_data.ContainsKey(name));            
        }

        public string GetNumber(string name) 
        {
            if (!Find(name))
            {
                Console.WriteLine("Number not found!");
                return null;
            } 
            else 
            {
                return _data[name];
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }
            
            if (Find(name)) 
            {
                _data[name] = number;
            }
            else 
            {
                _data.Add(name, number);
            }
        }

        public void ShowWholePhonebook()
        {
            foreach (var record in _data)
            {
                Console.WriteLine($"Name: {record.Key,-10} | Number: {record.Value}");
            }
        }
    }
}