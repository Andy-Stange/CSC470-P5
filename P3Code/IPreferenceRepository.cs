using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Code
{
    public interface IPreferenceRepository
    {
        string GetPreferences(string Username, string PreferenceName);
        string SetPreference(string Username, string PreferenceName, string Value);
    }
}
