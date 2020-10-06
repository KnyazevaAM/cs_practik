using System;
using System.Collections.Generic;
using System.Text;

namespace ser_class
{
  [Serializable]
  class student
  {
    private string name;

    public student()
    {
      Name = "null artem";
    }

    public student(string name)
    {
      Name = name;
    }

    public string Name { get { return name; }
      set { if (value == "artem") { 
          name = "Artem Velikolepniy";
        }
      } }


    public override string ToString()
    {
      return name;
    }


  }
}
