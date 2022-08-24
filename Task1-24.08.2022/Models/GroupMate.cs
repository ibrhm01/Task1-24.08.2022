using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_24._08._2022.Models
{
    class GroupMate
    {
        private Student[] _students;
        public Student this[int index]
        {
            get
            {
                if (index < _students.Length) return _students[index];
                throw new Exception();
            }
            set
            {
                Array.Resize(ref _students, _students.Length + 1);
                if (index < _students.Length)
                {
                    _students[index] = value;
                    return;
                }
                throw new Exception();
            }
        }
        public GroupMate()
        {
            _students = new Student[0];
        }

        
        public void Sort()
        {

            for (int i = 0; i < _students.Length - 1; i++)
            {
                int maxInd = i;
                for (int j = i + 1; j < _students.Length; j++) 
                {
                    if (_students[i] < _students[j]) maxInd = j;
                }
                Student temp = _students[maxInd];
                _students[maxInd] = _students[i];
                _students[i] = temp;

            }
        }
    }
}
