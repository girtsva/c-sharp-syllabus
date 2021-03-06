using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Dog
    {
        private string _name;
        private bool _isMale;
        public Dog Mother { private get; set; }
        public Dog Father { private get; set; }

        public Dog(string name, bool isMale, Dog mother = null, Dog father = null)
        {
            _name = name;
            _isMale = isMale;
            Mother = mother;
            Father = father;
        }

        public string FathersName()
        {
            return Father == null ? "Unknown" : Father._name;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return Mother == otherDog.Mother ? true : false;
        }

    }
}
