using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public interface IPositionsManagement
    {
        public void FindPositionByID(int id);
        public void FindPositionByTitle(string title);
        public void WriteOutAllPositions();
    }
}
