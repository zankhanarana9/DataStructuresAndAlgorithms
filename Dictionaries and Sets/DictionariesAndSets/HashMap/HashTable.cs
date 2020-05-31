using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class HashTable
    {
        private StudentRecord[] Records;
        private int length;
        int NumOfRecords;

        public HashTable() : this(11) { }

        public HashTable(int tableSize)
        {
            length = tableSize;
            Records = new StudentRecord[length];
            NumOfRecords = 0;
        }

        int hash(int key)
        {
            return (key % length);
        }

        public void Insert(StudentRecord record)
        {
            int key = record.StudentId;
            int h = hash(key);

            int location = h;
            for(int i =0;i< length;i++)
            {
                if(Records[location] == null || Records[location].StudentId != -1) {
                    Records[location] = record;
                    NumOfRecords++;
                    return;
                }

                if(Records[location].StudentId == key)
                {
                    throw new System.InvalidOperationException("Duplicate Key");
                }

                location = (h + i) % length;
            }
            Console.WriteLine("Table is full: Record cannot be inserted");
        }

        public StudentRecord SearchStudent(int key)
        {
            int h = hash(key);
            int location = h;

            for(int i = 0; i< length; i++)
            {
                if(Records[location] == null)
                {
                    return null;
                }
                if(Records[location].StudentId == key)
                {
                    return Records[location];
                }

                location = (h + i) % length;
            }

            return null;
        }
        public StudentRecord Delete(int key)
        {
            int h = hash(key);
            int location = h;
            for(int i = 0; i < length; i++)
            {
                if(Records[location] == null)
                {
                    return null;
                }

                if(Records[location].StudentId == key)
                {
                    StudentRecord temp = Records[location];
                    Records[location].StudentId = -1;
                    NumOfRecords--;
                    return temp;
                }
                location = (h + i) % length;
            }
            return null;
        }
        public void DisplayTable()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("[" + i + "] --> ");
                if(Records[i] != null && Records[i].StudentId != -1)
                {
                    Console.WriteLine(Records[i].ToString());
                }
                else
                {
                    Console.WriteLine("___");
                }
            }
        }
    }
}
