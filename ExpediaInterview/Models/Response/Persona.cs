using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpediaInterview.Models
{
    enum Personas
    {
        NONE,
        OTHERS,
        AWESOME
    }

    [DataContract(Name = "persona")]
    public class Persona
    {
        private string _PersonaType;

        [DataMember(Name = "personaType")]
        public string PersonaType
        {
            get
            {
                return this._PersonaType;
            }

            set
            {
                try
                {
                    Enum.Parse(typeof(Personas), value);
                    this._PersonaType = value;
                }
                catch (Exception)
                {
                    throw new FormatException("Invalid Persona In User Info");
                }

            }
        }

    }
}
