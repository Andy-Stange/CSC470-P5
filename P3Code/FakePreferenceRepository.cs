using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Code
{
    public class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "Project_ID";
        public const string PREFERENCE_PROJECT_NAME = "Project_Name";
        public const string NO_ERROR = "";

        public Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();

        public string GetPreferences(string Username, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string pref = "";
            if(preferences.TryGetValue(Username, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out pref);
            }
            return pref;
        }

        public string SetPreference(string Username, string PreferenceName, string Value)
        {
            Dictionary<string,string> preference = new Dictionary<string,string>();
            string User = null;
            foreach(KeyValuePair<string,Dictionary<string,string>> pref in preferences)
            {
                if(pref.Key == Username)
                {
                    User = pref.Key;
                    pref.Value.Add(PreferenceName, Value);
                    return NO_ERROR;
                }
            }
            if(User == null)
            {
                preference.Add(PreferenceName, Value);
                preferences.Add(Username, preference);
            }
            return NO_ERROR;
        }







    }
}
