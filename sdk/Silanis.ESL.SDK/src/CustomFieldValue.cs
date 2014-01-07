using System;
using Silanis.ESL.API;

namespace Silanis.ESL.SDK
{
    public class CustomFieldValue
    {
        public CustomFieldValue()
        {
        }
        public string Id { 
                get;
                set;
        }

        public string Value {
                get;
                set;
        }
        
		internal UserCustomField toAPIUserCustomField() {
            UserCustomField result = new UserCustomField();
			result.Name = "";
            result.Id = Id;
            result.Value = Value;
            return result;
        }
        
    }
}

