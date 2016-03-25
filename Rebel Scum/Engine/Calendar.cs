using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RebelScum.Model
{
    public static class GameCalendar
    {
        private static XmlSerializer calendarSerializer = new XmlSerializer(typeof (string));

    }
}
